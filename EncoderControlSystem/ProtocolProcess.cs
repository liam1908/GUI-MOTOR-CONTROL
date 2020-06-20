using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ZedGraph;

namespace EncoderControlSystem
{
    static public class ProtocolProcess
    {
        /*Protocol Frame
         * 
         * STX  - CODE FNC - DATA -  ETX
         * 1Byte    1byte    4byte   1Byte = 7Byte
         *
         */

        /* Định nghĩa các ký hiệu frame truyền */
        public enum frameCode
        {
            
            VeloFor = 0x02, VeloRev = 0x03, SetpointPos = 0x04, Pos = 0x05,
            Kp = 0x06, Ki = 0x07, Kd = 0x08, Run = 0x09, Stop = 0x10,
            ACK = 0x11, Home =0x12, Direc = 0x13,
            Datasend = 252
        };
        public enum frameProcedure
        {
            STX = 0xFA, ETX = 0xFB
        };

        /*Hàm chuyển kiểu dữu liệu string nhập từ GUI sang byte (4 byte)*/

        static public byte[] stringToByte (string s)
        {
            byte[] temp = new byte[4];
            float floatvalue = float.Parse(s);
            temp = BitConverter.GetBytes(floatvalue);
            return temp;
            /* Hàm Getbytes chuyển float thành Byte
             * temp[0] LSB
             * 
             * 
             * 
             * temp[3] MSB
             */
        }

        /*Hàm xuất frame đúng như định dạng */
        /*Hàm xử lý frame truyền đi*/

        static public byte[] encodeFrame (frameCode codeFunction, string s)
        {
            byte[] temp = new byte[7];
            temp[0] = (byte)frameProcedure.STX;
            temp[6] = (byte)frameProcedure.ETX;
            switch (codeFunction)
            {
                case frameCode.Datasend:
                    temp[1] = (byte)frameCode.Datasend;
                    break;
                case frameCode.Run:
                    temp[1] = (byte)frameCode.Run;
                    break;
                case frameCode.Stop:
                    temp[1] = (byte)frameCode.Stop;
                    break;
                case frameCode.VeloFor:
                    temp[1] = (byte)frameCode.VeloFor;
                    break;
                case frameCode.SetpointPos:
                    temp[1] = (byte)frameCode.SetpointPos;
                    break;
                case frameCode.VeloRev:
                    temp[1] = (byte)frameCode.VeloRev;
                    break;
                case frameCode.Pos:
                    temp[1] = (byte)frameCode.Pos;
                    break;
                case frameCode.Kp:
                    temp[1] = (byte)frameCode.Kp;
                    break;
                case frameCode.Ki:
                    temp[1] = (byte)frameCode.Ki;
                    break;
                case frameCode.Kd:
                    temp[1] = (byte)frameCode.Kd;
                    break;
                default:
                    break;
            }

            byte[] byteTemp = new byte[4];
            byteTemp = stringToByte(s);
            temp[2] = byteTemp[3];          //Truyền MSB của float trc
            temp[3] = byteTemp[2];
            temp[4] = byteTemp[1];
            temp[5] = byteTemp[0];
            return temp;
        }

        /*Hàm xử lý nhận frame về*/
        static public frameCode decodeFrame (byte[] receiveData, out byte[] outData)
        {
            outData = new byte[20];

            //Lưu phần Data về
            outData[0] = receiveData[5]; 
            outData[1] = receiveData[4];
            outData[2] = receiveData[3];
            outData[3] = receiveData[2];        //Nhận MSB trc từ STM
            return (frameCode)receiveData[1];
        }

        static public float byteToFloat (byte[] inData)
        {
            float temp = 0;
            temp = BitConverter.ToSingle(inData, 0);
            return temp;
        }

    
    }
}
