namespace EncoderControlSystem
{
    partial class EncoderControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_GetPortName = new System.Windows.Forms.Button();
            this.lb_Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.cbb_StopBit = new System.Windows.Forms.ComboBox();
            this.cbb_PortName = new System.Windows.Forms.ComboBox();
            this.cbb_Parity = new System.Windows.Forms.ComboBox();
            this.lbPortName = new System.Windows.Forms.Label();
            this.cbb_DataBit = new System.Windows.Forms.ComboBox();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.cbb_BaudRate = new System.Windows.Forms.ComboBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.lbStopBit = new System.Windows.Forms.Label();
            this.lbDataBit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TestData = new System.Windows.Forms.Button();
            this.btn_ClearReceiver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Receiver = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txb_Transmitter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ClearGraph = new System.Windows.Forms.Button();
            this.txb_RealtimeStep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.zGraph = new ZedGraph.ZedGraphControl();
            this.grb_Pos = new System.Windows.Forms.GroupBox();
            this.btn_SetHome = new System.Windows.Forms.Button();
            this.btn_SetSpPos = new System.Windows.Forms.Button();
            this.txb_Pos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_SpPos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grb_Velo = new System.Windows.Forms.GroupBox();
            this.txb_ReFor = new System.Windows.Forms.TextBox();
            this.cbx_Reverse = new System.Windows.Forms.CheckBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_SetSpVelo = new System.Windows.Forms.Button();
            this.txb_Velo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_SpVelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_Kd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Ki = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Kp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb_Pos = new System.Windows.Forms.RadioButton();
            this.rdb_Velo = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1s = new System.Windows.Forms.Timer(this.components);
            this.timer10ms = new System.Windows.Forms.Timer(this.components);
            this.timersub = new System.Windows.Forms.Timer(this.components);
            this.txb_SendMonitor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grb_Pos.SuspendLayout();
            this.grb_Velo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_GetPortName);
            this.groupBox1.Controls.Add(this.lb_Status);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Disconnect);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Controls.Add(this.cbb_StopBit);
            this.groupBox1.Controls.Add(this.cbb_PortName);
            this.groupBox1.Controls.Add(this.cbb_Parity);
            this.groupBox1.Controls.Add(this.lbPortName);
            this.groupBox1.Controls.Add(this.cbb_DataBit);
            this.groupBox1.Controls.Add(this.lbBaudRate);
            this.groupBox1.Controls.Add(this.cbb_BaudRate);
            this.groupBox1.Controls.Add(this.lbParity);
            this.groupBox1.Controls.Add(this.lbStopBit);
            this.groupBox1.Controls.Add(this.lbDataBit);
            this.groupBox1.Location = new System.Drawing.Point(23, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Setting";
            // 
            // btn_GetPortName
            // 
            this.btn_GetPortName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_GetPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetPortName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GetPortName.Location = new System.Drawing.Point(270, 37);
            this.btn_GetPortName.Name = "btn_GetPortName";
            this.btn_GetPortName.Size = new System.Drawing.Size(163, 42);
            this.btn_GetPortName.TabIndex = 24;
            this.btn_GetPortName.Text = "Get Port Name";
            this.btn_GetPortName.UseVisualStyleBackColor = false;
            this.btn_GetPortName.Click += new System.EventHandler(this.btn_GetPortName_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.Location = new System.Drawing.Point(518, 141);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(172, 29);
            this.lb_Status.TabIndex = 23;
            this.lb_Status.Text = "Disconnected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Status of Connection";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Disconnect.ForeColor = System.Drawing.Color.Red;
            this.btn_Disconnect.Location = new System.Drawing.Point(604, 37);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(127, 42);
            this.btn_Disconnect.TabIndex = 21;
            this.btn_Disconnect.Text = "DISCONNECT";
            this.btn_Disconnect.UseVisualStyleBackColor = false;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Connect.Location = new System.Drawing.Point(463, 37);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(114, 42);
            this.btn_Connect.TabIndex = 20;
            this.btn_Connect.Text = "CONNECT";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // cbb_StopBit
            // 
            this.cbb_StopBit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_StopBit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_StopBit.FormattingEnabled = true;
            this.cbb_StopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbb_StopBit.Location = new System.Drawing.Point(100, 170);
            this.cbb_StopBit.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_StopBit.Name = "cbb_StopBit";
            this.cbb_StopBit.Size = new System.Drawing.Size(129, 24);
            this.cbb_StopBit.Sorted = true;
            this.cbb_StopBit.TabIndex = 19;
            this.cbb_StopBit.Text = "Two";
            // 
            // cbb_PortName
            // 
            this.cbb_PortName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_PortName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_PortName.FormattingEnabled = true;
            this.cbb_PortName.Location = new System.Drawing.Point(100, 37);
            this.cbb_PortName.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_PortName.Name = "cbb_PortName";
            this.cbb_PortName.Size = new System.Drawing.Size(129, 24);
            this.cbb_PortName.TabIndex = 10;
            // 
            // cbb_Parity
            // 
            this.cbb_Parity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_Parity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_Parity.FormattingEnabled = true;
            this.cbb_Parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cbb_Parity.Location = new System.Drawing.Point(100, 137);
            this.cbb_Parity.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Parity.Name = "cbb_Parity";
            this.cbb_Parity.Size = new System.Drawing.Size(129, 24);
            this.cbb_Parity.TabIndex = 18;
            this.cbb_Parity.Text = "None";
            // 
            // lbPortName
            // 
            this.lbPortName.AutoSize = true;
            this.lbPortName.Location = new System.Drawing.Point(16, 41);
            this.lbPortName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(75, 17);
            this.lbPortName.TabIndex = 15;
            this.lbPortName.Text = "Port Name";
            // 
            // cbb_DataBit
            // 
            this.cbb_DataBit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_DataBit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_DataBit.FormattingEnabled = true;
            this.cbb_DataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbb_DataBit.Location = new System.Drawing.Point(100, 104);
            this.cbb_DataBit.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_DataBit.Name = "cbb_DataBit";
            this.cbb_DataBit.Size = new System.Drawing.Size(129, 24);
            this.cbb_DataBit.TabIndex = 17;
            this.cbb_DataBit.Text = "8";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(15, 74);
            this.lbBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(75, 17);
            this.lbBaudRate.TabIndex = 14;
            this.lbBaudRate.Text = "Baud Rate";
            // 
            // cbb_BaudRate
            // 
            this.cbb_BaudRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_BaudRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_BaudRate.FormattingEnabled = true;
            this.cbb_BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cbb_BaudRate.Location = new System.Drawing.Point(100, 71);
            this.cbb_BaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_BaudRate.Name = "cbb_BaudRate";
            this.cbb_BaudRate.Size = new System.Drawing.Size(129, 24);
            this.cbb_BaudRate.TabIndex = 16;
            this.cbb_BaudRate.Text = "115200";
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(16, 141);
            this.lbParity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(44, 17);
            this.lbParity.TabIndex = 13;
            this.lbParity.Text = "Parity";
            // 
            // lbStopBit
            // 
            this.lbStopBit.AutoSize = true;
            this.lbStopBit.Location = new System.Drawing.Point(15, 174);
            this.lbStopBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStopBit.Name = "lbStopBit";
            this.lbStopBit.Size = new System.Drawing.Size(57, 17);
            this.lbStopBit.TabIndex = 11;
            this.lbStopBit.Text = "Stop Bit";
            // 
            // lbDataBit
            // 
            this.lbDataBit.AutoSize = true;
            this.lbDataBit.Location = new System.Drawing.Point(15, 108);
            this.lbDataBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataBit.Name = "lbDataBit";
            this.lbDataBit.Size = new System.Drawing.Size(58, 17);
            this.lbDataBit.TabIndex = 12;
            this.lbDataBit.Text = "Data Bit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txb_SendMonitor);
            this.groupBox2.Controls.Add(this.btn_TestData);
            this.groupBox2.Controls.Add(this.btn_ClearReceiver);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txb_Receiver);
            this.groupBox2.Controls.Add(this.btn_Send);
            this.groupBox2.Controls.Add(this.txb_Transmitter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(23, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(949, 364);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port Monitor";
            // 
            // btn_TestData
            // 
            this.btn_TestData.Location = new System.Drawing.Point(18, 178);
            this.btn_TestData.Name = "btn_TestData";
            this.btn_TestData.Size = new System.Drawing.Size(95, 33);
            this.btn_TestData.TabIndex = 6;
            this.btn_TestData.Text = "TEST DATA";
            this.btn_TestData.UseVisualStyleBackColor = true;
            this.btn_TestData.Click += new System.EventHandler(this.btn_TestData_Click);
            // 
            // btn_ClearReceiver
            // 
            this.btn_ClearReceiver.Location = new System.Drawing.Point(345, 306);
            this.btn_ClearReceiver.Name = "btn_ClearReceiver";
            this.btn_ClearReceiver.Size = new System.Drawing.Size(142, 52);
            this.btn_ClearReceiver.TabIndex = 5;
            this.btn_ClearReceiver.Text = "Clear Receiver Monitor";
            this.btn_ClearReceiver.UseVisualStyleBackColor = true;
            this.btn_ClearReceiver.Click += new System.EventHandler(this.btn_ClearReceiver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Receiver";
            // 
            // txb_Receiver
            // 
            this.txb_Receiver.Location = new System.Drawing.Point(493, 52);
            this.txb_Receiver.Multiline = true;
            this.txb_Receiver.Name = "txb_Receiver";
            this.txb_Receiver.ReadOnly = true;
            this.txb_Receiver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_Receiver.Size = new System.Drawing.Size(434, 306);
            this.txb_Receiver.TabIndex = 3;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(18, 125);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(95, 33);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "SEND";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txb_Transmitter
            // 
            this.txb_Transmitter.Location = new System.Drawing.Point(19, 82);
            this.txb_Transmitter.Name = "txb_Transmitter";
            this.txb_Transmitter.Size = new System.Drawing.Size(124, 22);
            this.txb_Transmitter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transmitter:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ClearGraph);
            this.tabPage2.Controls.Add(this.txb_RealtimeStep);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.zGraph);
            this.tabPage2.Controls.Add(this.grb_Pos);
            this.tabPage2.Controls.Add(this.grb_Velo);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Motor Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ClearGraph
            // 
            this.btn_ClearGraph.Location = new System.Drawing.Point(21, 199);
            this.btn_ClearGraph.Name = "btn_ClearGraph";
            this.btn_ClearGraph.Size = new System.Drawing.Size(97, 35);
            this.btn_ClearGraph.TabIndex = 11;
            this.btn_ClearGraph.Text = "Clear Graph";
            this.btn_ClearGraph.UseVisualStyleBackColor = true;
            this.btn_ClearGraph.Click += new System.EventHandler(this.btn_ClearGraph_Click);
            // 
            // txb_RealtimeStep
            // 
            this.txb_RealtimeStep.Location = new System.Drawing.Point(18, 147);
            this.txb_RealtimeStep.Name = "txb_RealtimeStep";
            this.txb_RealtimeStep.Size = new System.Drawing.Size(193, 22);
            this.txb_RealtimeStep.TabIndex = 10;
            this.txb_RealtimeStep.Text = "0.02";
            this.txb_RealtimeStep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_RealtimeStep_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Realtime Step:";
            // 
            // zGraph
            // 
            this.zGraph.Location = new System.Drawing.Point(18, 262);
            this.zGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zGraph.Name = "zGraph";
            this.zGraph.ScrollGrace = 0D;
            this.zGraph.ScrollMaxX = 0D;
            this.zGraph.ScrollMaxY = 0D;
            this.zGraph.ScrollMaxY2 = 0D;
            this.zGraph.ScrollMinX = 0D;
            this.zGraph.ScrollMinY = 0D;
            this.zGraph.ScrollMinY2 = 0D;
            this.zGraph.Size = new System.Drawing.Size(954, 369);
            this.zGraph.TabIndex = 8;
            this.zGraph.UseExtendedPrintDialog = true;
            // 
            // grb_Pos
            // 
            this.grb_Pos.Controls.Add(this.btn_SetHome);
            this.grb_Pos.Controls.Add(this.btn_SetSpPos);
            this.grb_Pos.Controls.Add(this.txb_Pos);
            this.grb_Pos.Controls.Add(this.label9);
            this.grb_Pos.Controls.Add(this.txb_SpPos);
            this.grb_Pos.Controls.Add(this.label10);
            this.grb_Pos.Enabled = false;
            this.grb_Pos.Location = new System.Drawing.Point(748, 15);
            this.grb_Pos.Name = "grb_Pos";
            this.grb_Pos.Size = new System.Drawing.Size(224, 219);
            this.grb_Pos.TabIndex = 7;
            this.grb_Pos.TabStop = false;
            this.grb_Pos.Text = "Position Control";
            // 
            // btn_SetHome
            // 
            this.btn_SetHome.Location = new System.Drawing.Point(62, 173);
            this.btn_SetHome.Name = "btn_SetHome";
            this.btn_SetHome.Size = new System.Drawing.Size(122, 35);
            this.btn_SetHome.TabIndex = 7;
            this.btn_SetHome.Text = "Home";
            this.btn_SetHome.UseVisualStyleBackColor = true;
            this.btn_SetHome.Click += new System.EventHandler(this.btn_SetHome_Click);
            // 
            // btn_SetSpPos
            // 
            this.btn_SetSpPos.Location = new System.Drawing.Point(9, 120);
            this.btn_SetSpPos.Name = "btn_SetSpPos";
            this.btn_SetSpPos.Size = new System.Drawing.Size(209, 35);
            this.btn_SetSpPos.TabIndex = 4;
            this.btn_SetSpPos.Text = "Set Setpoint";
            this.btn_SetSpPos.UseVisualStyleBackColor = true;
            this.btn_SetSpPos.Click += new System.EventHandler(this.btn_SetSpPos_Click);
            // 
            // txb_Pos
            // 
            this.txb_Pos.Location = new System.Drawing.Point(77, 72);
            this.txb_Pos.Name = "txb_Pos";
            this.txb_Pos.ReadOnly = true;
            this.txb_Pos.Size = new System.Drawing.Size(125, 22);
            this.txb_Pos.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Position:";
            // 
            // txb_SpPos
            // 
            this.txb_SpPos.Location = new System.Drawing.Point(77, 30);
            this.txb_SpPos.Name = "txb_SpPos";
            this.txb_SpPos.Size = new System.Drawing.Size(125, 22);
            this.txb_SpPos.TabIndex = 1;
            this.txb_SpPos.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Setpoint:";
            // 
            // grb_Velo
            // 
            this.grb_Velo.Controls.Add(this.txb_ReFor);
            this.grb_Velo.Controls.Add(this.cbx_Reverse);
            this.grb_Velo.Controls.Add(this.btn_Stop);
            this.grb_Velo.Controls.Add(this.btn_Run);
            this.grb_Velo.Controls.Add(this.btn_SetSpVelo);
            this.grb_Velo.Controls.Add(this.txb_Velo);
            this.grb_Velo.Controls.Add(this.label8);
            this.grb_Velo.Controls.Add(this.txb_SpVelo);
            this.grb_Velo.Controls.Add(this.label7);
            this.grb_Velo.Enabled = false;
            this.grb_Velo.Location = new System.Drawing.Point(453, 15);
            this.grb_Velo.Name = "grb_Velo";
            this.grb_Velo.Size = new System.Drawing.Size(289, 219);
            this.grb_Velo.TabIndex = 3;
            this.grb_Velo.TabStop = false;
            this.grb_Velo.Text = "Velocity Control";
            // 
            // txb_ReFor
            // 
            this.txb_ReFor.Location = new System.Drawing.Point(209, 71);
            this.txb_ReFor.Name = "txb_ReFor";
            this.txb_ReFor.ReadOnly = true;
            this.txb_ReFor.Size = new System.Drawing.Size(74, 22);
            this.txb_ReFor.TabIndex = 8;
            // 
            // cbx_Reverse
            // 
            this.cbx_Reverse.AutoSize = true;
            this.cbx_Reverse.Location = new System.Drawing.Point(9, 105);
            this.cbx_Reverse.Name = "cbx_Reverse";
            this.cbx_Reverse.Size = new System.Drawing.Size(83, 21);
            this.cbx_Reverse.TabIndex = 7;
            this.cbx_Reverse.Text = "Reverse";
            this.cbx_Reverse.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(186, 174);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(97, 35);
            this.btn_Stop.TabIndex = 6;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(9, 174);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(103, 35);
            this.btn_Run.TabIndex = 5;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_SetSpVelo
            // 
            this.btn_SetSpVelo.Location = new System.Drawing.Point(9, 132);
            this.btn_SetSpVelo.Name = "btn_SetSpVelo";
            this.btn_SetSpVelo.Size = new System.Drawing.Size(274, 35);
            this.btn_SetSpVelo.TabIndex = 4;
            this.btn_SetSpVelo.Text = "Set Setpoint";
            this.btn_SetSpVelo.UseVisualStyleBackColor = true;
            this.btn_SetSpVelo.Click += new System.EventHandler(this.btn_SetSpVelo_Click);
            // 
            // txb_Velo
            // 
            this.txb_Velo.Location = new System.Drawing.Point(77, 72);
            this.txb_Velo.Name = "txb_Velo";
            this.txb_Velo.ReadOnly = true;
            this.txb_Velo.Size = new System.Drawing.Size(125, 22);
            this.txb_Velo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Velocity:";
            // 
            // txb_SpVelo
            // 
            this.txb_SpVelo.Location = new System.Drawing.Point(77, 30);
            this.txb_SpVelo.Name = "txb_SpVelo";
            this.txb_SpVelo.Size = new System.Drawing.Size(206, 22);
            this.txb_SpVelo.TabIndex = 1;
            this.txb_SpVelo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Setpoint:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txb_Kd);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txb_Ki);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txb_Kp);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(247, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 215);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PID Parameter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Using Enter key to set";
            // 
            // txb_Kd
            // 
            this.txb_Kd.Location = new System.Drawing.Point(61, 169);
            this.txb_Kd.Name = "txb_Kd";
            this.txb_Kd.Size = new System.Drawing.Size(123, 22);
            this.txb_Kd.TabIndex = 5;
            this.txb_Kd.Text = "0";
            this.txb_Kd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Kd_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kd";
            // 
            // txb_Ki
            // 
            this.txb_Ki.Location = new System.Drawing.Point(61, 116);
            this.txb_Ki.Name = "txb_Ki";
            this.txb_Ki.Size = new System.Drawing.Size(123, 22);
            this.txb_Ki.TabIndex = 3;
            this.txb_Ki.Text = "0";
            this.txb_Ki.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Ki_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ki";
            // 
            // txb_Kp
            // 
            this.txb_Kp.Location = new System.Drawing.Point(61, 69);
            this.txb_Kp.Name = "txb_Kp";
            this.txb_Kp.Size = new System.Drawing.Size(123, 22);
            this.txb_Kp.TabIndex = 1;
            this.txb_Kp.Text = "0";
            this.txb_Kp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Kp_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdb_Pos);
            this.groupBox3.Controls.Add(this.rdb_Velo);
            this.groupBox3.Location = new System.Drawing.Point(18, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 94);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type Control";
            // 
            // rdb_Pos
            // 
            this.rdb_Pos.AutoSize = true;
            this.rdb_Pos.Location = new System.Drawing.Point(34, 57);
            this.rdb_Pos.Name = "rdb_Pos";
            this.rdb_Pos.Size = new System.Drawing.Size(140, 21);
            this.rdb_Pos.TabIndex = 1;
            this.rdb_Pos.TabStop = true;
            this.rdb_Pos.Text = "Position (Degree)";
            this.rdb_Pos.UseVisualStyleBackColor = true;
            this.rdb_Pos.CheckedChanged += new System.EventHandler(this.rdb_Pos_CheckedChanged);
            // 
            // rdb_Velo
            // 
            this.rdb_Velo.AutoSize = true;
            this.rdb_Velo.Location = new System.Drawing.Point(34, 30);
            this.rdb_Velo.Name = "rdb_Velo";
            this.rdb_Velo.Size = new System.Drawing.Size(122, 21);
            this.rdb_Velo.TabIndex = 0;
            this.rdb_Velo.TabStop = true;
            this.rdb_Velo.Text = "Velocity (RPM)";
            this.rdb_Velo.UseVisualStyleBackColor = true;
            this.rdb_Velo.CheckedChanged += new System.EventHandler(this.rdb_Velo_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sPort
            // 
            this.sPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sPort_DataReceived);
            // 
            // timer1s
            // 
            this.timer1s.Interval = 1000;
            this.timer1s.Tick += new System.EventHandler(this.timer1s_Tick);
            // 
            // timer10ms
            // 
            this.timer10ms.Interval = 10;
            this.timer10ms.Tick += new System.EventHandler(this.timer10ms_Tick);
            // 
            // timersub
            // 
            this.timersub.Interval = 1200;
            this.timersub.Tick += new System.EventHandler(this.timersub_Tick);
            // 
            // txb_SendMonitor
            // 
            this.txb_SendMonitor.Location = new System.Drawing.Point(164, 52);
            this.txb_SendMonitor.Multiline = true;
            this.txb_SendMonitor.Name = "txb_SendMonitor";
            this.txb_SendMonitor.ReadOnly = true;
            this.txb_SendMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_SendMonitor.Size = new System.Drawing.Size(313, 248);
            this.txb_SendMonitor.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Send Monitor";
            // 
            // EncoderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 696);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EncoderControl";
            this.Text = "Encoder Control";
            this.Load += new System.EventHandler(this.EncoderControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grb_Pos.ResumeLayout(false);
            this.grb_Pos.PerformLayout();
            this.grb_Velo.ResumeLayout(false);
            this.grb_Velo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_StopBit;
        private System.Windows.Forms.ComboBox cbb_PortName;
        private System.Windows.Forms.ComboBox cbb_Parity;
        private System.Windows.Forms.Label lbPortName;
        private System.Windows.Forms.ComboBox cbb_DataBit;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.ComboBox cbb_BaudRate;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.Label lbStopBit;
        private System.Windows.Forms.Label lbDataBit;
        private System.Windows.Forms.TextBox txb_Transmitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ClearReceiver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Receiver;
        private System.Windows.Forms.Button btn_Send;
        private System.IO.Ports.SerialPort sPort;
        private System.Windows.Forms.Button btn_GetPortName;
        private System.Windows.Forms.Button btn_TestData;
        private System.Windows.Forms.Timer timer1s;
        private System.Windows.Forms.Timer timer10ms;
        private System.Windows.Forms.Timer timersub;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb_Pos;
        private System.Windows.Forms.RadioButton rdb_Velo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txb_Kp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Kd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Ki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grb_Velo;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_SetSpVelo;
        private System.Windows.Forms.TextBox txb_Velo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_SpVelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grb_Pos;
        private System.Windows.Forms.Button btn_SetSpPos;
        private System.Windows.Forms.TextBox txb_Pos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_SpPos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_SetHome;
        private System.Windows.Forms.Label label11;
        private ZedGraph.ZedGraphControl zGraph;
        private System.Windows.Forms.TextBox txb_RealtimeStep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_ClearGraph;
        private System.Windows.Forms.CheckBox cbx_Reverse;
        private System.Windows.Forms.TextBox txb_ReFor;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_SendMonitor;
    }
}

