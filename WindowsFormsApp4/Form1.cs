using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalApp
{
    public partial class Form1 : Form
    {
        #region Variable Global
        long nCountTx = 0, nCountRx = 0;
        bool isConnect = false;


        // Define the cancellation token source & token as global objects 
        //https://www.codeproject.com/Questions/1243163/Csharp-how-to-cancle-task-run-by-click-on-another
        CancellationTokenSource cancelTask; //1. cancelTask
        #endregion

        #region FORM (Init + Load + Exit)
        public Form1()
        {
            InitializeComponent();
            
            // check Transfer interrupts
            chbTf1.Click += (o, e) => txtMS1.Enabled = chbTf1.Checked;
            chbTf2.Click += (o, e) => txtMS2.Enabled = chbTf2.Checked;
            chbTf3.Click += (o, e) => txtMS3.Enabled = chbTf3.Checked;
            chbTf4.Click += (o, e) => txtMS4.Enabled = chbTf4.Checked;
            chbTf5.Click += (o, e) => txtMS5.Enabled = chbTf5.Checked;
            //CheckBox Hexa
            chbHex1.Click += (o, e) => CheckHexaPreSend_Click(txtSend1, ref chbHex1);
            chbHex2.Click += (o, e) => CheckHexaPreSend_Click(txtSend2, ref chbHex2);
            chbHex3.Click += (o, e) => CheckHexaPreSend_Click(txtSend3, ref chbHex3);
            chbHex4.Click += (o, e) => CheckHexaPreSend_Click(txtSend4, ref chbHex4);
            chbHex5.Click += (o, e) => CheckHexaPreSend_Click(txtSend5, ref chbHex5);
            //Send
            btSend1.Click += (o, e) => SendDataBuffer(txtSend1.Text, chbHex1, chbCR1, chbLF1, cbCrc1);
            btSend2.Click += (o, e) => SendDataBuffer(txtSend2.Text, chbHex2, chbCR2, chbLF2, cbCrc2);
            btSend3.Click += (o, e) => SendDataBuffer(txtSend3.Text, chbHex3, chbCR3, chbLF3, cbCrc3);
            btSend4.Click += (o, e) => SendDataBuffer(txtSend4.Text, chbHex4, chbCR4, chbLF4, cbCrc4);
            btSend5.Click += (o, e) => SendDataBuffer(txtSend5.Text, chbHex5, chbCR5, chbLF5, cbCrc5);
            //
            btnConnect.Click += BtConnect_Click;
            serialPort1.DataReceived += SerialPort1_DataReceived;
            //
            btnClear.Click += (o, e) =>
            {
                txtReceive.Text = ""; //clear
                nCountRx = nCountTx = 0;
                toolStripTx.Text = "Tx: 0";
                toolStripRx.Text = "Rx: 0";
                txtLength.Text = "0";
                txtTimeSample.Text = "0";
            };
            btnReScan.Click += (o, e) =>
            {
                string[] ports = SerialPort.GetPortNames();
                cbCOM.Items.Clear();
                cbCOM.Items.AddRange(ports);
            };         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //0. Lấy toàn bộ cổng COM hiện có trên PC
            try
            {
                string[] ports = SerialPort.GetPortNames();
                cbCOM.Items.Clear();
                cbCOM.Items.AddRange(ports);
                cbCOM.SelectedIndex = 0;
            }
            catch { }
            //1. Chọn cái đầu tiên load lên đầu
            cbBaud.SelectedIndex = 4;        //115200
            cbDataBit.SelectedIndex = 0;    //8bit
            cbStopBit.SelectedIndex = 0;    //One
            cbHandShake.SelectedIndex = 0;
            cbParity.SelectedIndex = 0;
            radioASCII.Checked = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
        #endregion

        #region SerialPort Connect | Disconnect | Receive
        Stopwatch timer = new Stopwatch();

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            byte[] bufferReceiver = new byte[serialPort1.BytesToRead];
            serialPort1.Read(bufferReceiver, 0, serialPort1.BytesToRead);

            timer.Stop(); // Stopwatch
            nCountRx++;
            string strTemp = null;

            //Kiểm tra kiểu hiển thị được lựa chọn
            if (radioASCII.Checked)
            {
                strTemp = Encoding.UTF8.GetString(bufferReceiver, 0, bufferReceiver.Length);
            }
            if (radioHEX.Checked)
            {
                strTemp = "";
                for (int i = 0; i < bufferReceiver.Length; i++)
                {
                    string tmp = bufferReceiver[i].ToString("X2") + " ";
                    strTemp += tmp;
                }
            }
            if (radioDEC.Checked)
            {
                //chuyển đổi từ byte array sang string
                strTemp = "";
                for (int i = 0; i < bufferReceiver.Length; i++)
                {
                    string tmp = bufferReceiver[i].ToString() + " ";
                    strTemp += tmp;
                }
            }
            Invoke((MethodInvoker)delegate
            {
                txtReceive.AppendText(strTemp);// dataSerial);
            });

            //Update Count Rx
            Invoke((MethodInvoker)delegate
            {
                toolStripRx.Text = "Rx: " + nCountRx.ToString();
                txtLength.Text = bufferReceiver.Length.ToString();
                txtTimeSample.Text = timer.Elapsed.TotalMilliseconds.ToString("#,##0.0");
            });
            //          
            Debug.WriteLine("Time Taken: " + timer.Elapsed.TotalMilliseconds.ToString("#,##0.00 'milliseconds'"));
            timer.Restart();
            //
        }
        private void BtConnect_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (btnConnect.Text == "Connect")
            {
                if (cbCOM.Text == "")
                {
                    MessageBox.Show("Chưa chọn cổng COM", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!serialPort1.IsOpen)
                {
                    //Add thông tin COMPort và Baudrate trước khi connect
                    serialPort1.PortName = cbCOM.Text;
                    serialPort1.BaudRate = int.Parse(cbBaud.Text);
                    serialPort1.DataBits = int.Parse(cbDataBit.Text);
                    //
                    switch (cbStopBit.Text)
                    {
                        case "1":   serialPort1.StopBits = StopBits.One; break;
                        case "2":   serialPort1.StopBits = StopBits.Two; break;
                    }
                    switch (cbParity.Text)
                    {
                        case "None":    serialPort1.Parity = Parity.None; break;
                        case "Odd":     serialPort1.Parity = Parity.Odd; break;
                        case "Even":    serialPort1.Parity = Parity.Even; break;
                        case "Mark":    serialPort1.Parity = Parity.Mark; break;
                    }
                    switch (cbHandShake.Text)
                    {
                        case "None": serialPort1.Handshake = Handshake.None; break;
                        case "XOnXOff": serialPort1.Handshake = Handshake.XOnXOff; break;
                        case "RTS/CTS": serialPort1.Handshake = Handshake.RequestToSend; break;
                        case "RTS/CTS+XOnXOff": serialPort1.Handshake = Handshake.RequestToSendXOnXOff; break;
                    }
                    //
                    if (chbDTR.Checked) serialPort1.DtrEnable = true; else serialPort1.DtrEnable = false;
                    if (chbRTS.Checked) serialPort1.RtsEnable = true; else serialPort1.RtsEnable = false;
                    //Connecting ....
                    serialPort1.Open();

                }
                //check again
                if (serialPort1.IsOpen)
                {
                    string str = "Connected " + serialPort1.PortName + " at " + serialPort1.BaudRate.ToString() + " bps"
                                + ", DataBits: " + serialPort1.DataBits.ToString()
                                + ", StopBits: " + serialPort1.StopBits.ToString()
                                + ", Parity: " + serialPort1.Parity.ToString()
                                + ", HandShake: " + serialPort1.Handshake.ToString();
                    //
                    toolStripComStatus.Text = str;
                    isConnect = true;
                    btnConnect.Text = "Disconnect";
                    btnReScan.Enabled = false;
                    groupSend.Enabled = true;
                    //2. Run Task bình thường
                    Task.Run(TaskTxRequest);
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                //
                if (!serialPort1.IsOpen)
                {
                    toolStripComStatus.Text = "COM Disconnected";
                    isConnect = false;
                    btnConnect.Text = "Connect";
                    btnReScan.Enabled = true;
                    groupSend.Enabled = false;
                    //4. Cancel Task();
                    cancelTask.Cancel();
                }
            }
        }
        #endregion

        #region Task async await
        private async Task TaskTxRequest()    //có thể bỏ: async vì chạy Task.Run(). Tuy nhiên phải thêm vào mới cancel được Task()
        {
            //Bên dưới có While(1) nên chỉ cần khai báo Local là được.
            int nCountTimerTx1 = 0, nCountTimerTx2 = 0, nCountTimerTx3 = 0, nCountTimerTx4 = 0, nCountTimerTx5 = 0;
            int nCountTx1Max = 10, nCountTx2Max = 10, nCountTx3Max = 10, nCountTx4Max = 10, nCountTx5Max = 10;  //min = 10;

            cancelTask = new CancellationTokenSource();     //1. Cần phải khởi tạo lại cả 2 (sau khi dừng)
            CancellationToken token = cancelTask.Token;     //2.

            //var sw = new Stopwatch();
            //sw.Start();

            while (true)
            {
                //Note: Thread.Sleep(): Vẫn có thể delay chính xác 1ms
                //Tuy nhiên, code phía sau ko đảm bảo, nên để tối thiểu là 10ms
                //Đồng nghĩa với việc: Thời gian truyền xuống PC tối thiếu là 10ms
                //Đã [TESTED]. Thời gian truyền chính xác với thời gian đặt. Min = 10ms

                //await Task.Delay(1); //[TESED] - Delay ko chính xác
                Thread.Sleep(10);      //[TESTED] - Delay chính xác
                //check to see if operation is cancelled and throw exception if it is
                token.ThrowIfCancellationRequested();   //3.cho phép có thể Cancel Task()
                                                        //Lệnh: Cancel bên ngoài: cts.Cancel();
                //Code Here .
                //Thực hiện truyền từ txSend1 đến TxSend5 nếu Tfx được Enable             

                if ((txtSend1.Text != "") && (chbTf1.Checked))
                {
                    if (!int.TryParse(txtMS1.Text, out nCountTx1Max)) nCountTx1Max = 10;    //[PASSED]
                    if (++nCountTimerTx1 >= nCountTx1Max / 10)//nCountTx1Max)
                    {   
                        nCountTimerTx1 = 0; //reset
                        //await 
                        //Note: Truyền OK, ko cần Invoke
                        //Thêm: ban đầu thêm await vào truyền ko được, Lý do: bên trong có exp của crc.text -> dùng Invoke()
                        SendDataBuffer(txtSend1.Text, chbHex1, chbCR1, chbLF1, cbCrc1);
                        //Task.Run(SendDataBuffer(txtSend1.Text, chbHex1, chbCR1, chbLF1, cbCrc1));
                        //Console.WriteLine("async: Running for {0} seconds", sw.Elapsed.TotalSeconds);
                        //sw = new Stopwatch();
                        //sw.Start();

                    }
                    //For test - debug
                    //Invoke((MethodInvoker)delegate {
                    //    label14.Text = nCountTimerTx1.ToString();
                    //});
                }
                //
                if ((txtSend2.Text != "") && (chbTf2.Checked))
                {
                    if (!int.TryParse(txtMS2.Text, out nCountTx2Max)) nCountTx2Max = 10;
                    if (++nCountTimerTx2 >= nCountTx2Max / 10)
                    {
                        nCountTimerTx2 = 0;
                        SendDataBuffer(txtSend2.Text, chbHex2, chbCR2, chbLF2, cbCrc2);
                    }
                }
                //
                if ((txtSend3.Text != "") && (chbTf3.Checked))
                {
                    if (!int.TryParse(txtMS3.Text, out nCountTx3Max)) nCountTx3Max = 10;
                    if (++nCountTimerTx3 >= nCountTx3Max / 10)
                    {
                        nCountTimerTx3 = 0;
                        SendDataBuffer(txtSend3.Text, chbHex3, chbCR3, chbLF3, cbCrc3);
                    }
                }
                //
                if ((txtSend4.Text != "") && (chbTf4.Checked))
                {
                    if (!int.TryParse(txtMS4.Text, out nCountTx4Max)) nCountTx4Max = 10;
                    if (++nCountTimerTx4 >= nCountTx4Max / 10)
                    {
                        nCountTimerTx4 = 0;
                        SendDataBuffer(txtSend4.Text, chbHex4, chbCR4, chbLF4, cbCrc4);
                    }
                }
                ////
                if ((txtSend5.Text != "") && (chbTf5.Checked))
                {
                    if (!int.TryParse(txtMS5.Text, out nCountTx5Max)) nCountTx5Max = 10;
                    if (++nCountTimerTx5 >= nCountTx5Max / 10)
                    {
                        nCountTimerTx5 = 0;
                        SendDataBuffer(txtSend5.Text, chbHex5, chbCR5, chbLF5, cbCrc5);
                    }
                }
                //
            }
        }
        #endregion

        #region SerialPort SendData
        private void CheckHexaPreSend_Click(TextBox txtString, ref CheckBox chbHex)
        {
            if (!CheckStringHexa(txtString.Text))
            {
                chbHex.Checked = false;
                MessageBox.Show("Thừa hoặc thiếu byte ! \nHoặc sai format Hexa ! \nKiểm tra và check lại Hexa", "Lỗi Format Hexa",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckStringHexa(string dataString)
        {
            string data = dataString.Replace(" ", "");  //Xóa hết khoảng trống
            //0. Kiểm tra xem length data đã đúng chưa ? (chẵn là OK) = OK
            if (data.Length % 2 != 0) return false;
            //1. Kiểm tra các kí tự nằm trong: 0-9; A-F; a-f    = OK
            for (int i = 0; i < data.Length; i++)
            {
                if (!(((data[i] >= '0') && (data[i] <= '9')) || ((data[i] >= 'A') && (data[i] <= 'F')) || ((data[i] >= 'a') && (data[i] <= 'f'))))
                {
                    return false;
                }
            }
            //2. 
            return true;
        }
        public byte[] ToByteArray(String HexString)
        {
            int NumberChars = HexString.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
            }
            return bytes;
        }

        private void SendDataBuffer(string stringData, CheckBox chbHexa, CheckBox chbCR, CheckBox chbLF, ComboBox cbCRC) 
        {
            //2. Gửi dữ liệu đi (kiểu ASCII hoặc Hexa)
            if (chbHexa.Checked)
            {
                string strData = stringData.Replace(" ", "");   //Bỏ hết các kí tự space
                if (!CheckStringHexa(strData))
                {
                    //Thông báo sai Format và dừng truyền ngắt !
                    //test
                    if (chbHexa.Name == "chbHex1")
                        Invoke((MethodInvoker)delegate
                        {
                            chbTf1.Checked = false;
                        });
                    MessageBox.Show("Thừa hoặc thiếu byte ! \nHoặc sai format Hexa ! \nTạm dừng truyền ngắt.", "Lỗi Format Hexa",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //OK bắt đầu truyền.
                byte[] dataSend = ToByteArray(strData);

                byte[] subData = SendSubDataAfterString(dataSend, chbCR, chbLF, cbCRC);

                int newLength = subData.Length;
                if (subData.Length > 0)
                {
                    Array.Resize(ref dataSend, dataSend.Length + subData.Length);
                    for (int i = 0; i < subData.Length; i++) dataSend[dataSend.Length - newLength--] = subData[i];  //[PASSED]
                }
                serialPort1.Write(dataSend, 0, dataSend.Length);
            }
            else // Truyền bình thường, ko có Hexa
            {
                byte[] dataSend = Encoding.ASCII.GetBytes(stringData);
                byte[] subData = SendSubDataAfterString(dataSend, chbCR, chbLF, cbCRC);

                int newLength = subData.Length;
                if (subData.Length > 0)
                {
                    Array.Resize(ref dataSend, dataSend.Length + subData.Length);
                    for (int i = 0; i < subData.Length; i++) dataSend[dataSend.Length - newLength--] = subData[i];  //[PASSED]
                }
                serialPort1.Write(dataSend, 0, dataSend.Length);
            }
            //3. Update Tx toolStatus
            nCountTx++;
            Invoke((MethodInvoker)delegate {
                toolStripTx.Text = "Tx: " + nCountTx.ToString();
            });          
        }
        byte [] SendSubDataAfterString(byte[] dataSend, CheckBox chbCR, CheckBox chbLF, ComboBox cbCRC)
        {
            string strCRC = null;
            byte[] error = new byte[0]; //
            byte[] after = new byte[4];
            int indexSublength = 0;

            //1. Tiền xử lý dữ liệu: +CR, +LF, +CRC 
            Invoke((MethodInvoker)delegate {
                if (chbCR.Checked) { after[indexSublength++] = 0x0D; }
            });
            Invoke((MethodInvoker)delegate {
                if (chbLF.Checked) { after[indexSublength++] = 0x0A; }
            });
            Invoke((MethodInvoker)delegate {
                strCRC = cbCRC.Text;
            });
            //
            if (strCRC != "NONE")
            {   //TBD
                //if (cbCRC.Text == "") after[2] = 0xFC;
                if (strCRC == "MODBUS")
                {
                    byte [] crc16 = CalculateCRC(dataSend); // Calculate CRC.

                    after[indexSublength++] = crc16[0];       // Error Check Low
                    after[indexSublength++] = crc16[1];       // Error Check High
                }
                if (strCRC == "SUM8")
                {
                    byte ChSum8 = (byte)(CalculateCheckSum(dataSend)&0xFF);
                    after[indexSublength++] = ChSum8;
                }
                if (strCRC == "SUM16")
                {
                    ushort ChSum16 = CalculateCheckSum(dataSend);
                    after[indexSublength++] = (byte)(ChSum16 >> 8);
                    after[indexSublength++] = (byte)(ChSum16 & 0xFF);
                }
            }
            if (indexSublength > 0)
            {
                //serialPort1.Write(after, 0, indexSublength);
                byte[] arr = new byte[indexSublength];
                Array.Copy(after, arr, indexSublength);
                return arr;
            }

            return error;
        }
        #endregion

        #region CheckSUM + Check CRC
        private byte[] CalculateCRC(byte[] data)
        {
            ushort CRCFull = 0xFFFF; // Set the 16-bit register (CRC register) = FFFFH.
            byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;
            byte[] CRC = new byte[2];
            //for (int i = 0; i < (data.Length) - 2; i++)
            for (int i = 0; i < (data.Length); i++)         //[PASSED]
            {
                CRCFull = (ushort)(CRCFull ^ data[i]); // 

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
            return CRC;
        }
        private ushort CalculateCheckSum(byte[] dataToCalculate)
        {
            int checksum = 0;
            ushort result;
            foreach (byte chData in dataToCalculate)
            {
                checksum += chData;
            }
            //result = (byte)(checksum &= 0xff);    //checksum8
            result = (ushort)(checksum &= 0xFFFF); //CheckSUM16
            return result;
        }
        #endregion
    }
}
