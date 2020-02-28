﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace GasSensor_GUI_v1._0
{
    
    public partial class Form1 : Form
    {
        delegate void UpdateChartCallback(float update_time, double YValue,int sensor_number);
        delegate void UpdateGridViewCallback(double sample_time_grid,double Value1, double Value2, double Value3, double Value4,
                                            int current_row, int sensor_number);
        delegate void CloseUartCallback(int i);
        System.Threading.Thread CloseDown;
        // Timer timer = timer1;
        float time = 0, count = 0;
        float prev_time=0;

        int maxGridViewRow = 10,row_number=0;
        int addrow_gridview = 0;
        int current_gridviewrow_sensor1 = 0;
        int current_gridviewrow_sensor2 = 0;
        int current_gridviewrow_sensor3 = 0;
        int current_gridviewrow_sensor4 = 0;
        int zoom = 0;
        float zoom_size = 20f;
        double[] value=new double[4];// = 0, value2 = 0, value3 = 0, value4 = 0;
        double refADCVoltage = 5;

        SerialPort _uart;
        public Form1()
        {
            InitializeComponent();
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

            chart1.Series["Sensor 1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sensor 1"].BorderDashStyle = ChartDashStyle.Dash;
            chart1.Series["Sensor 1"].BorderWidth = 3;

            chart1.Series["Sensor 2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sensor 2"].BorderWidth = 3;

            chart1.Series["Sensor 3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sensor 3"].BorderWidth = 3;

            chart1.Series["Sensor 4"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sensor 4"].BorderDashStyle = ChartDashStyle.DashDotDot;
            chart1.Series["Sensor 4"].MarkerStyle = MarkerStyle.Diamond;
            chart1.Series["Sensor 4"].MarkerBorderWidth = 3;
            chart1.Series["Sensor 4"].BorderWidth = 3;
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
            //chart1.ChartAreas[0].AxisY.MajorGrid.
            //DataGridViewRow gridviewrow = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            //chart1.ChartAreas[0].AxisY.MajorGrid. = 10;
            //gridviewrow.Cells[0].Value = 1;
            //dataGridView1.Rows.Add(gridviewrow);
            //chart1.cha
            chart1.MouseClick += mouseDownEvent;
            chart1.MouseWheel += mouseWheel;
            //chart1.Series.Add("Sensor 0");
            //chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.ChartAreas[0].AxisX.Maximum = 100;
            //chart1.ChartAreas[0].AxisX.Title = "Time (hour)";
            //chart1.Series["Sensor 0"].Points.AddXY(1, 3);
            //chart1.ChartAreas[0].AxisY.Minimum = 0;
            //chart1.ChartAreas[0].AxisY.Maximum = 5;


        }
        public void mouseWheel(object sender, MouseEventArgs e)
        {
            zoom_size = (float) chart1.ChartAreas[0].AxisX.Maximum;
            if (e.Delta>0)
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
                chart1.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + zoom_size / ( zoom);
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
        public void mouseDownEvent(object sender, EventArgs e)

        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                chart1.ContextMenuStrip = contextMenuStrip1;
            }
        }
        private void _uart_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string serialPortReceiveddata;
            string realValue_serialPortReceivedData; 
            //string realValue1_serialPortReceivedData;
            //string realValue2_serialPortReceivedData; 
            //string realValue3_serialPortReceivedData, realExistingValue_serialPortReceivedData;
            //serialPortReceiveddata = _uart.ReadExisting();
            //if (serialPortReceiveddata != null)
            //{
            //    // 12.1234\r\n: length= 9
            //    realValue0_serialPortReceivedData = serialPortReceiveddata.Substring(1, 7);

            //    value[0] = Convert.ToDouble(realValue0_serialPortReceivedData);

            //    realValue1_serialPortReceivedData = serialPortReceiveddata.Substring(9, 7);

            //    value[1] = Convert.ToDouble(realValue1_serialPortReceivedData);

            //    realValue2_serialPortReceivedData = serialPortReceiveddata.Substring(11, 7);

            //    value[2] = Convert.ToDouble(realValue2_serialPortReceivedData);

            //    realValue3_serialPortReceivedData = serialPortReceiveddata.Substring(19, 7);

            //    value[3] = Convert.ToDouble(realValue3_serialPortReceivedData);

            //}
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
                //if (addrow_gridview == 4)
                //{ 
                //    UpdateGridView(value1, value2, value3, value4, 0, 0);
                //    addrow_gridview = 0;
                //}
                //throw new NotImplementedException();

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
            Prompt.ShowDialog("This is Gas Sensor GUI\nVersion 1.0", "20February2020");
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
            catch(System.IO.IOException)
            {
                
            }

        }

        private void DisconnectSerialPort_Click(object sender, EventArgs e)
        {
            CloseDown = new System.Threading.Thread(new System.Threading.ThreadStart(CloseSerialOnExit));


            CloseDown.Start();
            timer1.Enabled = false;

            labelSerialPortStatus.Text = "Disconnected";
            labelSerialPortStatus.BackColor= Color.Red;
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
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time++;
            count++;
            if (time / 60 >= 0.09)
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.000";
            }
            else if(time / 60 >= 0.9)
                {
                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
                }
            if((int)time%5==0)
            {
                UpdateChart((float)prev_time+time * (timer1.Interval/1000)/60, value[0], 1);
                UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[1], 2);
                UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[2], 3);
                UpdateChart((float)prev_time + time * (timer1.Interval / 1000) / 60, value[3], 4);
                //addrow_gridview = 0;
            }
            UpdateGridView((float)prev_time + time * (timer1.Interval / 1000) / 60, value[0], value[1], value[2], value[3], 0, 0);

            //textBoxCount.Text = count.toString();
            //chart1.Series["Sensor 1"].Points.AddXY(time / 60, time);
            //if (time < 30)
            //{
            //   // chart1.ChartAreas[0].AxisX.Maximum = 60;
            //   // chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 5;
            //}
            //else
            //{
            //    //chart1.ChartAreas[0].RecalculateAxesScale();
            //}

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

                //if (addrow_gridview == 4)
                //{ 
                //    DataGridViewRow gridviewrow = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                //    gridviewrow.Cells[0].Value = value1;
                //    gridviewrow.Cells[1].Value = value2;
                //    gridviewrow.Cells[2].Value = value3;
                //    gridviewrow.Cells[3].Value = value4;
                //    row_number++;
                //    dataGridView1.Rows.Add(gridviewrow);

                //    if (row_number >= 10)
                //    {
                //        dataGridView1.FirstDisplayedScrollingRowIndex = row_number - 10;// FirstDisplayedScrollingRowIndex
                //    }
                //}
                //chart1.ChartAreas[0].RecalculateAxesScale();


            }
        }

        private void UpdateGridView(double sample_time_grid,double Value1 , double Value2, double Value3, double Value4, int current_row, int sensor_number)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (dataGridView1.InvokeRequired)
            {
                UpdateGridViewCallback d = new UpdateGridViewCallback(UpdateGridView);
                this.Invoke(d, new object[] { sample_time_grid,Value1, Value2, Value3, Value4, current_row, sensor_number });
            }
            //DataGridViewRow gridviewrow = (DataGridViewRow)dataGridView1.Rows[0].Clone();

            //gridviewrow.Cells[0].Value = 1;
            //dataGridView1.Rows.Add(gridviewrow);
            else
            {


                    DataGridViewRow gridviewrow = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    gridviewrow.Cells[0].Value = sample_time_grid;
                    gridviewrow.Cells[1].Value = Value1;
                    gridviewrow.Cells[2].Value = Value2;
                    gridviewrow.Cells[3].Value = Value3;
                    gridviewrow.Cells[4].Value = Value4;
                    row_number++;
                    dataGridView1.Rows.Add(gridviewrow);

                if (row_number >= 10)
                {
                    try
                    {
                        dataGridView1.FirstDisplayedScrollingRowIndex = row_number - 10;// FirstDisplayedScrollingRowIndex
                        //row_number = 0;
                    }
                    catch { }
                }




            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            chart1.Series["Sensor 1"].Points.Clear();
            chart1.Series["Sensor 2"].Points.Clear();
            chart1.Series["Sensor 3"].Points.Clear();
            chart1.Series["Sensor 4"].Points.Clear();
            dataGridView1.Rows.Clear();
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
            prev_time =prev_time+ time * (timer1.Interval / 1000) / 60;
            timer1.Interval = (Int32) Convert.ToDouble(textBoxSampleTime.Text)*1000;
            time = 0;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //chart1.ChartAreas[0].Clear();
        }

        private void ButtonClearChart_Click(object sender, EventArgs e)
        {
            chart1.Series["Sensor 1"].Points.Clear();
            chart1.Series["Sensor 2"].Points.Clear();
            chart1.Series["Sensor 3"].Points.Clear();
            chart1.Series["Sensor 4"].Points.Clear();
        }

        private void ToolStripMenuItemSetAutoScale_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = double.NaN;
        }



        private void SetMaxAxisYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prompt1.ShowDialog("Max AxisY", "Set AxisY MaxMin",chart1);
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
                BackColor=Color.AliceBlue
            };
            Label textLabel = new Label() { Left = 60, Top = 15, Text = text,Width=150,Height=100 };
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

    //public static class Prompt1
    //{
    //    public static void ShowDialog(string text, string caption)
    //    {
    //        Form prompt1 = new Form()
    //        {
    //            Width = 450,
    //            Height = 400,
    //            FormBorderStyle = FormBorderStyle.FixedDialog,
    //            Text = caption,
    //            StartPosition = FormStartPosition.CenterScreen,
    //            BackColor = Color.AliceBlue
    //        };
    //        Label textLabel = new Label() { Left = 60, Top = 15, Text = text, Width = 150, Height = 100 };
    //        TextBox textBox = new TextBox() { Text = "Ok", Left = 50, Width = 100, Top = 70 };

    //        Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 70, DialogResult = DialogResult.OK };

    //        confirmation.Click += (sender, e) => {

    //            prompt1.Close();
    //        };
    //        //prompt.Controls.Add(textBox);
    //        prompt1.Controls.Add(confirmation);
    //        prompt1.Controls.Add(textLabel);
    //        prompt1.AcceptButton = confirmation;
    //        prompt1.ShowDialog();
    //        return;// prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
    //    }
    //}
    public static class Prompt1
    {
        public static void ShowDialog(string text, string caption,Chart chart)
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
            TextBox textBoxMaxAxisY = new TextBox() { Left = 90, Top = 20, Width = 40,Text="5" };
            Button confirmation = new Button() { Text = "Ok", Left = 30, Width = 100, Top = 70, DialogResult = DialogResult.OK };

            Label textLabelMinAxisY = new Label() { Left = 30, Top = 40, Text = "Min AxisY" };
            TextBox textBoxMinAxisY = new TextBox() { Left = 90, Top = 40, Width = 40,Text="0" };


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
