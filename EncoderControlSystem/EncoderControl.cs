using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace EncoderControlSystem
{
    public partial class EncoderControl : Form
    {
        /*Zed Grap Variables*/
        double setpointdp = 0;
        double setpoint=0;
        double measure = 0;
        double realtime = 0;
        double realtimestep = 0.02;

        /*Defaul value for Run and Stop mode*/
        string stopstr = "0";
        string runstr = "1200";

        /*Send and Receive Variables */
        string outBuffer;
        byte[] sendBuffer = new byte[7];
        byte[] receiveBuffer = new byte[7];

        /* Variables for Stream Writing file Test */
        string txtPathFile = @"D:\BKeL\3nd Junior\DK DL BMT\BTL\GUI\EncoderControlSystem\DataFile.txt";

        /*Timer control Variables */

        /* Idea
         * Timer 10ms để xác nhận ACK hoặc có Data từ STM trả về
         * Timer 1s để bắt đầu lại chu kỳ gửi
         */
         
        bool confirmFlag = false;    //false: chưa nhận được ACK or Data từ STM; True: đã nhận được rồi
        bool cycleSendFlag = false;  //false: chưa hết chu kì 1s tiếp tục chờ; true: hết chu kỳ 1s mới gửi khung mới

        /* Main */
        public EncoderControl()
        {
            InitializeComponent();
                      
        }

        /*Form load*/
        private void EncoderControl_Load(object sender, EventArgs e)
        {
            /*Khởi tạo Zedgraph vẽ đồ thị*/
            GraphPane myPane = zGraph.GraphPane;      //Tác động các thành phần của Control, (GraphPane)

            /*Tên đồ thị Title sẽ được cài đặt khi radianButton được nhấn tương ứng*/
            myPane.Title.Text = "Giá trị đặt - Giá trị đo";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";

            myPane.XAxis.Scale.Min = 0;                         //Đặt giới hạn đồ thị
            myPane.XAxis.Scale.Max = 6;
            myPane.XAxis.Scale.MinorStep = 0.1;                   //Đặt các bước độ chia
            myPane.XAxis.Scale.MajorStep = 1;
            myPane.YAxis.Scale.Min = 0;                      //Tương tự cho trục y
            myPane.YAxis.Scale.Max = 500;

            RollingPointPairList list = new RollingPointPairList(60000);        //Tạo mới danh sách dữ liệu 60000 phần tử, có khả năng cuốn chiếu
            LineItem curve = myPane.AddCurve("Giá trị đặt", list, Color.Red, SymbolType.None);         //Tạo mới đường cong của đồ thị trên GraphPane dựa vào danh sách dữ liệu
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem curve2 = myPane.AddCurve("Giá trị đo", list2, Color.MediumSlateBlue, SymbolType.None);

            myPane.AxisChange();

        }




        /* Event */

        /* Serial Port*/

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                sPort.PortName = cbb_PortName.Text;
                sPort.BaudRate = Int32.Parse(cbb_BaudRate.Text);
                sPort.DataBits = Int32.Parse(cbb_DataBit.Text);
                sPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbb_Parity.Text);
                sPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbb_StopBit.Text);
                sPort.Open();                
                btn_Connect.Enabled = false;
                btn_Disconnect.Enabled = true;
                lb_Status.Text = "Connected";
                lb_Status.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {

            try
            {                
                sPort.Close();
                btn_Connect.Enabled = true;
                btn_Disconnect.Enabled = false;
                lb_Status.Text = "Disconnected";
                lb_Status.ForeColor = Color.Red;
                setpoint = 0;
                measure = 0;
                realtime = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }        

        private void btn_GetPortName_Click(object sender, EventArgs e)
        {
            cbb_PortName.DataSource = SerialPort.GetPortNames();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
            {
                try
                {
                    //byte[] sendData = ProtocolProcess.encodeFrame(ProtocolProcess.frameCode.Datasend, txb_Transmitter.Text);
                    //sPort.Write(sendData, 0, 7);
                    complexSendMethod(ProtocolProcess.frameCode.Datasend, txb_Transmitter.Text);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                }
            }
            else
            {
                MessageBox.Show("No COM was connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ClearReceiver_Click(object sender, EventArgs e)
        {
            txb_Receiver.Text = null;
        }

                /*Event Radio Button*/
        private void rdb_Velo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Velo.Checked == true)
            {
                grb_Velo.Enabled = true;
                grb_Pos.Enabled = false;
                ClearGraph("Đồ thị tốc độ theo thời gian", 0, 300);

            }
            else
            {
                grb_Velo.Enabled = false;
                //ClearGraph("Đồ thị vị trí theo thời gian", 0, 600);
            }
        }

        private void rdb_Pos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Pos.Checked == true)
            {
                grb_Velo.Enabled = false;
                grb_Pos.Enabled = true;
                ClearGraph("Đồ thị vị trí theo thời gian", 0, 600);
            }
            else
            {
                grb_Pos.Enabled = false;
                //ClearGraph("Đồ thị tốc độ theo thời gian", 0, 2500);
            }

        }

                /*Event truyền giá trị*/
        private void txb_Kp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter) complexSendMethod(ProtocolProcess.frameCode.Kp, txb_Kp.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txb_Ki_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter) complexSendMethod(ProtocolProcess.frameCode.Ki, txb_Ki.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txb_Kd_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter) complexSendMethod(ProtocolProcess.frameCode.Kd, txb_Kd.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txb_RealtimeStep_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter) realtimestep= double.Parse(txb_RealtimeStep.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_SetSpVelo_Click(object sender, EventArgs e)
        {
            try
            {
                setpointdp = double.Parse(txb_SpVelo.Text);
                if (cbx_Reverse.Checked) complexSendMethod(ProtocolProcess.frameCode.VeloRev, txb_SpVelo.Text);
                else complexSendMethod(ProtocolProcess.frameCode.VeloFor, txb_SpVelo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            try
            {
                complexSendMethod(ProtocolProcess.frameCode.Run, runstr);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                complexSendMethod(ProtocolProcess.frameCode.Stop, stopstr);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_SetSpPos_Click(object sender, EventArgs e)
        {
            try
            {
                setpointdp = double.Parse(txb_SpPos.Text);
                complexSendMethod(ProtocolProcess.frameCode.SetpointPos, txb_SpPos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_SetHome_Click(object sender, EventArgs e)
        {
            try
            {
                complexSendMethod(ProtocolProcess.frameCode.Home, "0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_ClearGraph_Click(object sender, EventArgs e)
        {
            if (rdb_Pos.Checked)
                ClearGraph("Đồ thị vị trí theo thời gian", 0, 600);
            else ClearGraph("Đồ thị tốc độ theo thời gian", 0, 2500);
        }


        /*  Method  */
        /* Serial Port Receive Data Method */
        private void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receiveBuffer = readReceiveData();
            this.Invoke(new EventHandler(processReceiveData));
        }

        private byte[] readReceiveData ()
        {
            byte[] tempByte = new byte[7];
            byte[] returnByte = new byte[7];
            for (int i=0; i<7; i++)
            {
                tempByte[i] = Convert.ToByte(sPort.ReadByte());
            }
            
            if ((tempByte[0] == (byte)ProtocolProcess.frameProcedure.STX) && (tempByte[6] == (byte)ProtocolProcess.frameProcedure.ETX))
            {
                returnByte = tempByte;
            }

            return returnByte = tempByte;
        }

        private void processReceiveData (object sender, EventArgs e)
        {
            confirmFlag = true;
            byte[] processedData;
            ProtocolProcess.frameCode funcCode = ProtocolProcess.decodeFrame(receiveBuffer, out processedData);
            float mainValue = ProtocolProcess.byteToFloat(processedData);
            switch (funcCode)
            {
                case ProtocolProcess.frameCode.Datasend:                    
                    //txb_Receiver.Text += "TEST Nhận: ";
                    //txb_Receiver.Text += mainValue.ToString();
                    //txb_Receiver.Text += Environment.NewLine;

                    /*Test File*/
                    WriteNewLineTXTFile(txtPathFile, mainValue.ToString());
                    /*----------*/
                    break;
                case ProtocolProcess.frameCode.ACK:
                    txb_Receiver.Text += "Xác nhận ACK ";
                    //txb_Receiver.Text += mainValue.ToString();
                    txb_Receiver.Text += Environment.NewLine;
                    break;
                case ProtocolProcess.frameCode.VeloFor:
                    setpoint = setpointdp;
                    measure = mainValue;
                    realtime += realtimestep;
                    txb_Velo.Text = mainValue.ToString();
                    txb_ReFor.Text = "For";
                    //txb_Receiver.Text += $"Giá trị Velo đọc về: {mainValue.ToString()} Thuận";
                    //txb_Receiver.Text += Environment.NewLine;
                    break;
                case ProtocolProcess.frameCode.VeloRev:
                    setpoint = setpointdp;
                    measure = mainValue;
                    realtime += realtimestep;
                    txb_Velo.Text = mainValue.ToString();
                    txb_ReFor.Text = "Rev";
                    //txb_Receiver.Text += $"Giá trị Velo đọc về: {mainValue.ToString()} Ngược";
                    //txb_Receiver.Text += Environment.NewLine;
                    break;
                case ProtocolProcess.frameCode.Pos:
                    setpoint = float.Parse(txb_SpPos.Text);
                    measure = mainValue;
                    realtime += realtimestep;
                    txb_Pos.Text = mainValue.ToString();
                    //txb_Receiver.Text += $"Giá trị Pos đọc về: {mainValue.ToString()}";
                    //txb_Receiver.Text += Environment.NewLine;
                    break;
                default:
                    break;
            }

            /*Vẽ Zed graph giá trị đã nhận được*/
            Draw();
        }
        /*--------------------------------------------------------------------------------------*/


        /* Complex send Method send and Activate Timer */
        private void complexSendMethod (ProtocolProcess.frameCode cf, string data )
        {
            try
            {
                confirmFlag = false;
                cycleSendFlag = false;
                timer10ms.Stop();
                timer1s.Stop();
                /*Gửi frame*/
                sendBuffer = ProtocolProcess.encodeFrame(cf, data);
                sPort.Write(sendBuffer, 0, 7);
                //txb
                for (int i=0; i<7; i++)
                {
                    txb_SendMonitor.Text += sendBuffer[i].ToString();
                }
                txb_SendMonitor.Text += Environment.NewLine;
                //Kết thúc

                
                /*Kích hoạt timer*/
                timer10ms.Start();
                timer1s.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void timer10ms_Tick(object sender, EventArgs e)
        {
                if (confirmFlag == true) timer10ms.Stop();
                else
                {
                    sPort.Write(sendBuffer, 0, 7);
                }       
                       
        }

        private void timer1s_Tick(object sender, EventArgs e)
        {
            cycleSendFlag = true;
            timer1s.Stop();
            timer10ms.Stop();
        }

        

        /*-------------------------------------------------------------------------------------*/
        /*Test data*/
        /*Tăng giá trị testData từ 0 lên sau mỗi 10ms và test thử xem
         * STM có trả ACK or Data về hay không
         */

        int testData = 0;
        private void btn_TestData_Click(object sender, EventArgs e)
        {
            
            complexSendMethod(ProtocolProcess.frameCode.Datasend, testData.ToString());
            timersub.Start();
        }
        private void timersub_Tick(object sender, EventArgs e)
        {
            testData++;
            /*Ghi dữ liệu gửi đi*/
            WriteNewLineTXTFile(txtPathFile, testData.ToString());
            txb_Receiver.Text += "TEST Gửi: ";
            txb_Receiver.Text += testData.ToString();
            txb_Receiver.Text += Environment.NewLine;
            /*----------------------------------------------*/
            complexSendMethod(ProtocolProcess.frameCode.Datasend, testData.ToString());
            if (testData == 100) timersub.Stop();
        }

        /* Write Txt file Method */
        private void WriteNewLineTXTFile(string path, string message)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(message);
            }
        }

        /*-------------------------------------------------------------------------------------*/

        /*Vẽ Zed Graph*/
        private void Draw()
        {
            LineItem curve = zGraph.GraphPane.CurveList[0] as LineItem; //Khai báo đường cong từ danh sách đường công của đồ thị (Kế thừa)
            if (curve == null)
                return;
            LineItem curve2 = zGraph.GraphPane.CurveList[1] as LineItem;
            if (curve2 == null)
                return;
            IPointListEdit list = curve.Points as IPointListEdit; //Danh sách dữ liệu cho đường cong đồ thị
            if (list == null)
                return;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            if (list2 == null)
                return;
            list.Add(realtime, setpoint);
            list2.Add(realtime, measure);

            Scale xScale = zGraph.GraphPane.XAxis.Scale; //Giới hạn Graph
            Scale yScale = zGraph.GraphPane.YAxis.Scale;

            // Tự động Scale theo trục x
            if (realtime > xScale.Max - xScale.MajorStep)       //Nếu realtime lớn hơn Max x trừ đi 1 MajorStep (2 vạch lớn)
            {
                xScale.Min = xScale.Min + realtime - (xScale.Max - xScale.MajorStep);
                xScale.Max = realtime + xScale.MajorStep;       //Tự dời đồ thị qua 1 MajorStep 
                                                                //xScale.Min = xScale.Max - 6;
            }
            // Tự động Scale theo trục y
            if (setpoint > yScale.Max - yScale.MajorStep)          //Nếu datas vượt quá giới hạn trừ 1 MajorStep
            {
                yScale.Max = setpoint + yScale.MajorStep;          //Thì tăng giới hạn thêm 1 MajorStep
            }
            else if (setpoint < yScale.Min + yScale.MajorStep)
            {
                yScale.Min = setpoint - yScale.MajorStep;
            }

            zGraph.AxisChange();
            zGraph.Invalidate();
        }

        private void ClearGraph(string Title, int ymin, int ymax)
        {
            zGraph.GraphPane.CurveList.Clear();                  // Xóa đường
            zGraph.GraphPane.GraphObjList.Clear();               // Xóa đối tượng
            zGraph.AxisChange();
            zGraph.Invalidate();

            realtime = 0;
            //setpoint = 0;
            measure = 0;

            // Khởi tạo ZedGraph            
            GraphPane myPane = zGraph.GraphPane;      //Tác động các thành phần của Control, (GraphPane)
            myPane.Title.Text = Title;
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";

            myPane.XAxis.Scale.Min = 0;                         //Đặt giới hạn đồ thị
            myPane.XAxis.Scale.Max = 6;
            myPane.XAxis.Scale.MinorStep = 0.1;                   //Đặt các bước độ chia
            myPane.XAxis.Scale.MajorStep = 1;
            myPane.YAxis.Scale.Min = ymin;                      //Tương tự cho trục y
            myPane.YAxis.Scale.Max = ymax;

            RollingPointPairList list = new RollingPointPairList(60000);        //Tạo mới danh sách dữ liệu 60000 phần tử, có khả năng cuốn chiếu
            LineItem curve = myPane.AddCurve("Giá trị đặt", list, Color.Red, SymbolType.None);         //Tạo mới đường cong của đồ thị trên GraphPane dựa vào danh sách dữ liệu
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem curve2 = myPane.AddCurve("Giá trị đo", list2, Color.MediumSlateBlue, SymbolType.None);


            myPane.AxisChange();
        }



        /* Menu strip event */

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bài tập lớn môn\nĐo lường điều khiển bằng máy tính", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
