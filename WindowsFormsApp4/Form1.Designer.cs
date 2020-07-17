namespace TerminalApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtSend1 = new System.Windows.Forms.TextBox();
            this.cbCOM = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnReScan = new System.Windows.Forms.Button();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbDTR = new System.Windows.Forms.CheckBox();
            this.chbRTS = new System.Windows.Forms.CheckBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHandShake = new System.Windows.Forms.ComboBox();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.cbDataBit = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupSend = new System.Windows.Forms.GroupBox();
            this.txtSendView = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbCrc5 = new System.Windows.Forms.ComboBox();
            this.txtMS5 = new System.Windows.Forms.TextBox();
            this.cbCrc4 = new System.Windows.Forms.ComboBox();
            this.txtMS4 = new System.Windows.Forms.TextBox();
            this.cbCrc3 = new System.Windows.Forms.ComboBox();
            this.txtMS3 = new System.Windows.Forms.TextBox();
            this.cbCrc2 = new System.Windows.Forms.ComboBox();
            this.txtMS2 = new System.Windows.Forms.TextBox();
            this.cbCrc1 = new System.Windows.Forms.ComboBox();
            this.txtMS1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chbTf5 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chbTf4 = new System.Windows.Forms.CheckBox();
            this.chbHex5 = new System.Windows.Forms.CheckBox();
            this.chbTf3 = new System.Windows.Forms.CheckBox();
            this.chbLF5 = new System.Windows.Forms.CheckBox();
            this.chbHex4 = new System.Windows.Forms.CheckBox();
            this.chbLF4 = new System.Windows.Forms.CheckBox();
            this.chbTf2 = new System.Windows.Forms.CheckBox();
            this.chbLF3 = new System.Windows.Forms.CheckBox();
            this.chbHex3 = new System.Windows.Forms.CheckBox();
            this.chbCR5 = new System.Windows.Forms.CheckBox();
            this.chbLF2 = new System.Windows.Forms.CheckBox();
            this.chbCR4 = new System.Windows.Forms.CheckBox();
            this.chbTf1 = new System.Windows.Forms.CheckBox();
            this.chbCR3 = new System.Windows.Forms.CheckBox();
            this.chbLF1 = new System.Windows.Forms.CheckBox();
            this.chbCR2 = new System.Windows.Forms.CheckBox();
            this.chbHex2 = new System.Windows.Forms.CheckBox();
            this.chbCR1 = new System.Windows.Forms.CheckBox();
            this.chbHex1 = new System.Windows.Forms.CheckBox();
            this.btSend5 = new System.Windows.Forms.Button();
            this.btSend4 = new System.Windows.Forms.Button();
            this.btSend3 = new System.Windows.Forms.Button();
            this.btSend2 = new System.Windows.Forms.Button();
            this.btSend1 = new System.Windows.Forms.Button();
            this.txtSend5 = new System.Windows.Forms.TextBox();
            this.txtSend4 = new System.Windows.Forms.TextBox();
            this.txtSend3 = new System.Windows.Forms.TextBox();
            this.txtSend2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtTimeSample = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.radioDEC = new System.Windows.Forms.RadioButton();
            this.radioHEX = new System.Windows.Forms.RadioButton();
            this.radioASCII = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripComStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripTx = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripRx = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupSend.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReceive
            // 
            this.txtReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(10)), true);
            this.txtReceive.Location = new System.Drawing.Point(3, 16);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(643, 361);
            this.txtReceive.TabIndex = 0;
            // 
            // txtSend1
            // 
            this.txtSend1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend1.Location = new System.Drawing.Point(6, 58);
            this.txtSend1.Name = "txtSend1";
            this.txtSend1.Size = new System.Drawing.Size(520, 26);
            this.txtSend1.TabIndex = 0;
            // 
            // cbCOM
            // 
            this.cbCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM18"});
            this.cbCOM.Location = new System.Drawing.Point(81, 19);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(97, 24);
            this.cbCOM.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(95, 234);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 32);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnReScan
            // 
            this.btnReScan.Location = new System.Drawing.Point(14, 235);
            this.btnReScan.Name = "btnReScan";
            this.btnReScan.Size = new System.Drawing.Size(76, 32);
            this.btnReScan.TabIndex = 2;
            this.btnReScan.Text = "ReScan";
            this.btnReScan.UseVisualStyleBackColor = true;
            // 
            // cbBaud
            // 
            this.cbBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cbBaud.Location = new System.Drawing.Point(81, 49);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(97, 24);
            this.cbBaud.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbDTR);
            this.groupBox1.Controls.Add(this.chbRTS);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnReScan);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbHandShake);
            this.groupBox1.Controls.Add(this.cbStopBit);
            this.groupBox1.Controls.Add(this.cbDataBit);
            this.groupBox1.Controls.Add(this.cbBaud);
            this.groupBox1.Controls.Add(this.cbCOM);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComPort Settings";
            // 
            // chbDTR
            // 
            this.chbDTR.AutoSize = true;
            this.chbDTR.Location = new System.Drawing.Point(82, 206);
            this.chbDTR.Name = "chbDTR";
            this.chbDTR.Size = new System.Drawing.Size(49, 17);
            this.chbDTR.TabIndex = 4;
            this.chbDTR.Text = "DTR";
            this.chbDTR.UseVisualStyleBackColor = true;
            // 
            // chbRTS
            // 
            this.chbRTS.AutoSize = true;
            this.chbRTS.Location = new System.Drawing.Point(135, 206);
            this.chbRTS.Name = "chbRTS";
            this.chbRTS.Size = new System.Drawing.Size(48, 17);
            this.chbRTS.TabIndex = 4;
            this.chbRTS.Text = "RTS";
            this.chbRTS.UseVisualStyleBackColor = true;
            // 
            // cbParity
            // 
            this.cbParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark"});
            this.cbParity.Location = new System.Drawing.Point(81, 109);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(97, 24);
            this.cbParity.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Enable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "HandShake";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "StopBits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DataBits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM Port";
            // 
            // cbHandShake
            // 
            this.cbHandShake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHandShake.FormattingEnabled = true;
            this.cbHandShake.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RTS/CTS",
            "RTS/CTS+XOnXOff"});
            this.cbHandShake.Location = new System.Drawing.Point(81, 169);
            this.cbHandShake.Name = "cbHandShake";
            this.cbHandShake.Size = new System.Drawing.Size(97, 24);
            this.cbHandShake.TabIndex = 1;
            // 
            // cbStopBit
            // 
            this.cbStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbStopBit.Location = new System.Drawing.Point(81, 139);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(97, 24);
            this.cbStopBit.TabIndex = 1;
            // 
            // cbDataBit
            // 
            this.cbDataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataBit.FormattingEnabled = true;
            this.cbDataBit.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cbDataBit.Location = new System.Drawing.Point(81, 79);
            this.cbDataBit.Name = "cbDataBit";
            this.cbDataBit.Size = new System.Drawing.Size(97, 24);
            this.cbDataBit.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReceive);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 380);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reveive";
            // 
            // groupSend
            // 
            this.groupSend.Controls.Add(this.txtSendView);
            this.groupSend.Controls.Add(this.label13);
            this.groupSend.Controls.Add(this.cbCrc5);
            this.groupSend.Controls.Add(this.txtMS5);
            this.groupSend.Controls.Add(this.cbCrc4);
            this.groupSend.Controls.Add(this.txtMS4);
            this.groupSend.Controls.Add(this.cbCrc3);
            this.groupSend.Controls.Add(this.txtMS3);
            this.groupSend.Controls.Add(this.cbCrc2);
            this.groupSend.Controls.Add(this.txtMS2);
            this.groupSend.Controls.Add(this.cbCrc1);
            this.groupSend.Controls.Add(this.txtMS1);
            this.groupSend.Controls.Add(this.label11);
            this.groupSend.Controls.Add(this.label12);
            this.groupSend.Controls.Add(this.label10);
            this.groupSend.Controls.Add(this.label9);
            this.groupSend.Controls.Add(this.chbTf5);
            this.groupSend.Controls.Add(this.label8);
            this.groupSend.Controls.Add(this.chbTf4);
            this.groupSend.Controls.Add(this.chbHex5);
            this.groupSend.Controls.Add(this.chbTf3);
            this.groupSend.Controls.Add(this.chbLF5);
            this.groupSend.Controls.Add(this.chbHex4);
            this.groupSend.Controls.Add(this.chbLF4);
            this.groupSend.Controls.Add(this.chbTf2);
            this.groupSend.Controls.Add(this.chbLF3);
            this.groupSend.Controls.Add(this.chbHex3);
            this.groupSend.Controls.Add(this.chbCR5);
            this.groupSend.Controls.Add(this.chbLF2);
            this.groupSend.Controls.Add(this.chbCR4);
            this.groupSend.Controls.Add(this.chbTf1);
            this.groupSend.Controls.Add(this.chbCR3);
            this.groupSend.Controls.Add(this.chbLF1);
            this.groupSend.Controls.Add(this.chbCR2);
            this.groupSend.Controls.Add(this.chbHex2);
            this.groupSend.Controls.Add(this.chbCR1);
            this.groupSend.Controls.Add(this.chbHex1);
            this.groupSend.Controls.Add(this.btSend5);
            this.groupSend.Controls.Add(this.btSend4);
            this.groupSend.Controls.Add(this.btSend3);
            this.groupSend.Controls.Add(this.btSend2);
            this.groupSend.Controls.Add(this.btSend1);
            this.groupSend.Controls.Add(this.txtSend5);
            this.groupSend.Controls.Add(this.txtSend4);
            this.groupSend.Controls.Add(this.txtSend3);
            this.groupSend.Controls.Add(this.txtSend2);
            this.groupSend.Controls.Add(this.txtSend1);
            this.groupSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSend.Location = new System.Drawing.Point(0, 0);
            this.groupSend.Name = "groupSend";
            this.groupSend.Size = new System.Drawing.Size(846, 186);
            this.groupSend.TabIndex = 5;
            this.groupSend.TabStop = false;
            this.groupSend.Text = "Send";
            // 
            // txtSendView
            // 
            this.txtSendView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendView.Location = new System.Drawing.Point(6, 17);
            this.txtSendView.Name = "txtSendView";
            this.txtSendView.ReadOnly = true;
            this.txtSendView.Size = new System.Drawing.Size(835, 26);
            this.txtSendView.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(805, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "(ms)";
            // 
            // cbCrc5
            // 
            this.cbCrc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrc5.FormattingEnabled = true;
            this.cbCrc5.Items.AddRange(new object[] {
            "NONE",
            "MODBUS",
            "SUM8",
            "SUM16"});
            this.cbCrc5.Location = new System.Drawing.Point(700, 197);
            this.cbCrc5.Name = "cbCrc5";
            this.cbCrc5.Size = new System.Drawing.Size(71, 21);
            this.cbCrc5.TabIndex = 5;
            this.cbCrc5.Text = "NONE";
            // 
            // txtMS5
            // 
            this.txtMS5.Enabled = false;
            this.txtMS5.Location = new System.Drawing.Point(797, 196);
            this.txtMS5.Name = "txtMS5";
            this.txtMS5.Size = new System.Drawing.Size(44, 23);
            this.txtMS5.TabIndex = 4;
            this.txtMS5.Text = "1000";
            // 
            // cbCrc4
            // 
            this.cbCrc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrc4.FormattingEnabled = true;
            this.cbCrc4.Items.AddRange(new object[] {
            "NONE",
            "MODBUS",
            "SUM8",
            "SUM16"});
            this.cbCrc4.Location = new System.Drawing.Point(700, 160);
            this.cbCrc4.Name = "cbCrc4";
            this.cbCrc4.Size = new System.Drawing.Size(71, 21);
            this.cbCrc4.TabIndex = 5;
            this.cbCrc4.Text = "NONE";
            // 
            // txtMS4
            // 
            this.txtMS4.Enabled = false;
            this.txtMS4.Location = new System.Drawing.Point(797, 159);
            this.txtMS4.Name = "txtMS4";
            this.txtMS4.Size = new System.Drawing.Size(44, 23);
            this.txtMS4.TabIndex = 4;
            this.txtMS4.Text = "1000";
            // 
            // cbCrc3
            // 
            this.cbCrc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrc3.FormattingEnabled = true;
            this.cbCrc3.Items.AddRange(new object[] {
            "NONE",
            "MODBUS",
            "SUM8",
            "SUM16"});
            this.cbCrc3.Location = new System.Drawing.Point(700, 127);
            this.cbCrc3.Name = "cbCrc3";
            this.cbCrc3.Size = new System.Drawing.Size(71, 21);
            this.cbCrc3.TabIndex = 5;
            this.cbCrc3.Text = "NONE";
            // 
            // txtMS3
            // 
            this.txtMS3.Enabled = false;
            this.txtMS3.Location = new System.Drawing.Point(797, 126);
            this.txtMS3.Name = "txtMS3";
            this.txtMS3.Size = new System.Drawing.Size(44, 23);
            this.txtMS3.TabIndex = 4;
            this.txtMS3.Text = "1000";
            // 
            // cbCrc2
            // 
            this.cbCrc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrc2.FormattingEnabled = true;
            this.cbCrc2.Items.AddRange(new object[] {
            "NONE",
            "MODBUS",
            "SUM8",
            "SUM16"});
            this.cbCrc2.Location = new System.Drawing.Point(700, 94);
            this.cbCrc2.Name = "cbCrc2";
            this.cbCrc2.Size = new System.Drawing.Size(71, 21);
            this.cbCrc2.TabIndex = 5;
            this.cbCrc2.Text = "NONE";
            // 
            // txtMS2
            // 
            this.txtMS2.Enabled = false;
            this.txtMS2.Location = new System.Drawing.Point(797, 93);
            this.txtMS2.Name = "txtMS2";
            this.txtMS2.Size = new System.Drawing.Size(44, 23);
            this.txtMS2.TabIndex = 4;
            this.txtMS2.Text = "1000";
            // 
            // cbCrc1
            // 
            this.cbCrc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrc1.FormattingEnabled = true;
            this.cbCrc1.Items.AddRange(new object[] {
            "NONE",
            "MODBUS",
            "SUM8",
            "SUM16"});
            this.cbCrc1.Location = new System.Drawing.Point(700, 61);
            this.cbCrc1.Name = "cbCrc1";
            this.cbCrc1.Size = new System.Drawing.Size(71, 21);
            this.cbCrc1.TabIndex = 5;
            this.cbCrc1.Text = "NONE";
            // 
            // txtMS1
            // 
            this.txtMS1.Enabled = false;
            this.txtMS1.Location = new System.Drawing.Point(797, 60);
            this.txtMS1.Name = "txtMS1";
            this.txtMS1.Size = new System.Drawing.Size(44, 23);
            this.txtMS1.TabIndex = 4;
            this.txtMS1.Text = "1000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(775, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "T";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(706, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "+CRC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(667, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "+LF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(638, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "+CR";
            // 
            // chbTf5
            // 
            this.chbTf5.AutoSize = true;
            this.chbTf5.Location = new System.Drawing.Point(777, 200);
            this.chbTf5.Name = "chbTf5";
            this.chbTf5.Size = new System.Drawing.Size(15, 14);
            this.chbTf5.TabIndex = 2;
            this.chbTf5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(527, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Hexa";
            // 
            // chbTf4
            // 
            this.chbTf4.AutoSize = true;
            this.chbTf4.Location = new System.Drawing.Point(777, 163);
            this.chbTf4.Name = "chbTf4";
            this.chbTf4.Size = new System.Drawing.Size(15, 14);
            this.chbTf4.TabIndex = 2;
            this.chbTf4.UseVisualStyleBackColor = true;
            // 
            // chbHex5
            // 
            this.chbHex5.AutoSize = true;
            this.chbHex5.Location = new System.Drawing.Point(538, 200);
            this.chbHex5.Name = "chbHex5";
            this.chbHex5.Size = new System.Drawing.Size(15, 14);
            this.chbHex5.TabIndex = 2;
            this.chbHex5.UseVisualStyleBackColor = true;
            // 
            // chbTf3
            // 
            this.chbTf3.AutoSize = true;
            this.chbTf3.Location = new System.Drawing.Point(777, 130);
            this.chbTf3.Name = "chbTf3";
            this.chbTf3.Size = new System.Drawing.Size(15, 14);
            this.chbTf3.TabIndex = 2;
            this.chbTf3.UseVisualStyleBackColor = true;
            // 
            // chbLF5
            // 
            this.chbLF5.AutoSize = true;
            this.chbLF5.Location = new System.Drawing.Point(677, 200);
            this.chbLF5.Name = "chbLF5";
            this.chbLF5.Size = new System.Drawing.Size(15, 14);
            this.chbLF5.TabIndex = 2;
            this.chbLF5.UseVisualStyleBackColor = true;
            // 
            // chbHex4
            // 
            this.chbHex4.AutoSize = true;
            this.chbHex4.Location = new System.Drawing.Point(538, 163);
            this.chbHex4.Name = "chbHex4";
            this.chbHex4.Size = new System.Drawing.Size(15, 14);
            this.chbHex4.TabIndex = 2;
            this.chbHex4.UseVisualStyleBackColor = true;
            // 
            // chbLF4
            // 
            this.chbLF4.AutoSize = true;
            this.chbLF4.Location = new System.Drawing.Point(677, 163);
            this.chbLF4.Name = "chbLF4";
            this.chbLF4.Size = new System.Drawing.Size(15, 14);
            this.chbLF4.TabIndex = 2;
            this.chbLF4.UseVisualStyleBackColor = true;
            // 
            // chbTf2
            // 
            this.chbTf2.AutoSize = true;
            this.chbTf2.Location = new System.Drawing.Point(777, 97);
            this.chbTf2.Name = "chbTf2";
            this.chbTf2.Size = new System.Drawing.Size(15, 14);
            this.chbTf2.TabIndex = 2;
            this.chbTf2.UseVisualStyleBackColor = true;
            // 
            // chbLF3
            // 
            this.chbLF3.AutoSize = true;
            this.chbLF3.Location = new System.Drawing.Point(677, 130);
            this.chbLF3.Name = "chbLF3";
            this.chbLF3.Size = new System.Drawing.Size(15, 14);
            this.chbLF3.TabIndex = 2;
            this.chbLF3.UseVisualStyleBackColor = true;
            // 
            // chbHex3
            // 
            this.chbHex3.AutoSize = true;
            this.chbHex3.Location = new System.Drawing.Point(538, 130);
            this.chbHex3.Name = "chbHex3";
            this.chbHex3.Size = new System.Drawing.Size(15, 14);
            this.chbHex3.TabIndex = 2;
            this.chbHex3.UseVisualStyleBackColor = true;
            // 
            // chbCR5
            // 
            this.chbCR5.AutoSize = true;
            this.chbCR5.Location = new System.Drawing.Point(648, 200);
            this.chbCR5.Name = "chbCR5";
            this.chbCR5.Size = new System.Drawing.Size(15, 14);
            this.chbCR5.TabIndex = 2;
            this.chbCR5.UseVisualStyleBackColor = true;
            // 
            // chbLF2
            // 
            this.chbLF2.AutoSize = true;
            this.chbLF2.Location = new System.Drawing.Point(677, 97);
            this.chbLF2.Name = "chbLF2";
            this.chbLF2.Size = new System.Drawing.Size(15, 14);
            this.chbLF2.TabIndex = 2;
            this.chbLF2.UseVisualStyleBackColor = true;
            // 
            // chbCR4
            // 
            this.chbCR4.AutoSize = true;
            this.chbCR4.Location = new System.Drawing.Point(648, 163);
            this.chbCR4.Name = "chbCR4";
            this.chbCR4.Size = new System.Drawing.Size(15, 14);
            this.chbCR4.TabIndex = 2;
            this.chbCR4.UseVisualStyleBackColor = true;
            // 
            // chbTf1
            // 
            this.chbTf1.AutoSize = true;
            this.chbTf1.Location = new System.Drawing.Point(777, 64);
            this.chbTf1.Name = "chbTf1";
            this.chbTf1.Size = new System.Drawing.Size(15, 14);
            this.chbTf1.TabIndex = 2;
            this.chbTf1.UseVisualStyleBackColor = true;
            // 
            // chbCR3
            // 
            this.chbCR3.AutoSize = true;
            this.chbCR3.Location = new System.Drawing.Point(648, 130);
            this.chbCR3.Name = "chbCR3";
            this.chbCR3.Size = new System.Drawing.Size(15, 14);
            this.chbCR3.TabIndex = 2;
            this.chbCR3.UseVisualStyleBackColor = true;
            // 
            // chbLF1
            // 
            this.chbLF1.AutoSize = true;
            this.chbLF1.Location = new System.Drawing.Point(677, 64);
            this.chbLF1.Name = "chbLF1";
            this.chbLF1.Size = new System.Drawing.Size(15, 14);
            this.chbLF1.TabIndex = 2;
            this.chbLF1.UseVisualStyleBackColor = true;
            // 
            // chbCR2
            // 
            this.chbCR2.AutoSize = true;
            this.chbCR2.Location = new System.Drawing.Point(648, 97);
            this.chbCR2.Name = "chbCR2";
            this.chbCR2.Size = new System.Drawing.Size(15, 14);
            this.chbCR2.TabIndex = 2;
            this.chbCR2.UseVisualStyleBackColor = true;
            // 
            // chbHex2
            // 
            this.chbHex2.AutoSize = true;
            this.chbHex2.Location = new System.Drawing.Point(538, 97);
            this.chbHex2.Name = "chbHex2";
            this.chbHex2.Size = new System.Drawing.Size(15, 14);
            this.chbHex2.TabIndex = 2;
            this.chbHex2.UseVisualStyleBackColor = true;
            // 
            // chbCR1
            // 
            this.chbCR1.AutoSize = true;
            this.chbCR1.Location = new System.Drawing.Point(648, 64);
            this.chbCR1.Name = "chbCR1";
            this.chbCR1.Size = new System.Drawing.Size(15, 14);
            this.chbCR1.TabIndex = 2;
            this.chbCR1.UseVisualStyleBackColor = true;
            // 
            // chbHex1
            // 
            this.chbHex1.AutoSize = true;
            this.chbHex1.Location = new System.Drawing.Point(538, 64);
            this.chbHex1.Name = "chbHex1";
            this.chbHex1.Size = new System.Drawing.Size(15, 14);
            this.chbHex1.TabIndex = 2;
            this.chbHex1.UseVisualStyleBackColor = true;
            // 
            // btSend5
            // 
            this.btSend5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend5.Location = new System.Drawing.Point(563, 192);
            this.btSend5.Name = "btSend5";
            this.btSend5.Size = new System.Drawing.Size(75, 25);
            this.btSend5.TabIndex = 1;
            this.btSend5.Text = "SEND";
            this.btSend5.UseVisualStyleBackColor = true;
            // 
            // btSend4
            // 
            this.btSend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend4.Location = new System.Drawing.Point(563, 158);
            this.btSend4.Name = "btSend4";
            this.btSend4.Size = new System.Drawing.Size(75, 25);
            this.btSend4.TabIndex = 1;
            this.btSend4.Text = "SEND";
            this.btSend4.UseVisualStyleBackColor = true;
            // 
            // btSend3
            // 
            this.btSend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend3.Location = new System.Drawing.Point(563, 125);
            this.btSend3.Name = "btSend3";
            this.btSend3.Size = new System.Drawing.Size(75, 25);
            this.btSend3.TabIndex = 1;
            this.btSend3.Text = "SEND";
            this.btSend3.UseVisualStyleBackColor = true;
            // 
            // btSend2
            // 
            this.btSend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend2.Location = new System.Drawing.Point(563, 92);
            this.btSend2.Name = "btSend2";
            this.btSend2.Size = new System.Drawing.Size(75, 25);
            this.btSend2.TabIndex = 1;
            this.btSend2.Text = "SEND";
            this.btSend2.UseVisualStyleBackColor = true;
            // 
            // btSend1
            // 
            this.btSend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend1.Location = new System.Drawing.Point(563, 59);
            this.btSend1.Name = "btSend1";
            this.btSend1.Size = new System.Drawing.Size(75, 25);
            this.btSend1.TabIndex = 1;
            this.btSend1.Text = "SEND";
            this.btSend1.UseVisualStyleBackColor = true;
            // 
            // txtSend5
            // 
            this.txtSend5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend5.Location = new System.Drawing.Point(6, 194);
            this.txtSend5.Name = "txtSend5";
            this.txtSend5.Size = new System.Drawing.Size(520, 26);
            this.txtSend5.TabIndex = 0;
            // 
            // txtSend4
            // 
            this.txtSend4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend4.Location = new System.Drawing.Point(6, 157);
            this.txtSend4.Name = "txtSend4";
            this.txtSend4.Size = new System.Drawing.Size(520, 26);
            this.txtSend4.TabIndex = 0;
            // 
            // txtSend3
            // 
            this.txtSend3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend3.Location = new System.Drawing.Point(6, 124);
            this.txtSend3.Name = "txtSend3";
            this.txtSend3.Size = new System.Drawing.Size(520, 26);
            this.txtSend3.TabIndex = 0;
            // 
            // txtSend2
            // 
            this.txtSend2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend2.Location = new System.Drawing.Point(6, 91);
            this.txtSend2.Name = "txtSend2";
            this.txtSend2.Size = new System.Drawing.Size(520, 26);
            this.txtSend2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLength);
            this.groupBox4.Controls.Add(this.txtTimeSample);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.radioDEC);
            this.groupBox4.Controls.Add(this.radioHEX);
            this.groupBox4.Controls.Add(this.radioASCII);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 101);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive Options";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(132, 72);
            this.txtLength.Name = "txtLength";
            this.txtLength.ReadOnly = true;
            this.txtLength.Size = new System.Drawing.Size(46, 20);
            this.txtLength.TabIndex = 4;
            // 
            // txtTimeSample
            // 
            this.txtTimeSample.Location = new System.Drawing.Point(132, 47);
            this.txtTimeSample.Name = "txtTimeSample";
            this.txtTimeSample.ReadOnly = true;
            this.txtTimeSample.Size = new System.Drawing.Size(46, 20);
            this.txtTimeSample.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(84, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Length";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(79, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Time(ms)";
            // 
            // radioDEC
            // 
            this.radioDEC.AutoSize = true;
            this.radioDEC.Location = new System.Drawing.Point(132, 19);
            this.radioDEC.Name = "radioDEC";
            this.radioDEC.Size = new System.Drawing.Size(47, 17);
            this.radioDEC.TabIndex = 2;
            this.radioDEC.TabStop = true;
            this.radioDEC.Text = "DEC";
            this.radioDEC.UseVisualStyleBackColor = true;
            // 
            // radioHEX
            // 
            this.radioHEX.AutoSize = true;
            this.radioHEX.Location = new System.Drawing.Point(71, 19);
            this.radioHEX.Name = "radioHEX";
            this.radioHEX.Size = new System.Drawing.Size(47, 17);
            this.radioHEX.TabIndex = 2;
            this.radioHEX.TabStop = true;
            this.radioHEX.Text = "HEX";
            this.radioHEX.UseVisualStyleBackColor = true;
            // 
            // radioASCII
            // 
            this.radioASCII.AutoSize = true;
            this.radioASCII.Location = new System.Drawing.Point(8, 19);
            this.radioASCII.Name = "radioASCII";
            this.radioASCII.Size = new System.Drawing.Size(52, 17);
            this.radioASCII.TabIndex = 1;
            this.radioASCII.TabStop = true;
            this.radioASCII.Text = "ASCII";
            this.radioASCII.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 44);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(846, 599);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Size = new System.Drawing.Size(846, 380);
            this.splitContainer2.SplitterDistance = 649;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupSend);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer3.Size = new System.Drawing.Size(846, 215);
            this.splitContainer3.SplitterDistance = 186;
            this.splitContainer3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(682, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripComStatus
            // 
            this.toolStripComStatus.Name = "toolStripComStatus";
            this.toolStripComStatus.Size = new System.Drawing.Size(97, 17);
            this.toolStripComStatus.Text = "COM Disconnect";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTx});
            this.statusStrip2.Location = new System.Drawing.Point(682, 3);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(80, 22);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripTx
            // 
            this.toolStripTx.Name = "toolStripTx";
            this.toolStripTx.Size = new System.Drawing.Size(30, 17);
            this.toolStripTx.Text = "Tx: 0";
            // 
            // statusStrip3
            // 
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRx});
            this.statusStrip3.Location = new System.Drawing.Point(762, 3);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(84, 22);
            this.statusStrip3.TabIndex = 2;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripRx
            // 
            this.toolStripRx.Name = "toolStripRx";
            this.toolStripRx.Size = new System.Drawing.Size(32, 17);
            this.toolStripRx.Text = "Rx: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 599);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Terminal v1.0 HienND";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupSend.ResumeLayout(false);
            this.groupSend.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.TextBox txtSend1;
        private System.Windows.Forms.ComboBox cbCOM;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnReScan;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupSend;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSend3;
        private System.Windows.Forms.TextBox txtSend2;
        private System.Windows.Forms.Button btSend1;
        private System.Windows.Forms.TextBox txtSend5;
        private System.Windows.Forms.TextBox txtSend4;
        private System.Windows.Forms.CheckBox chbHex5;
        private System.Windows.Forms.CheckBox chbHex4;
        private System.Windows.Forms.CheckBox chbHex3;
        private System.Windows.Forms.CheckBox chbHex2;
        private System.Windows.Forms.Button btSend5;
        private System.Windows.Forms.Button btSend4;
        private System.Windows.Forms.Button btSend3;
        private System.Windows.Forms.Button btSend2;
        private System.Windows.Forms.CheckBox chbHex1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radioDEC;
        private System.Windows.Forms.RadioButton radioHEX;
        private System.Windows.Forms.RadioButton radioASCII;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHandShake;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataBit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox chbRTS;
        private System.Windows.Forms.CheckBox chbDTR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTx;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripRx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripComStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbLF1;
        private System.Windows.Forms.CheckBox chbCR1;
        private System.Windows.Forms.TextBox txtMS1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chbTf1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbCrc1;
        private System.Windows.Forms.ComboBox cbCrc5;
        private System.Windows.Forms.TextBox txtMS5;
        private System.Windows.Forms.ComboBox cbCrc4;
        private System.Windows.Forms.TextBox txtMS4;
        private System.Windows.Forms.ComboBox cbCrc3;
        private System.Windows.Forms.TextBox txtMS3;
        private System.Windows.Forms.ComboBox cbCrc2;
        private System.Windows.Forms.TextBox txtMS2;
        private System.Windows.Forms.CheckBox chbTf5;
        private System.Windows.Forms.CheckBox chbTf4;
        private System.Windows.Forms.CheckBox chbTf3;
        private System.Windows.Forms.CheckBox chbLF5;
        private System.Windows.Forms.CheckBox chbLF4;
        private System.Windows.Forms.CheckBox chbTf2;
        private System.Windows.Forms.CheckBox chbLF3;
        private System.Windows.Forms.CheckBox chbCR5;
        private System.Windows.Forms.CheckBox chbLF2;
        private System.Windows.Forms.CheckBox chbCR4;
        private System.Windows.Forms.CheckBox chbCR3;
        private System.Windows.Forms.CheckBox chbCR2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtTimeSample;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSendView;
    }
}

