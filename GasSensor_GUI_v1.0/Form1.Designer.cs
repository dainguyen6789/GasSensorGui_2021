namespace GasSensor_GUI_v1._0
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxTcpData = new System.Windows.Forms.TextBox();
            this.buttonSaveAsXlxs = new System.Windows.Forms.Button();
            this.uartStatusBox = new System.Windows.Forms.GroupBox();
            this.labelSerialPortStatus = new System.Windows.Forms.Label();
            this.panelSerialPortStatus = new System.Windows.Forms.Panel();
            this.uartConnectBox = new System.Windows.Forms.GroupBox();
            this.connectSerialPort = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.disconnectSerialPort = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonSetSampleTime = new System.Windows.Forms.Button();
            this.textBoxSampleTime = new System.Windows.Forms.TextBox();
            this.btnTcpStart = new System.Windows.Forms.Button();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonSetADCRefVoltage = new System.Windows.Forms.Button();
            this.textBoxRefADCVoltage = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSensor6Color = new System.Windows.Forms.ComboBox();
            this.comboBoxSensor5Color = new System.Windows.Forms.ComboBox();
            this.comboBoxSensor4Color = new System.Windows.Forms.ComboBox();
            this.comboBoxSensor3Color = new System.Windows.Forms.ComboBox();
            this.comboBoxSensor2Color = new System.Windows.Forms.ComboBox();
            this.comboBoxSensor1Color = new System.Windows.Forms.ComboBox();
            this.lblMaxXAxisPosition = new System.Windows.Forms.Label();
            this.lblMinXAxisPosition = new System.Windows.Forms.Label();
            this.Sensor5Enable = new System.Windows.Forms.CheckBox();
            this.Sensor4Enable = new System.Windows.Forms.CheckBox();
            this.Sensor6Enable = new System.Windows.Forms.CheckBox();
            this.Sensor3Enable = new System.Windows.Forms.CheckBox();
            this.Sensor2Enable = new System.Windows.Forms.CheckBox();
            this.Sensor1Enable = new System.Windows.Forms.CheckBox();
            this.lblMinYAxisPosition = new System.Windows.Forms.Label();
            this.lblMaxYAxisPosition = new System.Windows.Forms.Label();
            this.buttonClearChart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetAutoScale = new System.Windows.Forms.ToolStripMenuItem();
            this.setMaxAxisYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UartCheckingTImer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog_ChangeChartSeriesColor = new System.Windows.Forms.ColorDialog();
            this.groupBoxUartControl = new System.Windows.Forms.GroupBox();
            this.groupBoxTcpControl = new System.Windows.Forms.GroupBox();
            this.groupBoxOthers = new System.Windows.Forms.GroupBox();
            this.radioButton_EnableUart = new System.Windows.Forms.RadioButton();
            this.radioButton_EnableTcp = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.uartStatusBox.SuspendLayout();
            this.uartConnectBox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBoxUartControl.SuspendLayout();
            this.groupBoxTcpControl.SuspendLayout();
            this.groupBoxOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Honeydew;
            this.chart1.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart1.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.DimGray;
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.MajorGrid.Interval = 0D;
            chartArea4.AxisX.MinorGrid.Enabled = true;
            chartArea4.AxisX.Title = "Time (hour)";
            chartArea4.AxisY.LabelAutoFitMaxFontSize = 12;
            chartArea4.AxisY.LabelAutoFitMinFontSize = 10;
            chartArea4.AxisY.MajorGrid.Interval = 0D;
            chartArea4.AxisY.MajorTickMark.Interval = 0D;
            chartArea4.AxisY.Maximum = 6D;
            chartArea4.AxisY.MinorGrid.Enabled = true;
            chartArea4.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.Title = "Voltage (V)";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY2.Title = "RH (%)/Temp (*C)";
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Far;
            legend4.DockedToChartArea = "ChartArea1";
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.IsTextAutoFit = false;
            legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend4.Name = "Legend1";
            legend4.TextWrapThreshold = 50;
            legend4.TitleForeColor = System.Drawing.Color.BlanchedAlmond;
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(21, 26);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(877, 645);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Sensor Voltage (V)";
            title4.Text = "Sensor Voltage (V)";
            this.chart1.Titles.Add(title4);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AllowDrop = true;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(20, 657);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(122, 28);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save Chart";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(362, 193);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(82, 28);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.SampleTime,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Temp});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(802, 408);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Clock Time";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // SampleTime
            // 
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.SampleTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.SampleTime.HeaderText = "Time (min)";
            this.SampleTime.MinimumWidth = 6;
            this.SampleTime.Name = "SampleTime";
            this.SampleTime.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sensor #1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sensor #2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sensor #3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sensor #4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sensor #5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sensor #6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "RH(%)";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 60;
            // 
            // Temp
            // 
            this.Temp.HeaderText = "Temp (˚C)";
            this.Temp.MinimumWidth = 6;
            this.Temp.Name = "Temp";
            this.Temp.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.txtBoxTcpData);
            this.groupBox1.Controls.Add(this.buttonSaveAsXlxs);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(824, 438);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gas Sensor Voltage (V)";
            // 
            // txtBoxTcpData
            // 
            this.txtBoxTcpData.Location = new System.Drawing.Point(17, 506);
            this.txtBoxTcpData.Name = "txtBoxTcpData";
            this.txtBoxTcpData.Size = new System.Drawing.Size(331, 26);
            this.txtBoxTcpData.TabIndex = 13;
            // 
            // buttonSaveAsXlxs
            // 
            this.buttonSaveAsXlxs.Location = new System.Drawing.Point(17, 382);
            this.buttonSaveAsXlxs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAsXlxs.Name = "buttonSaveAsXlxs";
            this.buttonSaveAsXlxs.Size = new System.Drawing.Size(199, 28);
            this.buttonSaveAsXlxs.TabIndex = 8;
            this.buttonSaveAsXlxs.Text = "Save Data as xlxs";
            this.buttonSaveAsXlxs.UseVisualStyleBackColor = true;
            this.buttonSaveAsXlxs.Click += new System.EventHandler(this.ButtonSaveAsXlxs_Click);
            // 
            // uartStatusBox
            // 
            this.uartStatusBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uartStatusBox.Controls.Add(this.labelSerialPortStatus);
            this.uartStatusBox.Controls.Add(this.panelSerialPortStatus);
            this.uartStatusBox.Enabled = false;
            this.uartStatusBox.Location = new System.Drawing.Point(7, 25);
            this.uartStatusBox.Margin = new System.Windows.Forms.Padding(4);
            this.uartStatusBox.Name = "uartStatusBox";
            this.uartStatusBox.Padding = new System.Windows.Forms.Padding(4);
            this.uartStatusBox.Size = new System.Drawing.Size(156, 89);
            this.uartStatusBox.TabIndex = 4;
            this.uartStatusBox.TabStop = false;
            this.uartStatusBox.Text = "Status";
            // 
            // labelSerialPortStatus
            // 
            this.labelSerialPortStatus.AutoSize = true;
            this.labelSerialPortStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSerialPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialPortStatus.Location = new System.Drawing.Point(8, 20);
            this.labelSerialPortStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSerialPortStatus.Name = "labelSerialPortStatus";
            this.labelSerialPortStatus.Size = new System.Drawing.Size(143, 25);
            this.labelSerialPortStatus.TabIndex = 4;
            this.labelSerialPortStatus.Text = "Disconnected";
            // 
            // panelSerialPortStatus
            // 
            this.panelSerialPortStatus.BackColor = System.Drawing.Color.Red;
            this.panelSerialPortStatus.Location = new System.Drawing.Point(56, 49);
            this.panelSerialPortStatus.Margin = new System.Windows.Forms.Padding(4);
            this.panelSerialPortStatus.Name = "panelSerialPortStatus";
            this.panelSerialPortStatus.Size = new System.Drawing.Size(28, 28);
            this.panelSerialPortStatus.TabIndex = 3;
            // 
            // uartConnectBox
            // 
            this.uartConnectBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.uartConnectBox.Controls.Add(this.connectSerialPort);
            this.uartConnectBox.Controls.Add(this.comboBox1);
            this.uartConnectBox.Controls.Add(this.disconnectSerialPort);
            this.uartConnectBox.Enabled = false;
            this.uartConnectBox.Location = new System.Drawing.Point(166, 24);
            this.uartConnectBox.Margin = new System.Windows.Forms.Padding(4);
            this.uartConnectBox.Name = "uartConnectBox";
            this.uartConnectBox.Padding = new System.Windows.Forms.Padding(4);
            this.uartConnectBox.Size = new System.Drawing.Size(185, 90);
            this.uartConnectBox.TabIndex = 7;
            this.uartConnectBox.TabStop = false;
            this.uartConnectBox.Text = "Select UART";
            // 
            // connectSerialPort
            // 
            this.connectSerialPort.Location = new System.Drawing.Point(105, 56);
            this.connectSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.connectSerialPort.Name = "connectSerialPort";
            this.connectSerialPort.Size = new System.Drawing.Size(73, 28);
            this.connectSerialPort.TabIndex = 1;
            this.connectSerialPort.Text = "Con";
            this.connectSerialPort.UseVisualStyleBackColor = true;
            this.connectSerialPort.Click += new System.EventHandler(this.ConnectSerialPort_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // disconnectSerialPort
            // 
            this.disconnectSerialPort.Location = new System.Drawing.Point(12, 56);
            this.disconnectSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectSerialPort.Name = "disconnectSerialPort";
            this.disconnectSerialPort.Size = new System.Drawing.Size(85, 28);
            this.disconnectSerialPort.TabIndex = 2;
            this.disconnectSerialPort.Text = "Discon";
            this.disconnectSerialPort.UseVisualStyleBackColor = true;
            this.disconnectSerialPort.Click += new System.EventHandler(this.DisconnectSerialPort_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox6.Controls.Add(this.buttonSetSampleTime);
            this.groupBox6.Controls.Add(this.textBoxSampleTime);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(7, 51);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(157, 92);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sample Time (s)";
            // 
            // buttonSetSampleTime
            // 
            this.buttonSetSampleTime.Location = new System.Drawing.Point(67, 35);
            this.buttonSetSampleTime.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetSampleTime.Name = "buttonSetSampleTime";
            this.buttonSetSampleTime.Size = new System.Drawing.Size(53, 28);
            this.buttonSetSampleTime.TabIndex = 1;
            this.buttonSetSampleTime.Text = "Set";
            this.buttonSetSampleTime.UseVisualStyleBackColor = true;
            this.buttonSetSampleTime.Click += new System.EventHandler(this.ButtonSetSampleTime_Click);
            // 
            // textBoxSampleTime
            // 
            this.textBoxSampleTime.Location = new System.Drawing.Point(32, 38);
            this.textBoxSampleTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSampleTime.Name = "textBoxSampleTime";
            this.textBoxSampleTime.Size = new System.Drawing.Size(27, 23);
            this.textBoxSampleTime.TabIndex = 0;
            this.textBoxSampleTime.Text = "1";
            this.textBoxSampleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTcpStart
            // 
            this.btnTcpStart.Enabled = false;
            this.btnTcpStart.Location = new System.Drawing.Point(17, 23);
            this.btnTcpStart.Name = "btnTcpStart";
            this.btnTcpStart.Size = new System.Drawing.Size(136, 27);
            this.btnTcpStart.TabIndex = 12;
            this.btnTcpStart.Text = "Start TCP";
            this.btnTcpStart.UseVisualStyleBackColor = true;
            this.btnTcpStart.Click += new System.EventHandler(this.btnTcpStart_Click);
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AccessibleName = "";
            this.lblIpAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Enabled = false;
            this.lblIpAddress.Location = new System.Drawing.Point(21, 61);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(70, 20);
            this.lblIpAddress.TabIndex = 11;
            this.lblIpAddress.Text = "IP Address";
            this.lblIpAddress.UseCompatibleTextRendering = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox7.Controls.Add(this.textBoxCount);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(362, 51);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(82, 93);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Count";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(8, 39);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(60, 23);
            this.textBoxCount.TabIndex = 0;
            this.textBoxCount.Text = "0";
            this.textBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox5.Controls.Add(this.buttonSetADCRefVoltage);
            this.groupBox5.Controls.Add(this.textBoxRefADCVoltage);
            this.groupBox5.Location = new System.Drawing.Point(177, 51);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(177, 92);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ADC Ref. Voltage";
            // 
            // buttonSetADCRefVoltage
            // 
            this.buttonSetADCRefVoltage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetADCRefVoltage.Location = new System.Drawing.Point(79, 37);
            this.buttonSetADCRefVoltage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetADCRefVoltage.Name = "buttonSetADCRefVoltage";
            this.buttonSetADCRefVoltage.Size = new System.Drawing.Size(53, 28);
            this.buttonSetADCRefVoltage.TabIndex = 1;
            this.buttonSetADCRefVoltage.Text = "Set";
            this.buttonSetADCRefVoltage.UseVisualStyleBackColor = true;
            this.buttonSetADCRefVoltage.Click += new System.EventHandler(this.ButtonSetADCRefVoltage_Click);
            // 
            // textBoxRefADCVoltage
            // 
            this.textBoxRefADCVoltage.Location = new System.Drawing.Point(16, 39);
            this.textBoxRefADCVoltage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRefADCVoltage.Name = "textBoxRefADCVoltage";
            this.textBoxRefADCVoltage.Size = new System.Drawing.Size(43, 22);
            this.textBoxRefADCVoltage.TabIndex = 0;
            this.textBoxRefADCVoltage.Text = "5";
            this.textBoxRefADCVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRefADCVoltage.TextChanged += new System.EventHandler(this.textBoxRefADCVoltage_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(7, 163);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(157, 58);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear Chart\r\n and Data";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.ButtonSave);
            this.groupBox2.Controls.Add(this.comboBoxSensor6Color);
            this.groupBox2.Controls.Add(this.comboBoxSensor5Color);
            this.groupBox2.Controls.Add(this.comboBoxSensor4Color);
            this.groupBox2.Controls.Add(this.comboBoxSensor3Color);
            this.groupBox2.Controls.Add(this.comboBoxSensor2Color);
            this.groupBox2.Controls.Add(this.comboBoxSensor1Color);
            this.groupBox2.Controls.Add(this.lblMaxXAxisPosition);
            this.groupBox2.Controls.Add(this.lblMinXAxisPosition);
            this.groupBox2.Controls.Add(this.Sensor5Enable);
            this.groupBox2.Controls.Add(this.Sensor4Enable);
            this.groupBox2.Controls.Add(this.Sensor6Enable);
            this.groupBox2.Controls.Add(this.Sensor3Enable);
            this.groupBox2.Controls.Add(this.Sensor2Enable);
            this.groupBox2.Controls.Add(this.Sensor1Enable);
            this.groupBox2.Controls.Add(this.lblMinYAxisPosition);
            this.groupBox2.Controls.Add(this.lblMaxYAxisPosition);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(836, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(917, 705);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graph";
            // 
            // comboBoxSensor6Color
            // 
            this.comboBoxSensor6Color.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor6Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSensor6Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensor6Color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSensor6Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSensor6Color.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor6Color.FormattingEnabled = true;
            this.comboBoxSensor6Color.Location = new System.Drawing.Point(792, 652);
            this.comboBoxSensor6Color.Name = "comboBoxSensor6Color";
            this.comboBoxSensor6Color.Size = new System.Drawing.Size(76, 23);
            this.comboBoxSensor6Color.TabIndex = 15;
            this.comboBoxSensor6Color.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxSensor6Color_DrawItem);
            // 
            // comboBoxSensor5Color
            // 
            this.comboBoxSensor5Color.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor5Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSensor5Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensor5Color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSensor5Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSensor5Color.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor5Color.FormattingEnabled = true;
            this.comboBoxSensor5Color.Location = new System.Drawing.Point(664, 651);
            this.comboBoxSensor5Color.Name = "comboBoxSensor5Color";
            this.comboBoxSensor5Color.Size = new System.Drawing.Size(76, 23);
            this.comboBoxSensor5Color.TabIndex = 15;
            this.comboBoxSensor5Color.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxSensor5Color_DrawItem);
            // 
            // comboBoxSensor4Color
            // 
            this.comboBoxSensor4Color.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor4Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSensor4Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensor4Color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSensor4Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSensor4Color.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor4Color.FormattingEnabled = true;
            this.comboBoxSensor4Color.Location = new System.Drawing.Point(544, 651);
            this.comboBoxSensor4Color.Name = "comboBoxSensor4Color";
            this.comboBoxSensor4Color.Size = new System.Drawing.Size(76, 23);
            this.comboBoxSensor4Color.TabIndex = 15;
            this.comboBoxSensor4Color.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxSensor4Color_DrawItem);
            // 
            // comboBoxSensor3Color
            // 
            this.comboBoxSensor3Color.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor3Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSensor3Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensor3Color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSensor3Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSensor3Color.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor3Color.FormattingEnabled = true;
            this.comboBoxSensor3Color.Location = new System.Drawing.Point(426, 651);
            this.comboBoxSensor3Color.Name = "comboBoxSensor3Color";
            this.comboBoxSensor3Color.Size = new System.Drawing.Size(76, 23);
            this.comboBoxSensor3Color.TabIndex = 15;
            this.comboBoxSensor3Color.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxSensor3Color_DrawItem);
            // 
            // comboBoxSensor2Color
            // 
            this.comboBoxSensor2Color.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor2Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSensor2Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensor2Color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSensor2Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSensor2Color.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor2Color.FormattingEnabled = true;
            this.comboBoxSensor2Color.Location = new System.Drawing.Point(298, 651);
            this.comboBoxSensor2Color.Name = "comboBoxSensor2Color";
            this.comboBoxSensor2Color.Size = new System.Drawing.Size(76, 23);
            this.comboBoxSensor2Color.TabIndex = 15;
            this.comboBoxSensor2Color.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxSensor2Color_DrawItem);
            // 
            // comboBoxSensor1Color
            // 
            this.comboBoxSensor1Color.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor1Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSensor1Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensor1Color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSensor1Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSensor1Color.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxSensor1Color.FormattingEnabled = true;
            this.comboBoxSensor1Color.Location = new System.Drawing.Point(173, 652);
            this.comboBoxSensor1Color.Name = "comboBoxSensor1Color";
            this.comboBoxSensor1Color.Size = new System.Drawing.Size(76, 23);
            this.comboBoxSensor1Color.TabIndex = 15;
            this.comboBoxSensor1Color.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxSensor1Color_DrawItem);
            // 
            // lblMaxXAxisPosition
            // 
            this.lblMaxXAxisPosition.AutoSize = true;
            this.lblMaxXAxisPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxXAxisPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxXAxisPosition.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaxXAxisPosition.Location = new System.Drawing.Point(745, 560);
            this.lblMaxXAxisPosition.Name = "lblMaxXAxisPosition";
            this.lblMaxXAxisPosition.Size = new System.Drawing.Size(69, 29);
            this.lblMaxXAxisPosition.TabIndex = 14;
            this.lblMaxXAxisPosition.Text = "        ";
            this.lblMaxXAxisPosition.UseMnemonic = false;
            this.lblMaxXAxisPosition.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MouseDoubleClick_MaxXAxis);
            // 
            // lblMinXAxisPosition
            // 
            this.lblMinXAxisPosition.AutoSize = true;
            this.lblMinXAxisPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblMinXAxisPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinXAxisPosition.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMinXAxisPosition.Location = new System.Drawing.Point(80, 570);
            this.lblMinXAxisPosition.Name = "lblMinXAxisPosition";
            this.lblMinXAxisPosition.Size = new System.Drawing.Size(69, 29);
            this.lblMinXAxisPosition.TabIndex = 13;
            this.lblMinXAxisPosition.Text = "        ";
            this.lblMinXAxisPosition.UseMnemonic = false;
            this.lblMinXAxisPosition.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MouseDoubleClick_MinXAxis);
            // 
            // Sensor5Enable
            // 
            this.Sensor5Enable.AutoSize = true;
            this.Sensor5Enable.BackColor = System.Drawing.Color.Pink;
            this.Sensor5Enable.Checked = true;
            this.Sensor5Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensor5Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor5Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor5Enable.Location = new System.Drawing.Point(664, 681);
            this.Sensor5Enable.Margin = new System.Windows.Forms.Padding(4);
            this.Sensor5Enable.Name = "Sensor5Enable";
            this.Sensor5Enable.Size = new System.Drawing.Size(76, 21);
            this.Sensor5Enable.TabIndex = 12;
            this.Sensor5Enable.Text = "Sens 5";
            this.Sensor5Enable.UseVisualStyleBackColor = false;
            this.Sensor5Enable.CheckedChanged += new System.EventHandler(this.Sensor5Enable_CheckedChanged);
            // 
            // Sensor4Enable
            // 
            this.Sensor4Enable.AutoSize = true;
            this.Sensor4Enable.BackColor = System.Drawing.Color.Pink;
            this.Sensor4Enable.Checked = true;
            this.Sensor4Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensor4Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor4Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor4Enable.Location = new System.Drawing.Point(544, 681);
            this.Sensor4Enable.Margin = new System.Windows.Forms.Padding(4);
            this.Sensor4Enable.Name = "Sensor4Enable";
            this.Sensor4Enable.Size = new System.Drawing.Size(76, 21);
            this.Sensor4Enable.TabIndex = 11;
            this.Sensor4Enable.Text = "Sens 4";
            this.Sensor4Enable.UseVisualStyleBackColor = false;
            this.Sensor4Enable.CheckedChanged += new System.EventHandler(this.Sensor4Enable_CheckedChanged);
            // 
            // Sensor6Enable
            // 
            this.Sensor6Enable.AutoSize = true;
            this.Sensor6Enable.BackColor = System.Drawing.Color.Pink;
            this.Sensor6Enable.Checked = true;
            this.Sensor6Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensor6Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor6Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor6Enable.Location = new System.Drawing.Point(792, 681);
            this.Sensor6Enable.Margin = new System.Windows.Forms.Padding(4);
            this.Sensor6Enable.Name = "Sensor6Enable";
            this.Sensor6Enable.Size = new System.Drawing.Size(76, 21);
            this.Sensor6Enable.TabIndex = 10;
            this.Sensor6Enable.Text = "Sens 6";
            this.Sensor6Enable.UseVisualStyleBackColor = false;
            this.Sensor6Enable.CheckedChanged += new System.EventHandler(this.Sensor6Enable_CheckedChanged);
            // 
            // Sensor3Enable
            // 
            this.Sensor3Enable.AutoSize = true;
            this.Sensor3Enable.BackColor = System.Drawing.Color.Pink;
            this.Sensor3Enable.Checked = true;
            this.Sensor3Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensor3Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor3Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor3Enable.Location = new System.Drawing.Point(426, 681);
            this.Sensor3Enable.Margin = new System.Windows.Forms.Padding(4);
            this.Sensor3Enable.Name = "Sensor3Enable";
            this.Sensor3Enable.Size = new System.Drawing.Size(76, 21);
            this.Sensor3Enable.TabIndex = 9;
            this.Sensor3Enable.Text = "Sens 3";
            this.Sensor3Enable.UseVisualStyleBackColor = false;
            this.Sensor3Enable.CheckedChanged += new System.EventHandler(this.Sensor3Enable_CheckedChanged);
            // 
            // Sensor2Enable
            // 
            this.Sensor2Enable.AutoSize = true;
            this.Sensor2Enable.BackColor = System.Drawing.Color.Pink;
            this.Sensor2Enable.Checked = true;
            this.Sensor2Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensor2Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor2Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor2Enable.Location = new System.Drawing.Point(298, 681);
            this.Sensor2Enable.Margin = new System.Windows.Forms.Padding(4);
            this.Sensor2Enable.Name = "Sensor2Enable";
            this.Sensor2Enable.Size = new System.Drawing.Size(76, 21);
            this.Sensor2Enable.TabIndex = 8;
            this.Sensor2Enable.Text = "Sens 2";
            this.Sensor2Enable.UseVisualStyleBackColor = false;
            this.Sensor2Enable.CheckedChanged += new System.EventHandler(this.Sensor2Enable_CheckedChanged);
            // 
            // Sensor1Enable
            // 
            this.Sensor1Enable.AutoSize = true;
            this.Sensor1Enable.BackColor = System.Drawing.Color.Pink;
            this.Sensor1Enable.Checked = true;
            this.Sensor1Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensor1Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor1Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor1Enable.Location = new System.Drawing.Point(173, 681);
            this.Sensor1Enable.Margin = new System.Windows.Forms.Padding(4);
            this.Sensor1Enable.Name = "Sensor1Enable";
            this.Sensor1Enable.Size = new System.Drawing.Size(76, 21);
            this.Sensor1Enable.TabIndex = 7;
            this.Sensor1Enable.Text = "Sens 1";
            this.Sensor1Enable.UseVisualStyleBackColor = false;
            this.Sensor1Enable.CheckedChanged += new System.EventHandler(this.Sensor1Enable_CheckedChanged);
            // 
            // lblMinYAxisPosition
            // 
            this.lblMinYAxisPosition.AutoSize = true;
            this.lblMinYAxisPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblMinYAxisPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinYAxisPosition.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMinYAxisPosition.Location = new System.Drawing.Point(73, 540);
            this.lblMinYAxisPosition.Name = "lblMinYAxisPosition";
            this.lblMinYAxisPosition.Size = new System.Drawing.Size(69, 29);
            this.lblMinYAxisPosition.TabIndex = 6;
            this.lblMinYAxisPosition.Text = "        ";
            this.lblMinYAxisPosition.UseMnemonic = false;
            this.lblMinYAxisPosition.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MouseDoubleClick_MinYAxis);
            // 
            // lblMaxYAxisPosition
            // 
            this.lblMaxYAxisPosition.AutoSize = true;
            this.lblMaxYAxisPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxYAxisPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxYAxisPosition.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMaxYAxisPosition.Location = new System.Drawing.Point(73, 60);
            this.lblMaxYAxisPosition.Name = "lblMaxYAxisPosition";
            this.lblMaxYAxisPosition.Size = new System.Drawing.Size(69, 29);
            this.lblMaxYAxisPosition.TabIndex = 5;
            this.lblMaxYAxisPosition.Text = "        ";
            this.lblMaxYAxisPosition.UseMnemonic = false;
            this.lblMaxYAxisPosition.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MaxYAxisPosition_Click);
            this.lblMaxYAxisPosition.MouseLeave += new System.EventHandler(this.OnMouseLeave_lblMaxYPosition);
            // 
            // buttonClearChart
            // 
            this.buttonClearChart.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonClearChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClearChart.ForeColor = System.Drawing.Color.Red;
            this.buttonClearChart.Location = new System.Drawing.Point(177, 163);
            this.buttonClearChart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearChart.Name = "buttonClearChart";
            this.buttonClearChart.Size = new System.Drawing.Size(132, 58);
            this.buttonClearChart.TabIndex = 4;
            this.buttonClearChart.Text = "Clear Chart";
            this.buttonClearChart.UseVisualStyleBackColor = true;
            this.buttonClearChart.Click += new System.EventHandler(this.ButtonClearChart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 685);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DiscardNull = true;
            this.serialPort1.DtrEnable = true;
            this.serialPort1.ParityReplace = ((byte)(0));
            this.serialPort1.PortName = "COM6";
            this.serialPort1.ReadBufferSize = 8;
            this.serialPort1.ReceivedBytesThreshold = 9;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.WriteBufferSize = 64;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this._uart_DataReceived);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.Filter = "(*.png)|*.png|(*.bmp)|*bmp|All Files|*.";
            this.saveFileDialog1.Title = "Save File";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1710, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.saveToolStripMenuItem.Text = "Save Graph as Png File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version10ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // version10ToolStripMenuItem
            // 
            this.version10ToolStripMenuItem.Name = "version10ToolStripMenuItem";
            this.version10ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.version10ToolStripMenuItem.Text = "Gas Sensor GUI";
            this.version10ToolStripMenuItem.Click += new System.EventHandler(this.Version10ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItemSetAutoScale,
            this.setMaxAxisYToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 24);
            this.toolStripMenuItem1.Text = "Clear Chart";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItemSetAutoScale
            // 
            this.toolStripMenuItemSetAutoScale.Name = "toolStripMenuItemSetAutoScale";
            this.toolStripMenuItemSetAutoScale.Size = new System.Drawing.Size(170, 24);
            this.toolStripMenuItemSetAutoScale.Text = "Set AutoScale";
            this.toolStripMenuItemSetAutoScale.Click += new System.EventHandler(this.ToolStripMenuItemSetAutoScale_Click);
            // 
            // setMaxAxisYToolStripMenuItem
            // 
            this.setMaxAxisYToolStripMenuItem.Name = "setMaxAxisYToolStripMenuItem";
            this.setMaxAxisYToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.setMaxAxisYToolStripMenuItem.Text = "Set Max AxisY";
            this.setMaxAxisYToolStripMenuItem.Click += new System.EventHandler(this.SetMaxAxisYToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(713, 645);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 93);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UartCheckingTImer
            // 
            this.UartCheckingTImer.Enabled = true;
            this.UartCheckingTImer.Interval = 1000;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 658);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxUartControl
            // 
            this.groupBoxUartControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxUartControl.Controls.Add(this.uartConnectBox);
            this.groupBoxUartControl.Controls.Add(this.uartStatusBox);
            this.groupBoxUartControl.Location = new System.Drawing.Point(4, 482);
            this.groupBoxUartControl.Name = "groupBoxUartControl";
            this.groupBoxUartControl.Size = new System.Drawing.Size(359, 154);
            this.groupBoxUartControl.TabIndex = 10;
            this.groupBoxUartControl.TabStop = false;
            this.groupBoxUartControl.Text = "UART";
            // 
            // groupBoxTcpControl
            // 
            this.groupBoxTcpControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxTcpControl.Controls.Add(this.btnTcpStart);
            this.groupBoxTcpControl.Controls.Add(this.lblIpAddress);
            this.groupBoxTcpControl.Location = new System.Drawing.Point(4, 645);
            this.groupBoxTcpControl.Name = "groupBoxTcpControl";
            this.groupBoxTcpControl.Size = new System.Drawing.Size(359, 93);
            this.groupBoxTcpControl.TabIndex = 14;
            this.groupBoxTcpControl.TabStop = false;
            this.groupBoxTcpControl.Text = "TCP";
            // 
            // groupBoxOthers
            // 
            this.groupBoxOthers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxOthers.Controls.Add(this.radioButton_EnableUart);
            this.groupBoxOthers.Controls.Add(this.groupBox5);
            this.groupBoxOthers.Controls.Add(this.radioButton_EnableTcp);
            this.groupBoxOthers.Controls.Add(this.buttonClearChart);
            this.groupBoxOthers.Controls.Add(this.buttonClear);
            this.groupBoxOthers.Controls.Add(this.groupBox7);
            this.groupBoxOthers.Controls.Add(this.groupBox6);
            this.groupBoxOthers.Controls.Add(this.ButtonExit);
            this.groupBoxOthers.Location = new System.Drawing.Point(369, 482);
            this.groupBoxOthers.Name = "groupBoxOthers";
            this.groupBoxOthers.Size = new System.Drawing.Size(459, 257);
            this.groupBoxOthers.TabIndex = 15;
            this.groupBoxOthers.TabStop = false;
            this.groupBoxOthers.Text = "Others";
            // 
            // radioButton_EnableUart
            // 
            this.radioButton_EnableUart.AutoSize = true;
            this.radioButton_EnableUart.Checked = true;
            this.radioButton_EnableUart.Location = new System.Drawing.Point(12, 21);
            this.radioButton_EnableUart.Name = "radioButton_EnableUart";
            this.radioButton_EnableUart.Size = new System.Drawing.Size(115, 21);
            this.radioButton_EnableUart.TabIndex = 15;
            this.radioButton_EnableUart.TabStop = true;
            this.radioButton_EnableUart.Text = "Enable UART";
            this.radioButton_EnableUart.UseVisualStyleBackColor = true;
            this.radioButton_EnableUart.Visible = false;
            this.radioButton_EnableUart.Click += new System.EventHandler(this.radioButton_EnableUart_Click);
            // 
            // radioButton_EnableTcp
            // 
            this.radioButton_EnableTcp.AutoSize = true;
            this.radioButton_EnableTcp.Location = new System.Drawing.Point(177, 21);
            this.radioButton_EnableTcp.Name = "radioButton_EnableTcp";
            this.radioButton_EnableTcp.Size = new System.Drawing.Size(104, 21);
            this.radioButton_EnableTcp.TabIndex = 14;
            this.radioButton_EnableTcp.TabStop = true;
            this.radioButton_EnableTcp.Text = "Enable TCP";
            this.radioButton_EnableTcp.UseVisualStyleBackColor = true;
            this.radioButton_EnableTcp.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1710, 748);
            this.Controls.Add(this.groupBoxOthers);
            this.Controls.Add(this.groupBoxTcpControl);
            this.Controls.Add(this.groupBoxUartControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gas Sensor GUI v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.uartStatusBox.ResumeLayout(false);
            this.uartStatusBox.PerformLayout();
            this.uartConnectBox.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBoxUartControl.ResumeLayout(false);
            this.groupBoxTcpControl.ResumeLayout(false);
            this.groupBoxTcpControl.PerformLayout();
            this.groupBoxOthers.ResumeLayout(false);
            this.groupBoxOthers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version10ToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveAsXlxs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button connectSerialPort;
        private System.Windows.Forms.Button disconnectSerialPort;
        private System.Windows.Forms.GroupBox uartStatusBox;
        private System.Windows.Forms.Label labelSerialPortStatus;
        private System.Windows.Forms.Panel panelSerialPortStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonClear;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonSetADCRefVoltage;
        private System.Windows.Forms.TextBox textBoxRefADCVoltage;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonSetSampleTime;
        private System.Windows.Forms.TextBox textBoxSampleTime;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonClearChart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox uartConnectBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetAutoScale;
        private System.Windows.Forms.ToolStripMenuItem setMaxAxisYToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMaxYAxisPosition;
        private System.Windows.Forms.Label lblMinYAxisPosition;
        private System.Windows.Forms.CheckBox Sensor5Enable;
        private System.Windows.Forms.CheckBox Sensor4Enable;
        private System.Windows.Forms.CheckBox Sensor6Enable;
        private System.Windows.Forms.CheckBox Sensor3Enable;
        private System.Windows.Forms.CheckBox Sensor2Enable;
        private System.Windows.Forms.CheckBox Sensor1Enable;
        private System.Windows.Forms.Timer UartCheckingTImer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog_ChangeChartSeriesColor;
        private System.Windows.Forms.Label lblMaxXAxisPosition;
        private System.Windows.Forms.Label lblMinXAxisPosition;
        private System.Windows.Forms.ComboBox comboBoxSensor1Color;
        private System.Windows.Forms.ComboBox comboBoxSensor6Color;
        private System.Windows.Forms.ComboBox comboBoxSensor5Color;
        private System.Windows.Forms.ComboBox comboBoxSensor4Color;
        private System.Windows.Forms.ComboBox comboBoxSensor3Color;
        private System.Windows.Forms.ComboBox comboBoxSensor2Color;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Button btnTcpStart;
        private System.Windows.Forms.TextBox txtBoxTcpData;
        private System.Windows.Forms.GroupBox groupBoxUartControl;
        private System.Windows.Forms.GroupBox groupBoxTcpControl;
        private System.Windows.Forms.GroupBox groupBoxOthers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp;
        private System.Windows.Forms.RadioButton radioButton_EnableTcp;
        private System.Windows.Forms.RadioButton radioButton_EnableUart;
    }
}

