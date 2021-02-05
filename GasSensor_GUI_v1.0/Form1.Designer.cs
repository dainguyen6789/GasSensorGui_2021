﻿namespace GasSensor_GUI_v1._0
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonSetSampleTime = new System.Windows.Forms.Button();
            this.textBoxSampleTime = new System.Windows.Forms.TextBox();
            this.buttonSaveAsXlxs = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMinYAxisPosition = new System.Windows.Forms.Label();
            this.lblMaxYAxisPosition = new System.Windows.Forms.Label();
            this.buttonClearChart = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.connectSerialPort = new System.Windows.Forms.Button();
            this.disconnectSerialPort = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelSerialPortStatus = new System.Windows.Forms.Label();
            this.panelSerialPortStatus = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonSetADCRefVoltage = new System.Windows.Forms.Button();
            this.textBoxRefADCVoltage = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetAutoScale = new System.Windows.Forms.ToolStripMenuItem();
            this.setMaxAxisYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sensor1Enable = new System.Windows.Forms.CheckBox();
            this.Sensor2Enable = new System.Windows.Forms.CheckBox();
            this.Sensor6Enable = new System.Windows.Forms.CheckBox();
            this.Sensor3Enable = new System.Windows.Forms.CheckBox();
            this.Sensor5Enable = new System.Windows.Forms.CheckBox();
            this.Sensor4Enable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.chart1.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart1.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.DimGray;
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisX.MajorGrid.Interval = 0D;
            chartArea5.AxisX.MinorGrid.Enabled = true;
            chartArea5.AxisX.Title = "Time (hour)";
            chartArea5.AxisY.LabelAutoFitMaxFontSize = 12;
            chartArea5.AxisY.LabelAutoFitMinFontSize = 10;
            chartArea5.AxisY.MajorGrid.Interval = 0D;
            chartArea5.AxisY.MajorTickMark.Interval = 0D;
            chartArea5.AxisY.Maximum = 6D;
            chartArea5.AxisY.MinorGrid.Enabled = true;
            chartArea5.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.Title = "Voltage (V)";
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.BackColor = System.Drawing.Color.White;
            chartArea5.BackSecondaryColor = System.Drawing.Color.White;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Far;
            legend5.DockedToChartArea = "ChartArea1";
            legend5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.IsTextAutoFit = false;
            legend5.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend5.Name = "Legend1";
            legend5.TextWrapThreshold = 50;
            legend5.TitleForeColor = System.Drawing.Color.BlanchedAlmond;
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(16, 21);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(658, 524);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Sensor Voltage (V)";
            title5.Text = "Sensor Voltage (V)";
            this.chart1.Titles.Add(title5);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AllowDrop = true;
            this.ButtonSave.Location = new System.Drawing.Point(15, 547);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(150, 23);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save Chart as png";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(189, 547);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // dataGridView1
            // 
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
            this.Column6});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(5, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(585, 398);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.buttonSaveAsXlxs);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 481);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gas Sensor Voltage (V)";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox7.Controls.Add(this.textBoxCount);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(326, 423);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(58, 52);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Count";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(6, 22);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(46, 20);
            this.textBoxCount.TabIndex = 0;
            this.textBoxCount.Text = "0";
            this.textBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox6.Controls.Add(this.buttonSetSampleTime);
            this.groupBox6.Controls.Add(this.textBoxSampleTime);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(171, 424);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(118, 52);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sample Time (s)";
            // 
            // buttonSetSampleTime
            // 
            this.buttonSetSampleTime.Location = new System.Drawing.Point(50, 20);
            this.buttonSetSampleTime.Name = "buttonSetSampleTime";
            this.buttonSetSampleTime.Size = new System.Drawing.Size(40, 23);
            this.buttonSetSampleTime.TabIndex = 1;
            this.buttonSetSampleTime.Text = "Set";
            this.buttonSetSampleTime.UseVisualStyleBackColor = true;
            this.buttonSetSampleTime.Click += new System.EventHandler(this.ButtonSetSampleTime_Click);
            // 
            // textBoxSampleTime
            // 
            this.textBoxSampleTime.Location = new System.Drawing.Point(24, 22);
            this.textBoxSampleTime.Name = "textBoxSampleTime";
            this.textBoxSampleTime.Size = new System.Drawing.Size(21, 20);
            this.textBoxSampleTime.TabIndex = 0;
            this.textBoxSampleTime.Text = "1";
            this.textBoxSampleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSaveAsXlxs
            // 
            this.buttonSaveAsXlxs.Location = new System.Drawing.Point(13, 423);
            this.buttonSaveAsXlxs.Name = "buttonSaveAsXlxs";
            this.buttonSaveAsXlxs.Size = new System.Drawing.Size(149, 23);
            this.buttonSaveAsXlxs.TabIndex = 8;
            this.buttonSaveAsXlxs.Text = "Save Data as xlxs";
            this.buttonSaveAsXlxs.UseVisualStyleBackColor = true;
            this.buttonSaveAsXlxs.Click += new System.EventHandler(this.ButtonSaveAsXlxs_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(510, 546);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(167, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear Chart and Data";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.Sensor5Enable);
            this.groupBox2.Controls.Add(this.Sensor4Enable);
            this.groupBox2.Controls.Add(this.Sensor6Enable);
            this.groupBox2.Controls.Add(this.Sensor3Enable);
            this.groupBox2.Controls.Add(this.Sensor2Enable);
            this.groupBox2.Controls.Add(this.Sensor1Enable);
            this.groupBox2.Controls.Add(this.lblMinYAxisPosition);
            this.groupBox2.Controls.Add(this.lblMaxYAxisPosition);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.buttonClearChart);
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Controls.Add(this.ButtonSave);
            this.groupBox2.Controls.Add(this.ButtonExit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(627, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 573);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graph";
            // 
            // lblMinYAxisPosition
            // 
            this.lblMinYAxisPosition.AutoSize = true;
            this.lblMinYAxisPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblMinYAxisPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinYAxisPosition.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMinYAxisPosition.Location = new System.Drawing.Point(55, 442);
            this.lblMinYAxisPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinYAxisPosition.Name = "lblMinYAxisPosition";
            this.lblMinYAxisPosition.Size = new System.Drawing.Size(58, 24);
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
            this.lblMaxYAxisPosition.Location = new System.Drawing.Point(55, 49);
            this.lblMaxYAxisPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxYAxisPosition.Name = "lblMaxYAxisPosition";
            this.lblMaxYAxisPosition.Size = new System.Drawing.Size(58, 24);
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
            this.buttonClearChart.Location = new System.Drawing.Point(322, 546);
            this.buttonClearChart.Name = "buttonClearChart";
            this.buttonClearChart.Size = new System.Drawing.Size(167, 23);
            this.buttonClearChart.TabIndex = 4;
            this.buttonClearChart.Text = "Clear Chart";
            this.buttonClearChart.UseVisualStyleBackColor = true;
            this.buttonClearChart.Click += new System.EventHandler(this.ButtonClearChart_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DiscardNull = true;
            this.serialPort1.ParityReplace = ((byte)(0));
            this.serialPort1.PortName = "COM10";
            this.serialPort1.ReadBufferSize = 8;
            this.serialPort1.ReceivedBytesThreshold = 9;
            this.serialPort1.WriteBufferSize = 64;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1325, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveToolStripMenuItem.Text = "Save Graph as Png File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version10ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // version10ToolStripMenuItem
            // 
            this.version10ToolStripMenuItem.Name = "version10ToolStripMenuItem";
            this.version10ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.version10ToolStripMenuItem.Text = "Gas Sensor GUI";
            this.version10ToolStripMenuItem.Click += new System.EventHandler(this.Version10ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // connectSerialPort
            // 
            this.connectSerialPort.Location = new System.Drawing.Point(84, 49);
            this.connectSerialPort.Name = "connectSerialPort";
            this.connectSerialPort.Size = new System.Drawing.Size(55, 23);
            this.connectSerialPort.TabIndex = 1;
            this.connectSerialPort.Text = "Connect";
            this.connectSerialPort.UseVisualStyleBackColor = true;
            this.connectSerialPort.Click += new System.EventHandler(this.ConnectSerialPort_Click);
            // 
            // disconnectSerialPort
            // 
            this.disconnectSerialPort.Location = new System.Drawing.Point(7, 49);
            this.disconnectSerialPort.Name = "disconnectSerialPort";
            this.disconnectSerialPort.Size = new System.Drawing.Size(75, 23);
            this.disconnectSerialPort.TabIndex = 2;
            this.disconnectSerialPort.Text = "Disconnect";
            this.disconnectSerialPort.UseVisualStyleBackColor = true;
            this.disconnectSerialPort.Click += new System.EventHandler(this.DisconnectSerialPort_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.labelSerialPortStatus);
            this.groupBox4.Controls.Add(this.panelSerialPortStatus);
            this.groupBox4.Location = new System.Drawing.Point(303, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 58);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // labelSerialPortStatus
            // 
            this.labelSerialPortStatus.AutoSize = true;
            this.labelSerialPortStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSerialPortStatus.Location = new System.Drawing.Point(30, 26);
            this.labelSerialPortStatus.Name = "labelSerialPortStatus";
            this.labelSerialPortStatus.Size = new System.Drawing.Size(61, 13);
            this.labelSerialPortStatus.TabIndex = 4;
            this.labelSerialPortStatus.Text = "Disconnect";
            // 
            // panelSerialPortStatus
            // 
            this.panelSerialPortStatus.BackColor = System.Drawing.Color.Red;
            this.panelSerialPortStatus.Location = new System.Drawing.Point(97, 19);
            this.panelSerialPortStatus.Name = "panelSerialPortStatus";
            this.panelSerialPortStatus.Size = new System.Drawing.Size(21, 23);
            this.panelSerialPortStatus.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.connectSerialPort);
            this.groupBox3.Controls.Add(this.disconnectSerialPort);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(3, 516);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 87);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox8.Location = new System.Drawing.Point(4, 8);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(144, 73);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Select Serial Port";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox5.Controls.Add(this.buttonSetADCRefVoltage);
            this.groupBox5.Controls.Add(this.textBoxRefADCVoltage);
            this.groupBox5.Location = new System.Drawing.Point(179, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(115, 52);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ADC Ref. Voltage";
            // 
            // buttonSetADCRefVoltage
            // 
            this.buttonSetADCRefVoltage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetADCRefVoltage.Location = new System.Drawing.Point(59, 20);
            this.buttonSetADCRefVoltage.Name = "buttonSetADCRefVoltage";
            this.buttonSetADCRefVoltage.Size = new System.Drawing.Size(40, 23);
            this.buttonSetADCRefVoltage.TabIndex = 1;
            this.buttonSetADCRefVoltage.Text = "Set";
            this.buttonSetADCRefVoltage.UseVisualStyleBackColor = true;
            this.buttonSetADCRefVoltage.Click += new System.EventHandler(this.ButtonSetADCRefVoltage_Click);
            // 
            // textBoxRefADCVoltage
            // 
            this.textBoxRefADCVoltage.Location = new System.Drawing.Point(12, 21);
            this.textBoxRefADCVoltage.Name = "textBoxRefADCVoltage";
            this.textBoxRefADCVoltage.Size = new System.Drawing.Size(33, 20);
            this.textBoxRefADCVoltage.TabIndex = 0;
            this.textBoxRefADCVoltage.Text = "5";
            this.textBoxRefADCVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItemSetAutoScale,
            this.setMaxAxisYToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "Clear Chart";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItemSetAutoScale
            // 
            this.toolStripMenuItemSetAutoScale.Name = "toolStripMenuItemSetAutoScale";
            this.toolStripMenuItemSetAutoScale.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemSetAutoScale.Text = "Set AutoScale";
            this.toolStripMenuItemSetAutoScale.Click += new System.EventHandler(this.ToolStripMenuItemSetAutoScale_Click);
            // 
            // setMaxAxisYToolStripMenuItem
            // 
            this.setMaxAxisYToolStripMenuItem.Name = "setMaxAxisYToolStripMenuItem";
            this.setMaxAxisYToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
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
            this.textBox1.Location = new System.Drawing.Point(476, 516);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(76, 76);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Clock Time";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.Width = 90;
            // 
            // SampleTime
            // 
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.SampleTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.SampleTime.HeaderText = "Time (min)";
            this.SampleTime.MinimumWidth = 6;
            this.SampleTime.Name = "SampleTime";
            this.SampleTime.Width = 80;
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
            // Sensor1Enable
            // 
            this.Sensor1Enable.AutoSize = true;
            this.Sensor1Enable.BackColor = System.Drawing.Color.Pink;
            this.Sensor1Enable.Checked = true;
            this.Sensor1Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensor1Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor1Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor1Enable.Location = new System.Drawing.Point(78, 528);
            this.Sensor1Enable.Name = "Sensor1Enable";
            this.Sensor1Enable.Size = new System.Drawing.Size(62, 17);
            this.Sensor1Enable.TabIndex = 7;
            this.Sensor1Enable.Text = "Sens 1";
            this.Sensor1Enable.UseVisualStyleBackColor = false;
            this.Sensor1Enable.CheckedChanged += new System.EventHandler(this.Sensor1Enable_CheckedChanged);
            // 
            // Sensor2Enable
            // 
            this.Sensor2Enable.AutoSize = true;
            this.Sensor2Enable.BackColor = System.Drawing.Color.Pink;
            this.Sensor2Enable.Checked = true;
            this.Sensor2Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensor2Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor2Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor2Enable.Location = new System.Drawing.Point(172, 528);
            this.Sensor2Enable.Name = "Sensor2Enable";
            this.Sensor2Enable.Size = new System.Drawing.Size(62, 17);
            this.Sensor2Enable.TabIndex = 8;
            this.Sensor2Enable.Text = "Sens 2";
            this.Sensor2Enable.UseVisualStyleBackColor = false;
            this.Sensor2Enable.CheckedChanged += new System.EventHandler(this.Sensor2Enable_CheckedChanged);
            // 
            // Sensor6Enable
            // 
            this.Sensor6Enable.AutoSize = true;
            this.Sensor6Enable.BackColor = System.Drawing.Color.Pink;
            this.Sensor6Enable.Checked = true;
            this.Sensor6Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensor6Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor6Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor6Enable.Location = new System.Drawing.Point(542, 528);
            this.Sensor6Enable.Name = "Sensor6Enable";
            this.Sensor6Enable.Size = new System.Drawing.Size(62, 17);
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
            this.Sensor3Enable.Location = new System.Drawing.Point(268, 528);
            this.Sensor3Enable.Name = "Sensor3Enable";
            this.Sensor3Enable.Size = new System.Drawing.Size(62, 17);
            this.Sensor3Enable.TabIndex = 9;
            this.Sensor3Enable.Text = "Sens 3";
            this.Sensor3Enable.UseVisualStyleBackColor = false;
            this.Sensor3Enable.CheckedChanged += new System.EventHandler(this.Sensor3Enable_CheckedChanged);
            // 
            // Sensor5Enable
            // 
            this.Sensor5Enable.AutoSize = true;
            this.Sensor5Enable.BackColor = System.Drawing.Color.Pink;
            this.Sensor5Enable.Checked = true;
            this.Sensor5Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensor5Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor5Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor5Enable.Location = new System.Drawing.Point(446, 528);
            this.Sensor5Enable.Name = "Sensor5Enable";
            this.Sensor5Enable.Size = new System.Drawing.Size(62, 17);
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
            this.Sensor4Enable.Location = new System.Drawing.Point(356, 528);
            this.Sensor4Enable.Name = "Sensor4Enable";
            this.Sensor4Enable.Size = new System.Drawing.Size(62, 17);
            this.Sensor4Enable.TabIndex = 11;
            this.Sensor4Enable.Text = "Sens 4";
            this.Sensor4Enable.UseVisualStyleBackColor = false;
            this.Sensor4Enable.CheckedChanged += new System.EventHandler(this.Sensor4Enable_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1325, 608);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gas Sensor GUI v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelSerialPortStatus;
        private System.Windows.Forms.Panel panelSerialPortStatus;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetAutoScale;
        private System.Windows.Forms.ToolStripMenuItem setMaxAxisYToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMaxYAxisPosition;
        private System.Windows.Forms.Label lblMinYAxisPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.CheckBox Sensor5Enable;
        private System.Windows.Forms.CheckBox Sensor4Enable;
        private System.Windows.Forms.CheckBox Sensor6Enable;
        private System.Windows.Forms.CheckBox Sensor3Enable;
        private System.Windows.Forms.CheckBox Sensor2Enable;
        private System.Windows.Forms.CheckBox Sensor1Enable;
    }
}

