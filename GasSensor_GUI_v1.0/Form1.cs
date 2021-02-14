using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.IO;
using System.Management;
using System.Text;

namespace GasSensor_GUI_v1._0
{

    public partial class Form1 : Form
    {
        delegate void UpdateChartCallback(float update_time, double YValue, int sensor_number);
        delegate void UpdateGridViewCallback(double sample_time_grid, double[] Value,
                                            int current_row, int sensor_number);
        delegate void CloseUartCallback(int i);
        System.Threading.Thread CloseDown;
        // Timer timer = timer1;
        float time = 0, count = 0;
        float prev_time = 0;

        int maxGridViewRow = 10, row_number = 0;
        int addrow_gridview = 0;
        int current_gridviewrow_sensor1 = 0;
        int current_gridviewrow_sensor2 = 0;
        int current_gridviewrow_sensor3 = 0;
        int current_gridviewrow_sensor4 = 0;
        int zoom = 0;
        float zoom_size = 20f;
        //List<Double> value=new List<Double>();
        double[] value = new double[8];// = 0, value2 = 0, value3 = 0, value4 = 0;
        double refADCVoltage = 5;
        private Thread trd;
        private readonly Queue<float> _queue_time = new Queue<float>();
        private readonly Queue<float> _queue_prev_time = new Queue<float>();
        int graphUpdate = 0;

        List<List<Double>> tableData = new List<List<Double>>();
        List<Double> rowData = new List<Double>();

        List<List<String>> tableData_ClockTime = new List<List<String>>();
        List<String> rowData_ClockTime = new List<String>();
        List<String> outputCsvList = new List<String>();
        string gridViewData;
        int columnCount, numOfSample = 1;


        /*
        DIG_T1: unsigned short
        DIG_T2/3: signed short
        */

        double dig_T1;
        double dig_T2, dig_T3;


        //// humidity compensation data
        ////unsigned char: 8-bit
        double dig_H1, dig_H3;
        // signed short: 16-bit
        double dig_H2, dig_H4, dig_H5, dig_H6;
        Int32 t_fine;
        

        private void ThreadTask()
        {
            //var startTimeSpan = TimeSpan.Zero;
            //var periodTimeSpan = TimeSpan.FromSeconds(10);
            float inThreadTime = 0, inThreadPrevTime = 0;
            if (_queue_time.Count > 0)
            {
                inThreadTime = _queue_time.Dequeue();
                if (_queue_time.Count > 0)
                    inThreadPrevTime = _queue_prev_time.Dequeue();
                //var timer = new System.Threading.Timer((e) =>
                //{
                //    MyMethod();
                //}, null, startTimeSpan, periodTimeSpan);
                //// this.Invoke(new Action(() => { buttonClearChart.Click(object sender, EventArgs e); }));

                //UpdateChart((float)inThreadPrevTime + inThreadTime  / 60, value[0], 1);
                //UpdateChart((float)inThreadPrevTime + inThreadTime   / 60, value[1], 2);
                //UpdateChart((float)inThreadPrevTime + inThreadTime / 60, value[2], 3);
                //UpdateChart((float)inThreadPrevTime + inThreadTime  / 60, value[3], 4);
                //UpdateGridView((float)inThreadPrevTime + inThreadTime  / 60, value[0], value[1], value[2], value[3], 0, 0);

            }
        }
        //public void MyMethod()
        //{
        //    UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[0], 1);
        //    UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[1], 2);
        //    UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[2], 3);
        //    UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[3], 4);
        //}
        SerialPort _uart;
        TextBox tb = new TextBox();
        TextBox tb_minYAxis = new TextBox();

        public Form1()
        {
            InitializeComponent();
            chart1.Controls.Add(lblMaxYAxisPosition);
            chart1.Controls.Add(lblMinYAxisPosition);

            //chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            //chart1.Cursor = Cursors.IBeam;
            _uart = serialPort1;
            // _uart = new SerialPort() ;
            //_uart.BaudRate = 115200;
            //_uart.Parity = Parity.None;
            //_uart.StopBits = StopBits.One;
            //_uart.DataBits = 8;
            //_uart.Handshake = Handshake.None;
            //_uart.RtsEnable = true;
            _uart.DataReceived += _uart_DataReceived;
            //chart1.Titles = "Sensor Voltage (V)";
            chart1.Series.Add("Sensor 1");
            chart1.Series.Add("Sensor 2");
            chart1.Series.Add("Sensor 3");
            chart1.Series.Add("Sensor 4");
            chart1.Series.Add("Sensor 5");
            chart1.Series.Add("Sensor 6");
            chart1.Series["Sensor 1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sensor 1"].BorderDashStyle = ChartDashStyle.Dash;
            chart1.Series["Sensor 1"].BorderWidth = 3;

            chart1.Series["Sensor 2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sensor 2"].BorderWidth = 3;

            chart1.Series["Sensor 3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sensor 3"].BorderWidth = 3;
            chart1.Series["Sensor 3"].BorderDashStyle = ChartDashStyle.DashDotDot;
            chart1.Series["Sensor 3"].MarkerStyle = MarkerStyle.Diamond;

            chart1.Series["Sensor 4"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sensor 4"].BorderWidth = 3;

            chart1.Series["Sensor 5"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sensor 5"].BorderWidth = 3;

            chart1.Series["Sensor 6"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sensor 6"].BorderDashStyle = ChartDashStyle.DashDotDot;
            chart1.Series["Sensor 6"].MarkerStyle = MarkerStyle.Diamond;
            chart1.Series["Sensor 6"].MarkerBorderWidth = 3;
            chart1.Series["Sensor 6"].BorderWidth = 3;
            //chart1.Series["Sensor 1"].Points.AddXY(1, 2);
            //chart1.Series["Sensor 1"].Points.AddXY(3, 4);
            chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.MinorGrid.Interval = 0.1;
            //chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 0.1;

            chart1.ChartAreas[0].AxisX.Maximum = double.NaN;
            ChartArea ca = chart1.ChartAreas[0];

            Axis ax = ca.AxisX;
            Axis ay = ca.AxisY;
            ay.MajorGrid.Interval = 0.5;
            ay.MajorTickMark.Interval = 1;
            ax.LabelStyle.Format = "0.0000";
            chart1.Series[0].ChartType = SeriesChartType.FastLine;

            chart1.MouseClick += mouseDownEvent;
            chart1.MouseWheel += mouseWheel;
            GetSerialPortName();
            // Instantiate the output CSV Header .
            InstantiateCSVHeader();

        }

        private void InstantiateCSVHeader()
        {
            columnCount = dataGridView1.Columns.Count;
            string columnNames = "";
            //string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
            for (int i = 0; i < columnCount; i++)
            {
                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
            }
            gridViewData += columnNames;

            outputCsvList.Add(gridViewData);
        }

        public void GetSerialPortName()
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBox1.Text = port;
                comboBox1.Items.Add(port);
            }
        }
        public void mouseWheel(object sender, MouseEventArgs e)
        {
            zoom_size = (float)chart1.ChartAreas[0].AxisX.Maximum;
            if (e.Delta > 0)
            {
                zoom++;
                if (chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - zoom_size / (zoom) > 0)
                {
                    chart1.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - zoom_size / (zoom);
                }
                //else
                //{
                //    chart1.ChartAreas[0].AxisX.Minimum = 0;
                //}
                chart1.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + zoom_size / (zoom);
                //  Console.WriteLine(Convert.ToString(chart1.ChartAreas[0].CursorX.Position));
                Console.WriteLine(Convert.ToString(e.Location.X));

            }
            else
            {
                zoom--;
                if (zoom > 0)
                {
                    if (chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - zoom_size / (zoom) > 0)
                    {
                        chart1.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - zoom_size / (zoom);
                    }
                    chart1.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + zoom_size / (zoom);
                    Console.WriteLine(Convert.ToString(e.Location.X));

                }
                else
                {
                    zoom = 0;
                    chart1.ChartAreas[0].AxisX.Minimum = 0;
                    chart1.ChartAreas[0].AxisX.Maximum = Double.NaN;
                }
            }

        }
        public async void mouseDownEvent(object sender, EventArgs e)

        {

            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                await Task.Run(() => UpdateChart1());
                //chart1.ContextMenuStrip = contextMenuStrip1;
            }
        }
        private async void UpdateChart1()
        {
            chart1.ContextMenuStrip = contextMenuStrip1;
        }
        private void _uart_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string serialPortReceiveddata;
            string realValue_serialPortReceivedData;
            serialPortReceiveddata = _uart.ReadLine();
            //realExistingValue_serialPortReceivedData = _uart.ReadExisting();
            //richTextBox1.Text = serialPortReceiveddata;
            if (serialPortReceiveddata != null)
            {
                realValue_serialPortReceivedData = serialPortReceiveddata.Substring(1, serialPortReceiveddata.Length - 1);
                //  uController encoder
                //  ASCII 1 denotes sensor #1 data
                //  ASCII 2 denotes sensor #2 data
                //  ASCII 3 demotes sensor #3 data
                //  ASCII 4 denotes sensor #4 data
                //  DataPoint datapoint = new DataPoint(0, Convert.ToDouble(realValue_serialPortReceivedData));
                //  data is received every second.
                if (serialPortReceiveddata[0] == '1')
                {
                    Console.WriteLine("Data from sensor 1");
                    Console.WriteLine(serialPortReceiveddata);
                    Console.WriteLine(realValue_serialPortReceivedData + "(V)");
                    //Console.WriteLine(realExistingValue_serialPortReceivedData);
                    //chart1.Series["Sensor 1"].Points.AddXY(time/60, Convert.ToDouble(realValue_serialPortReceivedData));
                    value[0] = Convert.ToDouble(realValue_serialPortReceivedData);
                    value[0] = value[0] / 5 * refADCVoltage;
                    //current_gridviewrow_sensor1++;
                    //current_gridviewrow_sensor1++;
                    //DataGridViewRow gridviewrow = (DataGridViewRow) dataGridView1.Rows[0].Clone();
                    addrow_gridview = 1;
                    //gridviewrow.Cells[0].Value = 1;
                    //dataGridView1.Rows.Add(gridviewrow);
                    // chart1.Series.
                }
                else if (serialPortReceiveddata[0] == '2')
                {
                    Console.WriteLine("Data from sensor 2");
                    Console.WriteLine(serialPortReceiveddata);
                    Console.WriteLine(realValue_serialPortReceivedData + "(V)");
                    // chart1.Series["Sensor 2"].Points.AddXY(time / 60, Convert.ToDouble(realValue_serialPortReceivedData));
                    //UpdateChart(time / 60, Convert.ToDouble(realValue_serialPortReceivedData), 2);
                    value[1] = Convert.ToDouble(realValue_serialPortReceivedData);
                    value[1] = value[1] / 5 * refADCVoltage;

                    //current_gridviewrow_sensor2++;
                    addrow_gridview = 2;

                }
                else if (serialPortReceiveddata[0] == '3')
                {
                    Console.WriteLine("Data from sensor 3");
                    Console.WriteLine(serialPortReceiveddata);
                    Console.WriteLine(realValue_serialPortReceivedData + "(V)");
                    // chart1.Series["Sensor 3"].Points.AddXY(time / 60, Convert.ToDouble(realValue_serialPortReceivedData));
                    //UpdateChart(time / 60, Convert.ToDouble(realValue_serialPortReceivedData), 3);
                    value[2] = Convert.ToDouble(realValue_serialPortReceivedData);
                    value[2] = value[2] / 5 * refADCVoltage;

                    //current_gridviewrow_sensor3++;
                    addrow_gridview = 3;
                }
                else if (serialPortReceiveddata[0] == '4')
                {
                    Console.WriteLine("Data from sensor 4");
                    Console.WriteLine(serialPortReceiveddata);
                    Console.WriteLine(realValue_serialPortReceivedData + "(V)");
                    //chart1.Series["Sensor 1"].Points.AddXY(time / 60, Convert.ToDouble(realValue_serialPortReceivedData));
                    //UpdateChart(time / 60, Convert.ToDouble(realValue_serialPortReceivedData), 4);
                    value[3] = Convert.ToDouble(realValue_serialPortReceivedData);
                    value[3] = value[3] / 5 * refADCVoltage;

                    //current_gridviewrow_sensor4++;
                    addrow_gridview = 4;
                }
                else if (serialPortReceiveddata[0] == '5')
                {
                    Console.WriteLine("Data from sensor 5");
                    Console.WriteLine(serialPortReceiveddata);
                    Console.WriteLine(realValue_serialPortReceivedData + "(V)");
                    //chart1.Series["Sensor 1"].Points.AddXY(time / 60, Convert.ToDouble(realValue_serialPortReceivedData));
                    //UpdateChart(time / 60, Convert.ToDouble(realValue_serialPortReceivedData), 4);
                    value[4] = Convert.ToDouble(realValue_serialPortReceivedData);
                    value[4] = value[4] / 5 * refADCVoltage;

                    //current_gridviewrow_sensor4++;
                    addrow_gridview = 5;
                }
                else if (serialPortReceiveddata[0] == '6')
                {
                    Console.WriteLine("Data from sensor 6");
                    Console.WriteLine(serialPortReceiveddata);
                    Console.WriteLine(realValue_serialPortReceivedData + "(V)");
                    //chart1.Series["Sensor 1"].Points.AddXY(time / 60, Convert.ToDouble(realValue_serialPortReceivedData));
                    //UpdateChart(time / 60, Convert.ToDouble(realValue_serialPortReceivedData), 4);
                    value[5] = Convert.ToDouble(realValue_serialPortReceivedData);
                    value[5] = value[5] / 5 * refADCVoltage;

                    //current_gridviewrow_sensor4++;
                    addrow_gridview = 6;
                }
                else if (serialPortReceiveddata[0] == 'U')
                {
                    Console.WriteLine("Data from Humidity Sensor");
                    Console.WriteLine(serialPortReceiveddata);
                    Console.WriteLine(realValue_serialPortReceivedData + "(V)");
                    //chart1.Series["Sensor 1"].Points.AddXY(time / 60, Convert.ToDouble(realValue_serialPortReceivedData));
                    //UpdateChart(time / 60, Convert.ToDouble(realValue_serialPortReceivedData), 4);
                    value[6] = Convert.ToDouble(realValue_serialPortReceivedData);
                    //value[5] = value[5] / 5 * refADCVoltage;

                    //current_gridviewrow_sensor4++;
                    //addrow_gridview = 6;
                }
                // For compensation data
                else
                {

                    /*
                    DIG_T1: unsigned short
                    DIG_T2/3: signed short
                    */

                    //unsigned short dig_T1;
                    //signed short dig_T2, dig_T3;


                    //// humidity compensation data
                    ////unsigned char: 8-bit
                    //unsigned char dig_H1 = 0x89, dig_H3;
                    //// signed short: 16-bit
                    //signed short dig_H2 = 0xF911, dig_H4 = 0x1234, dig_H5;
                    realValue_serialPortReceivedData = serialPortReceiveddata.Substring(3, serialPortReceiveddata.Length - 1);

                    // temperature compensation data
                    if (serialPortReceiveddata[0] == 'T')
                    {
                        switch (serialPortReceiveddata[1])
                        {
                            //  dig_T1
                            case '1':
                                if (serialPortReceiveddata[2] == 'N')
                                {
                                    dig_T1 = (-1) * Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                else if (serialPortReceiveddata[2] == 'P')
                                {
                                    dig_T1 = Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                break;
                            //  dig_T1
                            case '2':
                                if (serialPortReceiveddata[2] == 'N')
                                {
                                    dig_T2 = (-1) * Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                else if (serialPortReceiveddata[2] == 'P')
                                {
                                    dig_T2 = Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                break;

                            //  dig_T1
                            case '3':
                                if (serialPortReceiveddata[2] == 'N')
                                {
                                    dig_T3 = (-1) * Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                else if (serialPortReceiveddata[2] == 'P')
                                {
                                    dig_T3 = Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                break;


                        }
                    }
                    if (serialPortReceiveddata[0] == 'H')
                    {
                        switch (serialPortReceiveddata[1])
                        {
                            //  dig_T1
                            case '1':
                                if (serialPortReceiveddata[2] == 'N')
                                {
                                    dig_H1 = (-1) * Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                else if (serialPortReceiveddata[2] == 'P')
                                {
                                    dig_H1 = Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                break;
                            //  dig_T1
                            case '2':
                                if (serialPortReceiveddata[2] == 'N')
                                {
                                    dig_H2 = (-1) * Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                else if (serialPortReceiveddata[2] == 'P')
                                {
                                    dig_H2 = Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                break;

                            //  dig_T1
                            case '3':
                                if (serialPortReceiveddata[2] == 'N')
                                {
                                    dig_H3 = (-1) * Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                else if (serialPortReceiveddata[2] == 'P')
                                {
                                    dig_H3 = Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                break;
                            //  dig_T1
                            case '4':
                                if (serialPortReceiveddata[2] == 'N')
                                {
                                    dig_H4 = (-1) * Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                else if (serialPortReceiveddata[2] == 'P')
                                {
                                    dig_H4 = Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                break;
                            //  dig_T1
                            case '5':
                                if (serialPortReceiveddata[2] == 'N')
                                {
                                    dig_H5 = (-1) * Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                else if (serialPortReceiveddata[2] == 'P')
                                {
                                    dig_H5 = Convert.ToDouble(realValue_serialPortReceivedData);
                                }
                                break;


                        }
                    }

                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = saveFileDialog1;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(saveFile.FileName, ChartImageFormat.Png);
            }

            //if(saveFile.save)
        }



        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            // chart1.SaveImage("123", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Version10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prompt.ShowDialog("This is Gas Sensor GUI\nVersion 2.0", "Feb2021");
        }

        private void ConnectSerialPort_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            try
            {
                if (!_uart.IsOpen)
                {
                    _uart.PortName = comboBox1.Text;
                    _uart.Open();
                }
                if (_uart.IsOpen)
                {
                    labelSerialPortStatus.Text = "Connected";
                    labelSerialPortStatus.BackColor = Color.Lime;
                    panelSerialPortStatus.BackColor = Color.Lime;
                }
                else
                {
                    labelSerialPortStatus.Text = "Disconnected";
                    labelSerialPortStatus.BackColor = Color.Red;
                    panelSerialPortStatus.BackColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                timer1.Enabled = false;

                MessageBox.Show("Your Serial Port is invalid");

            }

        }

        private void DisconnectSerialPort_Click(object sender, EventArgs e)
        {
            CloseDown = new System.Threading.Thread(new System.Threading.ThreadStart(CloseSerialOnExit));


            CloseDown.Start();
            timer1.Enabled = false;

            labelSerialPortStatus.Text = "Disconnected";
            labelSerialPortStatus.BackColor = Color.Red;
            panelSerialPortStatus.BackColor = Color.Red;



        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = saveFileDialog1;
            if (sv.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(sv.FileName, ChartImageFormat.Png);
            }

        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void ButtonSaveAsXlxs_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.csv)|*.csv";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var stream = File.CreateText(dlg.FileName + ".csv"))
                {
                    try
                    {

                        //for (int i = 1; (i) < dataGridView1.Rows.Count; i++)
                        //{
                        //    for (int j = 0; j < columnCount; j++)
                        //    {
                        //        outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                        //    }
                        //}
                        //foreach(var lineText in outputCsvList)
                        File.WriteAllLines(dlg.FileName, outputCsvList);


                        MessageBox.Show("Data Exported Successfully !!!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }

                }

            }
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            time++;
            count++;

            rowData.Clear();

            rowData.Add((float)prev_time + time * (timer1.Interval / 1000) / 60);
            rowData.Add(value[0]);
            rowData.Add(value[1]);
            rowData.Add(value[2]);
            rowData.Add(value[3]);
            rowData.Add(value[4]);
            rowData.Add(value[5]);
            rowData_ClockTime.Add(DateTime.Now.ToString("HH:mm:ss MM/dd/yy"));
            // Dimension=#row*(5 columns);
            tableData_ClockTime.Add(rowData_ClockTime);
            //tableData.Add(rowData);
            tableData.Add(rowData);

            if (time > 4)
                textBox1.Text = tableData[1][1].ToString();
            await Task.Run(() => UpdateChartAndGrid());


        }
        private async void UpdateChartAndGrid()
        {

            await Task.Run(() => UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[0], 1));
            await Task.Run(() => UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[1], 2));
            await Task.Run(() => UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[2], 3));
            await Task.Run(() => UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[3], 4));
            await Task.Run(() => UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[4], 5));
            await Task.Run(() => UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[5], 6));

            //addrow_gridview = 0;

            await Task.Run(() => UpdateGridView((float)prev_time + time * (timer1.Interval / 1000) / 60, value, 0, 0));

        }

        private void UpdateChart(float update_time, double YValue, int sensor_number)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.chart1.InvokeRequired)
            {
                UpdateChartCallback d = new UpdateChartCallback(UpdateChart);
                this.Invoke(d, new object[] { update_time, YValue, sensor_number });
            }
            else
            {
                if (sensor_number == 1)
                    chart1.Series["Sensor 1"].Points.AddXY((update_time / 60), YValue);
                else if (sensor_number == 2)
                    chart1.Series["Sensor 2"].Points.AddXY((update_time / 60), YValue);

                else if (sensor_number == 3)
                    chart1.Series["Sensor 3"].Points.AddXY((update_time / 60), YValue);

                else if (sensor_number == 4)
                    chart1.Series["Sensor 4"].Points.AddXY((update_time / 60), YValue);

                else if (sensor_number == 5)
                    chart1.Series["Sensor 5"].Points.AddXY((update_time / 60), YValue);

                else if (sensor_number == 6)
                    chart1.Series["Sensor 6"].Points.AddXY((update_time / 60), YValue);

            }
        }

        private void UpdateGridView(double sample_time_grid, double[] Value, int current_row, int sensor_number)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            try
            {
                if (dataGridView1.InvokeRequired)
                {
                    UpdateGridViewCallback d = new UpdateGridViewCallback(UpdateGridView);
                    this.Invoke(d, new object[] { sample_time_grid, Value, current_row, sensor_number });
                }
                //DataGridViewRow gridviewrow = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                //gridviewrow.Cells[0].Value = 1;
                //dataGridView1.Rows.Add(gridviewrow);
                else
                {

                    row_number++;
                    if (row_number > 10)
                    {
                        for (int row = 10; row >= 1; row--)
                        {
                            for (int col = dataGridView1.ColumnCount - 1; col >= 0; col--)
                            {
                                dataGridView1.Rows[row].Cells[col].Value = dataGridView1.Rows[row - 1].Cells[col].Value;
                            }
                        }

                    }
                    else
                    {
                        dataGridView1.Rows.Add(); //Inserting first row if yet there is no row, first row number is '0'
                        for (int row = row_number; row >= 1; row--)
                        {
                            for (int col = dataGridView1.ColumnCount - 1; col >= 0; col--)
                            {
                                dataGridView1.Rows[row].Cells[col].Value = dataGridView1.Rows[row - 1].Cells[col].Value;
                            }
                        }
                    }
                    dataGridView1.Rows[0].Cells[0].Value = DateTime.Now.ToString("HH:mm:ss MM/dd/yy");

                    dataGridView1.Rows[0].Cells[1].Value = sample_time_grid;
                    dataGridView1.Rows[0].Cells[2].Value = Value[0];
                    dataGridView1.Rows[0].Cells[3].Value = Value[1];
                    dataGridView1.Rows[0].Cells[4].Value = Value[2];
                    dataGridView1.Rows[0].Cells[5].Value = Value[3];
                    dataGridView1.Rows[0].Cells[6].Value = Value[4];
                    dataGridView1.Rows[0].Cells[7].Value = Value[5];
                    try
                    {
                        gridViewData = null;
                        for (int j = 0; j < columnCount; j++)
                        {
                            gridViewData += dataGridView1.Rows[0].Cells[j].Value.ToString() + ",";
                        }
                        outputCsvList.Add(gridViewData);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }

                }
            }
            catch (IOException)
            {

            }



        }

        private async void ButtonClear_Click(object sender, EventArgs e)
        {

            chart1.Series["Sensor 1"].Points.Clear();
            chart1.Series["Sensor 2"].Points.Clear();
            chart1.Series["Sensor 3"].Points.Clear();
            chart1.Series["Sensor 4"].Points.Clear();
            chart1.Series["Sensor 5"].Points.Clear();
            chart1.Series["Sensor 6"].Points.Clear();
            dataGridView1.Rows.Clear();
            row_number = 0;
            time = 0;
            prev_time = 0;
        }

        private void ButtonSetADCRefVoltage_Click(object sender, EventArgs e)
        {
            refADCVoltage = Convert.ToDouble(textBoxRefADCVoltage.Text);
            textBoxRefADCVoltage.Text = "OK";

        }

        private void ButtonSetSampleTime_Click(object sender, EventArgs e)
        {
            try
            {
                prev_time = prev_time + time * (timer1.Interval / 1000) / 60;
                timer1.Interval = (Int32)Convert.ToDouble(textBoxSampleTime.Text) * 1000;
                time = 0;
            }
            catch (IOException)
            {

            }
        }



        private void ButtonClearChart_Click(object sender, EventArgs e)
        {
            chart1.Series["Sensor 1"].Points.Clear();
            chart1.Series["Sensor 2"].Points.Clear();
            chart1.Series["Sensor 3"].Points.Clear();
            chart1.Series["Sensor 4"].Points.Clear();
            chart1.Series["Sensor 5"].Points.Clear();
            chart1.Series["Sensor 6"].Points.Clear();
        }

        private async void ToolStripMenuItemSetAutoScale_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = double.NaN;
        }

        //private int DoThis()
        //{
        //    for (int i = 0; i != 10000000; ++i) { }
        //    return 42;
        //}

        //public async void ButtonClick(object sender, EventArgs e)
        //{
        //    await Task.Run(() => DoThis());
        //}

        public async void SetMaxAxisYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Prompt1.ShowDialog("Max AxisY", "Set AxisY MaxMin", chart1));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //TextBox YAxisMaxValue = new TextBox();

        }




        private void OnMouseLeave_lblMaxYPosition(object sender, EventArgs e)
        {
            lblMaxYAxisPosition.Cursor = Cursors.Default;
        }

        private void MaxYAxisPosition_Click(object sender, MouseEventArgs e)
        {
            lblMaxYAxisPosition.Cursor = Cursors.IBeam;
            tb.Visible = true;

            //tb.Location = chart1.Location;
            //tb.Location = new System.Drawing.Point(94, 93);
            tb.Width = 35;
            chart1.Controls.Add(tb);
            tb.BringToFront();
            tb.Location = lblMaxYAxisPosition.Location;
            //tb.Location = new Point((int)chart1.ChartAreas[0].Position.X, (int) chart1.ChartAreas[0].Position.Y);


            tb.KeyDown += new KeyEventHandler(tb_KeyDown);
            //TextBox YAxisMaxValue = new TextBox();
            //Console.WriteLine("TextBOX");
            //YAxisMaxValue.Location=lblMaxYAxisPosition.Location;
        }
        public void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Double d = Double.Parse(this.tb.Text);
                    if (CheckMaxMinValue(d, chart1.ChartAreas[0].AxisY.Minimum))
                    {
                        chart1.ChartAreas[0].AxisY.Maximum = Double.Parse(this.tb.Text);
                        tb.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Your max voltage value is not valid");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Your max voltage value is not valid");
                }
            }

        }

        private void MouseDoubleClick_MinYAxis(object sender, MouseEventArgs e)
        {
            lblMinYAxisPosition.Cursor = Cursors.IBeam;
            tb_minYAxis.Visible = true;

            //tb.Location = chart1.Location;
            //tb.Location = new System.Drawing.Point(94, 93);
            tb_minYAxis.Width = 35;
            chart1.Controls.Add(tb_minYAxis);
            tb_minYAxis.BringToFront();
            tb_minYAxis.Location = lblMinYAxisPosition.Location;
            //tb.Location = new Point((int)chart1.ChartAreas[0].Position.X, (int) chart1.ChartAreas[0].Position.Y);


            tb_minYAxis.KeyDown += new KeyEventHandler(tb_MinYAxis_KeyDown
                );
            //TextBox YAxisMaxValue = new TextBox();
            //Console.WriteLine("TextBOX");
            //YAxisMaxValue.Location=lblMaxYAxisPosition.Location;
        }
        public void tb_MinYAxis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Double d = Double.Parse(this.tb_minYAxis.Text);
                    if (CheckMaxMinValue(chart1.ChartAreas[0].AxisY.Maximum, d))
                    {
                        chart1.ChartAreas[0].AxisY.Minimum = Double.Parse(this.tb_minYAxis.Text);
                        tb_minYAxis.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Your min voltage value is not valid");

                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Your min voltage value is not valid");
                }


            }

        }
        public bool CheckMaxMinValue(double maxValue, double minValue)
        {
            return maxValue > minValue;
        }

        private void Sensor1Enable_CheckedChanged(object sender, EventArgs e)
        {

            chart1.Series["Sensor 1"].Enabled = Sensor1Enable.Checked;
            dataGridView1.Columns[1 + 1].Visible = Sensor1Enable.Checked;

        }

        private void Sensor2Enable_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Sensor 2"].Enabled = Sensor2Enable.Checked;
            dataGridView1.Columns[1 + 2].Visible = Sensor2Enable.Checked;

        }

        private void Sensor3Enable_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Sensor 3"].Enabled = Sensor3Enable.Checked;
            dataGridView1.Columns[1 + 3].Visible = Sensor3Enable.Checked;

        }

        private void Sensor4Enable_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Sensor 4"].Enabled = Sensor4Enable.Checked;
            dataGridView1.Columns[1 + 4].Visible = Sensor4Enable.Checked;

        }

        private void Sensor5Enable_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Sensor 5"].Enabled = Sensor5Enable.Checked;
            dataGridView1.Columns[1 + 5].Visible = Sensor5Enable.Checked;

        }

        private void Sensor6Enable_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Sensor 6"].Enabled = Sensor6Enable.Checked;
            dataGridView1.Columns[1 + 6].Visible = Sensor6Enable.Checked;

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chart1.Series["Sensor 1"].Points.Clear();
            chart1.Series["Sensor 2"].Points.Clear();
            chart1.Series["Sensor 3"].Points.Clear();
            chart1.Series["Sensor 4"].Points.Clear();
        }

        private void CloseSerialOnExit()
        {

            try
            {
                _uart.DtrEnable = false;
                _uart.RtsEnable = false;
                _uart.DiscardInBuffer();
                _uart.DiscardOutBuffer();
                _uart.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        double CompensateTemperature(Int32 adc_T)
        {
            double var1, var2, T;

            var1 = (double)adc_T / 16384.0f - dig_T1 / 1024.0 * dig_T2;
            var2 =(     (( (double)adc_T )/ 131072.0f - ((double)dig_T1 )/ 8192.0 * dig_T2)*
                (((double) adc_T)/131072.0f- ((double)dig_T1) / 8192.0)  )* ((double)dig_T3);
            t_fine = (Int32)(var1 + var2);
            return (double)(var1 + var2) / 5120.0f;
        }

        double CompensateHumidity(Int32 adc_H)
        {
            double var_H;

            var_H = (double)(t_fine - 76800.0f);


            var_H = (adc_H - (((double)dig_H4) * 64.0f + ((double)dig_H5) / 16384.0f * var_H)) *
                (((double)dig_H2) / 65536.0f * (1.0 + ((double)dig_H6) / 67108864.0f * var_H * (1.0f + ((double)dig_H3) / 67108864.0f * var_H)));

            var_H = var_H * (1.0 - ((double)dig_H1) * var_H / 524288.0f);

            if (var_H > 100)
                var_H = 100;
            else if (var_H < 0)
                var_H = 0;

            return var_H;
        }

            //double CompensatePressure(Int32 adc_P)
            //{
            //    double var1,var2,p;
            //    var1 = ((double)t_fine / 2.0f) - 64000.0f;
            //    var2 = var1 * var1 * ((double)dig_P6) / 32768.0f;
            //    var2 = var2 + var1 * ((double)dig_P5) * 2.0f;

            //    var2 = (var2) / 4 + (((double)dig_P4) * 65536.0f);
            //    var1 = (((double)dig_P3 * var1 * var1 / 524288.0f + ((double)dig_P2) * var1) / 524288.0f);
            //    var1 = (1.0 + var1 / 32768.0) * ((double)dig_P1);

            //    if (var1 == 0)
            //        return 0;
            //    p = 1048576.0 - (double)adc_P;
            //    p = (p - (var2 / 4096.0)) * 6250.0 / var1;
            //    var1 = ((double)dig_P9 * p * p) / 2147483648.0f;
            //    var2 = p * ((double)dig_P8 / 32768.0f);

            //    p = p + (var1 + var2 + ((double)dig_P7)) / 16.0f;
            //    return p;

            //}
        }

    public static class Prompt
    {
        public static void ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 250,
                Height = 100,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.AliceBlue
            };
            Label textLabel = new Label() { Left = 60, Top = 15, Text = text, Width = 150, Height = 100 };
            //TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            //prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
            return;// prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }


    public static class Prompt1
    {
        public static void ShowDialog(string text, string caption, Chart chart)
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 140,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabelMaxAxisY = new Label() { Left = 30, Top = 20, Text = text };
            TextBox textBoxMaxAxisY = new TextBox() { Left = 90, Top = 20, Width = 40, Text = "5" };
            Button confirmation = new Button() { Text = "Ok", Left = 30, Width = 100, Top = 70, DialogResult = DialogResult.OK };

            Label textLabelMinAxisY = new Label() { Left = 30, Top = 40, Text = "Min AxisY" };
            TextBox textBoxMinAxisY = new TextBox() { Left = 90, Top = 40, Width = 40, Text = "0" };


            confirmation.Click += (sender, e) => {
                try
                {
                    chart.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(textBoxMaxAxisY.Text);
                    chart.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(textBoxMinAxisY.Text);
                }
                catch (Exception)
                {
                }

                prompt.Close(); };
            prompt.Controls.Add(textBoxMaxAxisY);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabelMaxAxisY);

            prompt.Controls.Add(textBoxMinAxisY);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabelMinAxisY);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();

            return; //prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }

}
