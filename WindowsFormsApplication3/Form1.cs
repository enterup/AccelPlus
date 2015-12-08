using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Globalization;
using System.Xml.Serialization;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication3
{

    public partial class MainForm : Form
    {
        // public void ToCSV(DataTable table);
        delegate void ShowMessageMethod(string msg);
        UdpClient _server = null;
        IPEndPoint _client = null;
        Thread _listenThread = null;
        private bool _isServerStarted = false;
        private float xMaxModValue = -100;
        private float yMaxModValue = -100;
        private float zMaxModValue = -100;
        private int counter = 0;
        private int counterXY = 0;
        private int counterX = 0;
        private int counterY = 0;
        private int counterZ = 0;
        private int startCounter = 0;
        private int numberOfPoints = 0;
        private double xsum = 0;
        private double xmid = 0;
        private double ysum = 0;
        private double ymid = 0;
        private double zsum = 0;
        private double zmid = 0;
        private double prevX = 0;
        private double prevY = 0;
        private double prevZ = 0;
        private String stc = "Series1";
        private int flexInterval = 0;
        private double minDx = 0;
        private double minDy = 0;
        private double minDz = 0;
        static int timerC = 0;
        static int origTimer = 0;
        private System.Windows.Forms.Timer timerNew;
        private ProgramSetting configuration;
        private SettingsForm Setting;

        public MainForm()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;
            String delimeter = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            //String delMask = "0" + delimeter + "00";
            InitializeComponent();
            Setting = new SettingsForm();
            //String delMask = "0.00";
            if (Setting.settings.Timer != "")
            {
                timerTextBox.Text = Setting.settings.Timer;
            }
            else { 
                timerTextBox.Text = "10";
            }
            if (Setting.settings.countPoint != "0")
            {
                numberOfPoints = Convert.ToInt16(Setting.settings.countPoint);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //  label15.Text = "Start!";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {


            Close();
        }
        //Save last configuration to settings.xml file
        private void SaveSettings()
        {


            try
            {
                using (System.IO.Stream writer = new FileStream("settings.xml", FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ProgramSetting));
               
                    serializer.Serialize(writer, Setting.settings);
                }
            }
            catch (Exception e)
            {

            }
        }
        private void Start()
        {

            if (Setting.settings.countPoint != "0")
            {
                numberOfPoints = Convert.ToInt16(Setting.settings.countPoint);
            }
            if (_isServerStarted == false)
            {


                //Create the server.
                if (Setting.settings.Source=="UDP")
                {
                    Int32 portNumber = Convert.ToInt32(Setting.settings.UDPPort);
                    IPEndPoint serverEnd = new IPEndPoint(IPAddress.Any, portNumber);
                    _server = new UdpClient(serverEnd);

                    //Create the client end.
                    _client = new IPEndPoint(IPAddress.Any, 0);
                }
                else
                {
                    try
                    {
                        comPort.BaudRate = Convert.ToInt32(Setting.settings.PortSpeed);
                        comPort.PortName = Setting.settings.COMPort;
                        comPort.ReadTimeout = 500;
                        comPort.WriteTimeout = 500;
                        comPort.Open();
                        comPort.WriteLine("1");
                        comPort.WriteLine("1");
                    }
                    catch (System.IO.IOException e)
                    {
                        MessageBox.Show("Error:" + e.Message);
                        return;
                    }
                }
                minDx = Convert.ToDouble(Setting.settings.minDx);
                minDy = Convert.ToDouble(Setting.settings.minDy);
                minDz = Convert.ToDouble(Setting.settings.minDz);
                timerNew = new System.Windows.Forms.Timer();
                timerNew.Tick += new EventHandler(TimerEventProcessor);
                timerNew.Interval = 1000;
                timerNew.Start();
                startCounter++;
                //clear charts
                chartX.Series.Clear();
                chartY.Series.Clear();
                chartZ.Series.Clear();
                chartX.ChartAreas[0].AxisX.CustomLabels.Clear();
                chartY.ChartAreas[0].AxisX.CustomLabels.Clear();
                chartZ.ChartAreas[0].AxisX.CustomLabels.Clear();
                chartX.ChartAreas[0].AxisX.ScaleView.Size = Convert.ToInt16(Setting.settings.countPoint);
                chartY.ChartAreas[0].AxisX.ScaleView.Size = Convert.ToInt16(Setting.settings.countPoint);
                chartZ.ChartAreas[0].AxisX.ScaleView.Size = Convert.ToInt16(Setting.settings.countPoint);
                chartX.Series.Add("SeriesXMid");
                chartX.Series["SeriesXMid"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartX.Series["SeriesXMid"].Color = Color.Fuchsia;
                chartX.Series.Add("SeriesXMax");
                chartX.Series["SeriesXMax"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartX.Series["SeriesXMax"].Color = Color.Red;
                chartX.Series.Add("SeriesXMin");
                chartX.Series["SeriesXMin"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartX.Series["SeriesXMin"].Color = Color.Red;
                chartY.Series.Add("SeriesYMid");
                chartY.Series["SeriesYMid"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartY.Series["SeriesYMid"].Color = Color.Fuchsia;
                chartY.Series.Add("SeriesYMax");
                chartY.Series["SeriesYMax"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartY.Series["SeriesYMax"].Color = Color.Red;
                chartY.Series.Add("SeriesYMin");
                chartY.Series["SeriesYMin"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartY.Series["SeriesYMin"].Color = Color.Red;

                chartZ.Series.Add("SeriesZMid");
                chartZ.Series["SeriesZMid"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartZ.Series["SeriesZMid"].Color = Color.Fuchsia;
                chartZ.Series.Add("SeriesZMax");
                chartZ.Series["SeriesZMax"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartZ.Series["SeriesZMax"].Color = Color.Red;
                chartZ.Series.Add("SeriesZMin");
                chartZ.Series["SeriesZMin"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartZ.Series["SeriesZMin"].Color = Color.Red;

                chartX.ChartAreas[0].AxisY.Maximum = Double.NaN;
                chartX.ChartAreas[0].AxisY.Minimum = Double.NaN;
                chartY.ChartAreas[0].AxisY.Maximum = Double.NaN;
                chartY.ChartAreas[0].AxisY.Minimum = Double.NaN;
                chartZ.ChartAreas[0].AxisY.Maximum = Double.NaN;
                chartZ.ChartAreas[0].AxisY.Minimum = Double.NaN;
                chartX.Titles.Clear();
                chartY.Titles.Clear();
                chartZ.Titles.Clear();
                chartX.ChartAreas[0].Position.Auto = true;
                chartY.ChartAreas[0].Position.Auto = true;
                chartZ.ChartAreas[0].Position.Auto = true;
                //stop clear
                stc = "Series" + startCounter.ToString();
                chartX.Series.Add(stc);
                chartX.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartY.Series.Add(stc);
                chartY.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartZ.Series.Add(stc);
                chartZ.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartX.ChartAreas[0].AxisX.Title = "Points";
                chartX.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
                chartY.ChartAreas[0].AxisX.Title = "Points";
                chartY.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
                chartZ.ChartAreas[0].AxisX.Title = "Points";
                chartZ.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
                timerC = Int16.Parse(timerTextBox.Text);

                //   chartZ.ChartAreas[0].RecalculateAxesScale();
                origTimer = timerC;
                // }
                //Start listening.
                //Thread 

                for (int i = 0; i < 3; i++)
                {
                    try
                    {

                        _listenThread = new Thread(new ThreadStart(Listening));
                        _listenThread.Start();
                        _isServerStarted = true;
                        // label15.Text = "Thread is Started!";
                    }
                    //Change state to indicate the server starts.
                    catch (Exception e)
                    {
                        MessageBox.Show("Error in run thread!" + e.Message);
                        //         label15.Text = "Error in run thread!" + e.Message;
                    }
                    if (_listenThread.IsAlive)
                    {
                        //    label15.Text = "Thread is Alive!";
                        break;
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(30);
                    }
                }
            }
        }
        private void Listening()
        {
            byte[] data;
            //Listening loop.
            if (_isServerStarted == true)
                counter = 0;
            string receivedMsg = "";
            Action<string, float, float, float, int> action = SendMsg;

            while (_isServerStarted)
            {
                //receieve a message form a client.
                counter++;
                if (Setting.settings.Source == "UDP")
                {
                    try
                    {
                        data = _server.Receive(ref _client);
                        receivedMsg = Encoding.ASCII.GetString(data, 0, data.Length);
                    }
                    catch (SocketException e)
                    {
                        int er = e.ErrorCode;
                        SocketError s = e.SocketErrorCode;
                    }
                    catch (System.ObjectDisposedException e)
                    {
                        break;
                    }
                }
                else
                {
                    try
                    {
                        receivedMsg = comPort.ReadLine();
                    }
                    catch (TimeoutException e)
                    {
                        continue;
                    }
                    catch (System.IO.IOException e1)
                    {
                        break;
                    }
                    catch (System.InvalidOperationException e)
                    {
                        break;
                    }
                }
                if (receivedMsg != "")
                {
                    string[] words;
                    words = receivedMsg.Split(',');
                    if (words.Length >= 5)
                    {
                        float fx;
                        float fy;
                        float fz;
                        if (float.TryParse(words[2], System.Globalization.NumberStyles.Any, new CultureInfo("en-US"), out fx) & float.TryParse(words[3], System.Globalization.NumberStyles.Any, new CultureInfo("en-US"), out fy) & float.TryParse(words[4], System.Globalization.NumberStyles.Any, new CultureInfo("en-US"), out fz))
                        {

                            this.Invoke(action, new object[] { receivedMsg, fx, fy, fz, counter });
                        }
                        else
                        {
                            continue;
                        }

                    }
                }
            }

        }



        private void SendMsg(string msg, float fx, float fy, float fz, int c)
        {
            if (_isServerStarted)
            {

                if (fz != 0 && fy != 0 && fx != 0)
                {
                    if (counterXY == 0)
                    {
                        prevX = fx;
                        prevY = fy;
                        prevZ = fz;
                    }
                    else
                    {
                        if (Math.Abs(Math.Abs(fx) - Math.Abs(prevX)) <= minDx)
                        {
                            fx = System.Convert.ToSingle(prevX);
                        }
                        if (Math.Abs(Math.Abs(fy) - Math.Abs(prevY)) <= minDy)
                        {
                            fy = System.Convert.ToSingle(prevY);
                        }
                        if (Math.Abs(Math.Abs(fz) - Math.Abs(prevZ)) <= minDz)
                        {
                            fz = System.Convert.ToSingle(prevZ);
                        }
                    }
                    counterXY++;
                    counterX++;
                    counterY++;
                    counterZ++;
                    xsum = (xsum + fx);
                    xmid = xsum / counterXY;
                    ysum = (ysum + fy);
                    ymid = ysum / counterXY;
                    zsum = (zsum + fz);
                    zmid = zsum / counterXY;
                    this.DataSetValues.Tables["AllValues"].LoadDataRow(new Object[] { fx, fy, fz, counterXY, DateTime.Now, startCounter, stc }, false);
                    if (counterX == numberOfPoints)
                    {
                        this.chartX.Series.RemoveAt(chartX.Series.Count - 1);
                        chartX.Series.Add(stc);
                        chartX.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                        counterX = 0;
                        this.chartY.Series.RemoveAt(chartY.Series.Count - 1);
                        chartY.Series.Add(stc);
                        chartY.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                        counterY = 0;
                        this.chartZ.Series.RemoveAt(chartZ.Series.Count - 1);
                        chartZ.Series.Add(stc);
                        chartZ.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                        counterZ = 0;
                    }

                    this.chartX.Series[stc].Points.AddXY(counterX, fx);
                    this.chartY.Series[stc].Points.AddXY(counterY, fy);
                    this.chartZ.Series[stc].Points.AddXY(counterZ, fz);
                    this.chartX.Series["SeriesXMid"].Points.Clear();
                    this.chartX.Series["SeriesXMid"].Points.AddXY(0, xmid);
                    this.chartX.Series["SeriesXMid"].Points.AddXY(numberOfPoints, xmid);
                    this.chartY.Series["SeriesYMid"].Points.Clear();
                    this.chartY.Series["SeriesYMid"].Points.AddXY(0, ymid);
                    this.chartY.Series["SeriesYMid"].Points.AddXY(numberOfPoints, ymid);
                    this.chartZ.Series["SeriesZMid"].Points.Clear();
                    this.chartZ.Series["SeriesZMid"].Points.AddXY(0, zmid);
                    this.chartZ.Series["SeriesZMid"].Points.AddXY(numberOfPoints, zmid);
                    chartZ.ChartAreas[0].RecalculateAxesScale();
                    this.chartX.Update();
                    this.chartY.Update();
                    this.chartZ.Update();

                }
            }
        }
        private void Stop()
        {

            //Stop listening.
            if (_isServerStarted == true)
            {
                try
                {

                    SendMsg("Server stops.", 0, 0, 0, 0);
                    if (Setting.settings.Source == "UDP")
                    {
                        _server.Close();
                    }
                    else
                    {
                        comPort.Close();
                    }
                    _listenThread.Join(200);
                    _listenThread.Abort();
                    //Changet state to indicate the server stops.

                }
                catch (ThreadStateException e)
                {
                    SendMsg("Server stops. Error.", 0, 0, 0, 0);
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Stop();
            if (_isServerStarted == true && counterXY != 0)
            {
                // if (counterXY != 0)
                //{
                //   this.DataSetValues.Tables["AllValues"].LoadDataRow(new Object[] { 0, 0, 9.8, 1, DateTime.Now, startCounter }, false);
                // }
                float minX = 100;
                float minY = 100;
                float minZ = 100;
                float maxX = -100;
                float maxY = -100;
                float maxZ = -100;
                int length = System.Convert.ToInt16(Setting.settings.FlexInerval);

                String filter = "startNUmber=" + startCounter;
                DataView custDV = new DataView(DataSetValues.Tables["AllValues"], filter, "startNumber", DataViewRowState.CurrentRows);
                foreach (DataRowView catDRV in custDV)
                {
                    float X = System.Convert.ToSingle(Convert.ToDouble(catDRV[0]));
                    float Y = System.Convert.ToSingle(Convert.ToDouble(catDRV[1]));
                    float Z = System.Convert.ToSingle(Convert.ToDouble(catDRV[2]));
                    if (X > maxX)
                    { maxX = X; }
                    if (X < minX)
                    {
                        minX = X;
                    }
                    if (Y > maxY)
                    { maxY = Y; }
                    if (Y < minY)
                    {
                        minY = Y;
                    }
                    if (Z > maxZ)
                    { maxZ = Z; }
                    if (Z < minZ)
                    {
                        minZ = Z;
                    }

                }
               
                float sumX = 0;
                float sumY = 0;
                float sumZ = 0;
                float flexMidX = 0;
                float flexMidY = 0;
                float flexMidZ = 0;
                float maxFlexMidX = -100;
                float maxFlexMidY = -100;
                float maxFlexMidZ = -100;
                float minFlexMidX = 100;
                float minFlexMidY = 100;
                float minFlexMidZ = 100;
                float divMinFlexMidX = 0;
                float divMinFlexMidY = 0;
                float divMinFlexMidZ = 0;
                for (int i = 0; i < custDV.Count - length; i++)
                {
                    for (int j = i; j < i + length; j++)
                    {
                        sumX = System.Convert.ToSingle(Convert.ToDouble(custDV[j][0])) + sumX;
                        sumY = System.Convert.ToSingle(Convert.ToDouble(custDV[j][1])) + sumY;
                        sumZ = System.Convert.ToSingle(Convert.ToDouble(custDV[j][2])) + sumZ;
                    }
                    flexMidX = sumX / length;
                    flexMidY = sumY / length;
                    flexMidZ = sumZ / length;
                    if (flexMidX > maxFlexMidX)
                    {
                        maxFlexMidX = flexMidX;
                    }
                    if (flexMidX < minFlexMidX)
                    {
                        minFlexMidX = flexMidX;
                    }
                    if (flexMidY > maxFlexMidY)
                    {
                        maxFlexMidY = flexMidY;
                    }
                    if (flexMidY < minFlexMidY)
                    {
                        minFlexMidY = flexMidY;
                    }
                    if (flexMidZ > maxFlexMidZ)
                    {
                        maxFlexMidZ = flexMidZ;
                    }
                    if (flexMidZ < minFlexMidZ)
                    {
                        minFlexMidZ = flexMidZ;
                    }
                    sumX = 0;
                    sumY = 0;
                    sumZ = 0;
                }

                xMaxModValue = maxX - minX;
                yMaxModValue = maxY - minY;
                zMaxModValue = maxZ - minZ;
             

                divMinFlexMidX = maxFlexMidX - minFlexMidX;
                divMinFlexMidY = maxFlexMidY - minFlexMidY;
                divMinFlexMidZ = maxFlexMidZ - minFlexMidZ;

                this.chartX.Series["SeriesXMax"].Points.Clear();
                this.chartX.Series["SeriesXMin"].Points.Clear();
                this.chartX.Series["SeriesXMid"].Points.Clear();
                this.chartY.Series["SeriesYMax"].Points.Clear();
                this.chartY.Series["SeriesYMin"].Points.Clear();
                this.chartY.Series["SeriesYMid"].Points.Clear();
                this.chartZ.Series["SeriesZMax"].Points.Clear();
                this.chartZ.Series["SeriesZMin"].Points.Clear();
                this.chartZ.Series["SeriesZMid"].Points.Clear();
                if (this.chartX.Series.Count > 5)
                //    if (startCounter > 2) 
                {
                    this.chartX.Series.RemoveAt(3);
                    this.chartY.Series.RemoveAt(3);
                    this.chartZ.Series.RemoveAt(3);

                }
                this.chartX.Series["SeriesXMax"].Points.AddXY(0, maxX);
                this.chartX.Series["SeriesXMax"].Points.AddXY(numberOfPoints, maxX);
                this.chartX.Series["SeriesXMin"].Points.AddXY(0, minX);
                this.chartX.Series["SeriesXMin"].Points.AddXY(numberOfPoints, minX);
                this.chartX.Series["SeriesXMid"].Points.AddXY(0, xmid);
                this.chartX.Series["SeriesXMid"].Points.AddXY(numberOfPoints, xmid);
                  /* this.chartX.ChartAreas[0].AxisY.Maximum = maxX + 0.1;
                    this.chartX.ChartAreas[0].AxisY.Minimum = minX - 0.1;
                    this.chartX.ChartAreas[0].AxisY.MaximumAutoSize = 8;
                  */
                this.chartY.Series["SeriesYMax"].Points.AddXY(0, maxY);
                this.chartY.Series["SeriesYMax"].Points.AddXY(numberOfPoints, maxY);
                this.chartY.Series["SeriesYMin"].Points.AddXY(0, minY);
                this.chartY.Series["SeriesYMin"].Points.AddXY(numberOfPoints, minY);
                this.chartY.Series["SeriesYMid"].Points.AddXY(0, ymid);
                this.chartY.Series["SeriesYMid"].Points.AddXY(numberOfPoints, ymid);
                /*  this.chartY.ChartAreas[0].AxisY.Maximum = maxY + 0.1;
                 this.chartY.ChartAreas[0].AxisY.Minimum = minY - 0.1;
                 this.chartY.ChartAreas[0].AxisY.MaximumAutoSize = 8;
                 */
                this.chartZ.Series["SeriesZMax"].Points.AddXY(0, maxZ);
                this.chartZ.Series["SeriesZMax"].Points.AddXY(numberOfPoints, maxZ);
                this.chartZ.Series["SeriesZMin"].Points.AddXY(0, minZ);
                this.chartZ.Series["SeriesZMin"].Points.AddXY(numberOfPoints, minZ);
                this.chartZ.Series["SeriesZMid"].Points.AddXY(0, zmid);
                this.chartZ.Series["SeriesZMid"].Points.AddXY(numberOfPoints, zmid);
                //    this.chartZ.ChartAreas[0].AxisY.Maximum = maxZ + 0.1;
                //    this.chartZ.ChartAreas[0].AxisY.Minimum = minZ - 0.1;
                //    this.chartZ.ChartAreas[0].AxisY.MaximumAutoSize = 8;

                double xdev = xMaxModValue / 5;
                double ydev = yMaxModValue / 5;
                double zdev = zMaxModValue / 5;
                chartX.ChartAreas[0].AxisY.Interval = Math.Round(xdev, 1);
                chartY.ChartAreas[0].AxisY.Interval = Math.Round(ydev, 1);
                chartZ.ChartAreas[0].AxisY.Interval = Math.Round(zdev, 1);

                String[] row = new String[18];
                row[0] = DateTime.Now.ToString();
                row[1] = stc;
                row[2] = counter.ToString(); ;
                row[3] = (Math.Round(xMaxModValue, 3) * 10).ToString();
                row[4] = (Math.Round(yMaxModValue, 3) * 10).ToString();
                row[5] = (Math.Round(zMaxModValue, 3) * 10).ToString();
                row[6] = (Math.Round(divMinFlexMidX, 3) * 10).ToString();
                row[7] = (Math.Round(divMinFlexMidY, 3) * 10).ToString();
                row[8] = (Math.Round(divMinFlexMidZ, 3) * 10).ToString(); ;
                row[9] = maxX.ToString();
                row[10] = minX.ToString();
                row[11] = xmid.ToString();
                row[12] = maxY.ToString();
                row[13] = minY.ToString();
                row[14] = ymid.ToString();
                row[15] = maxZ.ToString();
                row[16] = minZ.ToString();
                row[17] = zmid.ToString();
                dataGrid.Rows.Add(row);
                dataGrid.Rows[dataGrid.Rows.Count - 1].Selected = true;
                if (startCounter > 1)
                {
                    colorsForGrid();
                }

           /*     chartModX.Series["Series1"].Points.AddXY(DateTime.Now.ToString(), xMaxModValue);
                chartModY.Series["Series1"].Points.AddXY(DateTime.Now.ToString(), yMaxModValue);
                chartModZ.Series["Series1"].Points.AddXY(DateTime.Now.ToString(), zMaxModValue);
                */
                maxFlexMidX = -100;
                maxFlexMidY = -100;
                maxFlexMidZ = -100;
                minFlexMidX = 100;
                minFlexMidY = 100;
                minFlexMidZ = 100;

                divMinFlexMidX = 0;
                divMinFlexMidY = 0;
                divMinFlexMidZ = 0;
                flexMidX = 0;
                flexMidY = 0;
                flexMidZ = 0;



            }
            xMaxModValue = -100;
            yMaxModValue = -100;
            zMaxModValue = -100;



            counterXY = 0;
            xmid = 0;
            ymid = 0;
            zmid = 0;
            xsum = 0;
            ysum = 0;
            zsum = 0;

            prevX = 0;
            prevY = 0;
            prevZ = 0;
            counterX = 0;
            counterY = 0;
            counterZ = 0;
            timerNew.Stop();
            timerTextBox.Text = origTimer.ToString();
            _isServerStarted = false;
            //  label15.Text = "Stop!";
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chartX_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (!_isServerStarted)
            {
                dataGrid.Rows.Clear();
                DataSetValues.Clear();
                this.chartX.Series["SeriesXMax"].Points.Clear();
                this.chartX.Series["SeriesXMin"].Points.Clear();
                this.chartX.Series["SeriesXMid"].Points.Clear();
                this.chartY.Series["SeriesYMax"].Points.Clear();
                this.chartY.Series["SeriesYMin"].Points.Clear();
                this.chartY.Series["SeriesYMid"].Points.Clear();
                this.chartZ.Series["SeriesZMax"].Points.Clear();
                this.chartZ.Series["SeriesZMin"].Points.Clear();
                this.chartZ.Series["SeriesZMid"].Points.Clear();

                while (this.chartX.Series.Count != 3)
                {
                    this.chartX.Series.RemoveAt(3);
                    this.chartY.Series.RemoveAt(3);
                    this.chartZ.Series.RemoveAt(3);
                }
            /*    chartModX.Series["Series1"].Points.Clear();
                chartModY.Series["Series1"].Points.Clear();
                chartModZ.Series["Series1"].Points.Clear(); */
                counter = 0;
                startCounter = 0;
                counterXY = 0;
                xMaxModValue = -100;
                yMaxModValue = -100;
                zMaxModValue = -100;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {

            if (timerC == 1)
            {
                //label15.Text = "Stop by timer Event!";
                stopButton_Click(myObject, myEventArgs);
                timerTextBox.Text = origTimer.ToString();
                _isServerStarted = false;
            }
            else
            {
                timerTextBox.Text = timerC.ToString();
                timerC = timerC - 1;
                //    label15.Text = "Next tick!"+_listenThread.IsAlive.ToString();
            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void какПользоватьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void chartX_AxisViewChanged(object sender, System.Windows.Forms.DataVisualization.Charting.ViewEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isServerStarted)
            {
                stopButton_Click(sender, e);
            }
            SaveSettings();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LoadAllSeries()
        {
            //Clear all data
            dataGrid.Rows.Clear();

            this.chartX.Series["SeriesXMax"].Points.Clear();
            this.chartX.Series["SeriesXMin"].Points.Clear();
            this.chartX.Series["SeriesXMid"].Points.Clear();
            this.chartY.Series["SeriesYMax"].Points.Clear();
            this.chartY.Series["SeriesYMin"].Points.Clear();
            this.chartY.Series["SeriesYMid"].Points.Clear();
            this.chartZ.Series["SeriesZMax"].Points.Clear();
            this.chartZ.Series["SeriesZMin"].Points.Clear();
            this.chartZ.Series["SeriesZMid"].Points.Clear();

            while (this.chartX.Series.Count != 3)
            {
                this.chartX.Series.RemoveAt(3);
                this.chartY.Series.RemoveAt(3);
                this.chartZ.Series.RemoveAt(3);
            }
        /*    chartModX.Series["Series1"].Points.Clear();
            chartModY.Series["Series1"].Points.Clear();
            chartModZ.Series["Series1"].Points.Clear(); */
            counter = 0;
            startCounter = 0;
            counterXY = 0;
            xMaxModValue = -100;
            yMaxModValue = -100;
            zMaxModValue = -100;


            // 

            DataView custDV = new DataView(DataSetValues.Tables["AllValues"], null, "startNumber", DataViewRowState.CurrentRows);
            int maxSeries = Convert.ToInt32(custDV[custDV.Count - 1][5]);
            startCounter = maxSeries;
            for (int i = 1; i <= maxSeries; i++)
            {
                calculateSeries(i);
            }

        }

        private void calculateSeries(int seriesNumber)
        {
            float minX = 100;
            float minY = 100;
            float minZ = 100;
            float maxX = -100;
            float maxY = -100;
            float maxZ = -100;
            float sumx = 0;
            float sumy = 0;
            float sumz = 0;
            int length = System.Convert.ToInt16(Setting.settings.FlexInerval);
            String filter = "startNUmber=" + seriesNumber;
            DataView custDV = new DataView(DataSetValues.Tables["AllValues"], filter, "startNumber", DataViewRowState.CurrentRows);
            int counter = custDV.Count;
            if(counter != 0)
            { 
            foreach (DataRowView catDRV in custDV)
            {
                float X = System.Convert.ToSingle(Convert.ToDouble(catDRV[0]));
                float Y = System.Convert.ToSingle(Convert.ToDouble(catDRV[1]));
                float Z = System.Convert.ToSingle(Convert.ToDouble(catDRV[2]));
                sumx = sumx + X;
                sumy = sumy + Y;
                sumz = sumz + Z;
                if (X > maxX)
                { maxX = X; }
                if (X < minX)
                {
                    minX = X;
                }
                if (Y > maxY)
                { maxY = Y; }
                if (Y < minY)
                {
                    minY = Y;
                }
                if (Z > maxZ)
                { maxZ = Z; }
                if (Z < minZ)
                {
                    minZ = Z;
                }

            }
            float flexSumX = 0;
            float flexSumY = 0;
            float flexSumZ = 0;
            float flexMidX = 0;
            float flexMidY = 0;
            float flexMidZ = 0;
            float maxFlexMidX = -100;
            float maxFlexMidY = -100;
            float maxFlexMidZ = -100;
            float minFlexMidX = 100;
            float minFlexMidY = 100;
            float minFlexMidZ = 100;
            float divMinFlexMidX = 0;
            float divMinFlexMidY = 0;
            float divMinFlexMidZ = 0;
            for (int i = 0; i < custDV.Count - length; i++)
            {
                for (int j = i; j < i + length; j++)
                {
                    flexSumX = System.Convert.ToSingle(Convert.ToDouble(custDV[j][0])) + flexSumX;
                    flexSumY = System.Convert.ToSingle(Convert.ToDouble(custDV[j][1])) + flexSumY;
                    flexSumZ = System.Convert.ToSingle(Convert.ToDouble(custDV[j][2])) + flexSumZ;
                }
                flexMidX = flexSumX / length;
                flexMidY = flexSumY / length;
                flexMidZ = flexSumZ / length;
                if (flexMidX > maxFlexMidX)
                {
                    maxFlexMidX = flexMidX;
                }
                if (flexMidX < minFlexMidX)
                {
                    minFlexMidX = flexMidX;
                }
                if (flexMidY > maxFlexMidY)
                {
                    maxFlexMidY = flexMidY;
                }
                if (flexMidY < minFlexMidY)
                {
                    minFlexMidY = flexMidY;
                }
                if (flexMidZ > maxFlexMidZ)
                {
                    maxFlexMidZ = flexMidZ;
                }
                if (flexMidZ < minFlexMidZ)
                {
                    minFlexMidZ = flexMidZ;
                }
                flexSumX = 0;
                flexSumY = 0;
                flexSumZ = 0;
            }

            xMaxModValue = maxX - minX;
            yMaxModValue = maxY - minY;
            zMaxModValue = maxZ - minZ;
            divMinFlexMidX = maxFlexMidX - minFlexMidX;
            divMinFlexMidY = maxFlexMidY - minFlexMidY;
            divMinFlexMidZ = maxFlexMidZ - minFlexMidZ;
            xmid = sumx / counter;
            ymid = sumy / counter;
            zmid = sumz / counter;
            stc = "Series" + seriesNumber.ToString();

            String[] row = new String[18];
            row[0] = custDV[custDV.Count - 1][4].ToString();
            row[1] = stc;
            row[2] = counter.ToString(); ;
            row[3] = xMaxModValue.ToString();
            row[4] = yMaxModValue.ToString();
            row[5] = zMaxModValue.ToString();
            row[6] = divMinFlexMidX.ToString();
            row[7] = divMinFlexMidY.ToString();
            row[8] = divMinFlexMidZ.ToString();
            row[9] = maxX.ToString();
            row[10] = minX.ToString();
            row[11] = xmid.ToString();
            row[12] = maxY.ToString();
            row[13] = minY.ToString();
            row[14] = ymid.ToString();
            row[15] = maxZ.ToString();
            row[16] = minZ.ToString();
            row[17] = zmid.ToString();
            dataGrid.Rows.Add(row);

     
            xMaxModValue = -100;
            yMaxModValue = -100;
            zMaxModValue = -100;
            maxFlexMidX = -100;
            maxFlexMidY = -100;
            maxFlexMidZ = -100;
            minFlexMidX = 100;
            minFlexMidY = 100;
            minFlexMidZ = 100;

            divMinFlexMidX = 0;
            divMinFlexMidY = 0;
            divMinFlexMidZ = 0;
            flexMidX = 0;
            flexMidY = 0;
            flexMidZ = 0;

            _isServerStarted = false;
            counterXY = 0;
            xmid = 0;
            ymid = 0;
            zmid = 0;
            xsum = 0;
            ysum = 0;
            zsum = 0;

            prevX = 0;
            prevY = 0;
            prevZ = 0;
            counterX = 0;
            counterY = 0;
            counterZ = 0;
            }
        }

        private void colorsForGrid()
        {
            float localMinX = 100;
            int rowMinX = -1;
            int rowMinY = -1;
            int rowMinZ = -1;
            float localMinY = 100;
            float localMinZ = 100;
            float prevValue = -100;
            float f = 0;
            String cellValue = "";
            Double dev = 0;
            for (int i = 3; i < dataGrid.Columns.Count; i++)
            {
                for (int j = 0; j < dataGrid.Rows.Count; j++)
                {
                    if (dataGrid.Rows[j].Cells[i].Value != null)
                    {
                        cellValue = dataGrid.Rows[j].Cells[i].Value.ToString();
                        String [] cellValueSplit = cellValue.Split('(');
                        float.TryParse(cellValueSplit[0], NumberStyles.Any, CultureInfo.CurrentCulture, out f);
                        if(prevValue == -100)
                        {
                            prevValue = f;
                        }
                        else
                        {
                            
                            dev = Math.Round((prevValue - f) * (-1),2);
                             prevValue = f;
                             dataGrid.Rows[j].Cells[i].Value = Convert.ToString(f) + " (" + Convert.ToString(dev) + ")";
                        }
                        
                            
                        if (f < localMinX)
                        {
                            localMinX = f;
                            if (rowMinX > -1)
                            {
                                dataGrid.Rows[rowMinX].Cells[i].Style.BackColor = Color.OrangeRed;
                                //dataGrid.Rows[rowMinX].Cells[i].Style.SelectionForeColor = Color.DarkOrange;
                                dataGrid.Rows[rowMinX].Cells[i].Style.SelectionBackColor = Color.OrangeRed;
                            }
                            rowMinX = j;
                            dataGrid.Rows[j].Cells[i].Style.BackColor = Color.Green;
                          //  dataGrid.Rows[j].Cells[i].Style.SelectionForeColor = Color.Green;
                            dataGrid.Rows[j].Cells[i].Style.SelectionBackColor = Color.Green;

                        }
                        else
                        {
                            dataGrid.Rows[j].Cells[i].Style.BackColor = Color.OrangeRed;
                            //dataGrid.Rows[j].Cells[i].Style.SelectionForeColor = Color.DarkOrange;
                            dataGrid.Rows[j].Cells[i].Style.SelectionBackColor = Color.OrangeRed;
                        }
                    }
                }
                prevValue = -100;
                localMinX = 100;
                rowMinX = -1;
            }
        }



        private void paintSeries(int SeriesNumber,String SeriesName)
        {
            float minX = 100;
            float minY = 100;
            float minZ = 100;
            float maxX = -100;
            float maxY = -100;
            float maxZ = -100;
            double pointTime = 0;
            chartX.ChartAreas[0].AxisX.CustomLabels.Clear();
            chartY.ChartAreas[0].AxisX.CustomLabels.Clear();
            chartZ.ChartAreas[0].AxisX.CustomLabels.Clear();
            chartX.ChartAreas[0].AxisX.Title = "Time(ss)";
            chartX.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartY.ChartAreas[0].AxisX.Title = "Time(ss)";
            chartY.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartZ.ChartAreas[0].AxisX.Title = "Time(ss)";
            chartZ.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            int length = System.Convert.ToInt16(Setting.settings.FlexInerval);
            DateTime nextTime = DateTime.Now; ;
           // String filter = "startNUmber=" + SeriesNumber;
            String filter = "SeriesNumber='" + SeriesName+"'";
            DataView custDV = new DataView(DataSetValues.Tables["AllValues"], filter, "SeriesNumber", DataViewRowState.CurrentRows);
            chartX.ChartAreas[0].AxisX.ScaleView.Size = custDV.Count;
            chartY.ChartAreas[0].AxisX.ScaleView.Size = custDV.Count;
            chartZ.ChartAreas[0].AxisX.ScaleView.Size = custDV.Count;
           // stc = "Series" + SeriesNumber.ToString();
            stc = SeriesName;
            int i = 0;
            if (chartX.Series.FindByName(stc) == null)
            {
                chartX.Series.Add(stc);
                chartX.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

                foreach (DataRowView catDRV in custDV)
                {
                    if (i == 0)
                    {
                        pointTime = 0;
                        nextTime = Convert.ToDateTime(catDRV[4]);
                    }
                    else
                    {
                        pointTime = pointTime + (Convert.ToDateTime(catDRV[4]) - nextTime).TotalMilliseconds;
                        nextTime = Convert.ToDateTime(catDRV[4]);
                    }
                    this.chartX.Series[stc].Points.AddXY(i, System.Convert.ToSingle(Convert.ToDouble(catDRV[0])));
                    int countPoints = custDV.Count;
                    int devPoints = countPoints / 5;

                    if (i % devPoints == 0)
                    {
                        chartX.ChartAreas[0].AxisX.CustomLabels.Add(i - 25, i + 25, Convert.ToString(Math.Round((pointTime / 1000), 1)), 0, LabelMarkStyle.None);
                    }

                    i++;

                }
            }
            if (chartY.Series.FindByName(stc) == null)
            {
                chartY.Series.Add(stc);
                chartY.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                i = 0;
                foreach (DataRowView catDRV in custDV)
                {
                    if (i == 0)
                    {
                        pointTime = 0;
                        nextTime = Convert.ToDateTime(catDRV[4]);
                    }
                    else
                    {
                        pointTime = pointTime + (Convert.ToDateTime(catDRV[4]) - nextTime).TotalMilliseconds;
                        nextTime = Convert.ToDateTime(catDRV[4]);
                    }
                    this.chartY.Series[stc].Points.AddXY(i, System.Convert.ToSingle(Convert.ToDouble(catDRV[1])));
                    int countPoints = custDV.Count;
                    int devPoints = countPoints / 5;

                    if (i % devPoints == 0)
                    {
                        chartY.ChartAreas[0].AxisX.CustomLabels.Add(i - 25, i + 25, Convert.ToString(Math.Round((pointTime / 1000), 1)), 0, LabelMarkStyle.None);
                    }

                    i++;
                }

            }
            if (chartZ.Series.FindByName(stc) == null)
            {
                chartZ.Series.Add(stc);
                chartZ.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                i = 0;
                foreach (DataRowView catDRV in custDV)
                {
                    if (i == 0)
                    {
                        pointTime = 0;
                        nextTime = Convert.ToDateTime(catDRV[4]);
                    }
                    else
                    {
                        pointTime = pointTime + (Convert.ToDateTime(catDRV[4]) - nextTime).TotalMilliseconds;
                        nextTime = Convert.ToDateTime(catDRV[4]);
                    }
                    this.chartZ.Series[stc].Points.AddXY(i, System.Convert.ToSingle(Convert.ToDouble(catDRV[2])));
                    int countPoints = custDV.Count;
                    int devPoints = countPoints / 5;

                    if (i % devPoints == 0)
                    {
                        chartZ.ChartAreas[0].AxisX.CustomLabels.Add(i - 25, i + 25, Convert.ToString(Math.Round((pointTime / 1000), 1)), 0, LabelMarkStyle.None);
                    }
                    i++;
                }
            }

            float xmid = getValue( dataGrid.Rows[SeriesNumber - 1].Cells[11].Value.ToString() );
            float ymid = getValue(dataGrid.Rows[SeriesNumber - 1].Cells[14].Value.ToString());
            float zmid = getValue(dataGrid.Rows[SeriesNumber - 1].Cells[17].Value.ToString());
            this.chartX.Series["SeriesXMid"].Points.Clear();
            this.chartX.Series["SeriesXMid"].Points.AddXY(0, xmid);
            this.chartX.Series["SeriesXMid"].Points.AddXY(custDV.Count, xmid);
            this.chartY.Series["SeriesYMid"].Points.Clear();
            this.chartY.Series["SeriesYMid"].Points.AddXY(0, ymid);
            this.chartY.Series["SeriesYMid"].Points.AddXY(custDV.Count, ymid);
            this.chartZ.Series["SeriesZMid"].Points.Clear();
            this.chartZ.Series["SeriesZMid"].Points.AddXY(0, zmid);
            this.chartZ.Series["SeriesZMid"].Points.AddXY(custDV.Count, zmid);
            this.chartX.Series["SeriesXMax"].Points.AddXY(0, getValue(dataGrid.Rows[SeriesNumber - 1].Cells[9].Value.ToString()));
            this.chartX.Series["SeriesXMax"].Points.AddXY(custDV.Count,  getValue(dataGrid.Rows[SeriesNumber - 1].Cells[9].Value.ToString()));
            this.chartX.Series["SeriesXMin"].Points.AddXY(0, getValue(dataGrid.Rows[SeriesNumber - 1].Cells[10].Value.ToString()));
            this.chartX.Series["SeriesXMin"].Points.AddXY(custDV.Count,getValue(dataGrid.Rows[SeriesNumber - 1].Cells[10].Value.ToString()));
            this.chartY.Series["SeriesYMax"].Points.AddXY(0, getValue(dataGrid.Rows[SeriesNumber - 1].Cells[12].Value.ToString()));
            this.chartY.Series["SeriesYMax"].Points.AddXY(custDV.Count, getValue(dataGrid.Rows[SeriesNumber - 1].Cells[12].Value.ToString()));
            this.chartY.Series["SeriesYMin"].Points.AddXY(0, getValue(dataGrid.Rows[SeriesNumber - 1].Cells[13].Value.ToString()));
            this.chartY.Series["SeriesYMin"].Points.AddXY(custDV.Count, getValue(dataGrid.Rows[SeriesNumber - 1].Cells[13].Value.ToString()));
            this.chartZ.Series["SeriesZMax"].Points.AddXY(0, getValue(dataGrid.Rows[SeriesNumber - 1].Cells[15].Value.ToString()));
            this.chartZ.Series["SeriesZMax"].Points.AddXY(custDV.Count, getValue(dataGrid.Rows[SeriesNumber - 1].Cells[15].Value.ToString()));
            this.chartZ.Series["SeriesZMin"].Points.AddXY(0, getValue(dataGrid.Rows[SeriesNumber - 1].Cells[16].Value.ToString()));
            this.chartZ.Series["SeriesZMin"].Points.AddXY(custDV.Count, getValue(dataGrid.Rows[SeriesNumber - 1].Cells[16].Value.ToString()));
            this.chartX.ChartAreas[0].AxisY.Maximum = Math.Round(getValue(dataGrid.Rows[SeriesNumber - 1].Cells[9].Value.ToString()) + 0.1, 1);
            this.chartX.ChartAreas[0].AxisY.Minimum = Math.Round(getValue(dataGrid.Rows[SeriesNumber - 1].Cells[10].Value.ToString()) - 0.1, 1);
            chartX.ChartAreas[0].AxisY.Interval = Math.Round((getValue(dataGrid.Rows[SeriesNumber - 1].Cells[9].Value.ToString()) - getValue(dataGrid.Rows[SeriesNumber - 1].Cells[10].Value.ToString())) / 5, 1);
            chartY.ChartAreas[0].AxisY.Interval = Math.Round((getValue(dataGrid.Rows[SeriesNumber - 1].Cells[12].Value.ToString()) - getValue(dataGrid.Rows[SeriesNumber - 1].Cells[13].Value.ToString())) / 5, 1);
            chartZ.ChartAreas[0].AxisY.Interval = Math.Round((getValue(dataGrid.Rows[SeriesNumber - 1].Cells[15].Value.ToString()) - getValue(dataGrid.Rows[SeriesNumber - 1].Cells[16].Value.ToString())) / 5, 1);
            //   this.chartX.ChartAreas[0].AxisY.MaximumAutoSize = 8;
            this.chartY.ChartAreas[0].AxisY.Maximum = Math.Round(getValue(dataGrid.Rows[SeriesNumber - 1].Cells[12].Value.ToString()) + 0.1, 1);
            this.chartY.ChartAreas[0].AxisY.Minimum = Math.Round(getValue(dataGrid.Rows[SeriesNumber - 1].Cells[13].Value.ToString()) - 0.1, 1);
          //  this.chartY.ChartAreas[0].AxisY.MaximumAutoSize = 8;
            this.chartZ.ChartAreas[0].AxisY.Maximum = Math.Round(getValue(dataGrid.Rows[SeriesNumber - 1].Cells[15].Value.ToString()) + 0.1, 1);
            this.chartZ.ChartAreas[0].AxisY.Minimum = Math.Round(getValue(dataGrid.Rows[SeriesNumber - 1].Cells[16].Value.ToString()) - 0.1, 1);
         //   this.chartZ.ChartAreas[0].AxisY.MaximumAutoSize = 8;

            this.chartX.Update();
            this.chartY.Update();
            this.chartZ.Update();
        }

        private float getValue(String s)
        {
            float f = 0; 
            String[] cellValueSplit = s.Split('(');
            float.TryParse(cellValueSplit[0], NumberStyles.Any, CultureInfo.CurrentCulture, out f);
            return f;
        }
        private void сохранитьКакXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsXMLDialog.ShowDialog();
        }

        private void saveAsXMLDialog_FileOk(object sender, CancelEventArgs e)
        {
            DataSetValues.WriteXml(saveAsXMLDialog.FileName);
        }

        private void загрузитьИзXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openXMLDialog.ShowDialog();
        }

        private void openXMLDialog_FileOk(object sender, CancelEventArgs e)
        {
            DataSetValues.Clear();
            DataSetValues.ReadXml(openXMLDialog.FileName);
            LoadAllSeries();
            colorsForGrid();
        }

        private void dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.chartX.Series["SeriesXMax"].Points.Clear();
                this.chartX.Series["SeriesXMin"].Points.Clear();
                this.chartX.Series["SeriesXMid"].Points.Clear();
                this.chartY.Series["SeriesYMax"].Points.Clear();
                this.chartY.Series["SeriesYMin"].Points.Clear();
                this.chartY.Series["SeriesYMid"].Points.Clear();
                this.chartZ.Series["SeriesZMax"].Points.Clear();
                this.chartZ.Series["SeriesZMin"].Points.Clear();
                this.chartZ.Series["SeriesZMid"].Points.Clear();

                while (this.chartX.Series.Count != 3)
                {
                    this.chartX.Series.RemoveAt(3);
                    this.chartY.Series.RemoveAt(3);
                    this.chartZ.Series.RemoveAt(3);
                }
                String srName = dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[1].Value.ToString();
                paintSeries(e.RowIndex + 1,srName);
                if (dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[24].Value != null && dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[25].Value != null)
                {
                    chartX.ChartAreas[0].CursorX.SelectionStart = Convert.ToDouble(dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[24].Value);
                    chartX.ChartAreas[0].CursorX.SelectionEnd = Convert.ToDouble(dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[25].Value);
                    chartY.ChartAreas[0].CursorX.SelectionStart = Convert.ToDouble(dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[24].Value);
                    chartY.ChartAreas[0].CursorX.SelectionEnd = Convert.ToDouble(dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[25].Value);
                    chartZ.ChartAreas[0].CursorX.SelectionStart = Convert.ToDouble(dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[24].Value);
                    chartZ.ChartAreas[0].CursorX.SelectionEnd = Convert.ToDouble(dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[25].Value);
                }
                else
                {
                    chartX.ChartAreas[0].CursorX.SelectionEnd = 0;
                    chartX.ChartAreas[0].CursorX.SelectionStart = 0;
                    chartY.ChartAreas[0].CursorX.SelectionEnd = 0;
                    chartY.ChartAreas[0].CursorX.SelectionStart = 0;
                    chartZ.ChartAreas[0].CursorX.SelectionEnd = 0;
                    chartZ.ChartAreas[0].CursorX.SelectionStart = 0;

                }

            }
        }

        private string ToCSV(DataTable table)
        {
            var result = new StringBuilder();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                result.Append(table.Columns[i].ColumnName);
                result.Append(i == table.Columns.Count - 1 ? "\n" : ",");
            }

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    result.Append(row[i].ToString());
                    result.Append(i == table.Columns.Count - 1 ? "\n" : ",");
                }
            }

            return result.ToString();
        }
        private void экспортВCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsCSVDialog.ShowDialog();
        }

        private void saveAsCSVDialog_FileOk(object sender, CancelEventArgs e)
        {
            DataView custDV = new DataView(DataSetValues.Tables["AllValues"], null, "startNumber", DataViewRowState.CurrentRows);
            string CSV;
            if (custDV.Count > 0)
            {
                CSV = ToCSV(DataSetValues.Tables["AllValues"]);
                try
                {
                    File.WriteAllText(saveAsCSVDialog.FileName, CSV.ToString(), Encoding.Default);
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Error write CSV file. " + e1.ToString());
                }
            }

        }

        private void comBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chartX_SelectionRangeChanged(object sender, System.Windows.Forms.DataVisualization.Charting.CursorEventArgs e)
        {
            double t = 0;
            double startPoint = this.chartX.ChartAreas[0].CursorX.SelectionStart;
            double stopPoint = this.chartX.ChartAreas[0].CursorX.SelectionEnd;
            if (startCounter > 0)
            {
                if (startPoint != stopPoint)
                {
                    if (stopPoint < startPoint)
                    {
                        t = startPoint;
                        startPoint = stopPoint;
                        stopPoint = t;

                    }
                    this.chartY.ChartAreas[0].CursorX.SelectionStart = startPoint;
                    this.chartY.ChartAreas[0].CursorX.SelectionEnd = stopPoint;
                    this.chartZ.ChartAreas[0].CursorX.SelectionStart = startPoint;
                    this.chartZ.ChartAreas[0].CursorX.SelectionEnd = stopPoint;
                    calculateSelection(startPoint, stopPoint, stc);
                    colorsForGrid();
                    dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[24].Value = startPoint;
                    dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[25].Value = stopPoint;
                }
            }
        }

        private void calculateSelection(double start, double stop, String SeriesName)
        {
            double minX = 100;
            double minY = 100;
            double minZ = 100;
            double maxX = -100;
            double maxY = -100;
            double maxZ = -100;
            double sumx = 0;
            double sumy = 0;
            double sumz = 0;
            double skzX = 0;
            double skzY = 0;
            double skzZ = 0;
            String filter = "SeriesNumber='" + SeriesName + "' and Number >" + start + " and number<" + stop;
            DataView custDV = new DataView(DataSetValues.Tables["AllValues"], filter, "startNumber", DataViewRowState.CurrentRows);
            int counter = custDV.Count;
            foreach (DataRowView catDRV in custDV)
            {
                double X = Convert.ToDouble(catDRV[0]);
                double Y = Convert.ToDouble(catDRV[1]);
                double Z = Convert.ToDouble(catDRV[2]);
                sumx = sumx + X * X;
                sumy = sumy + Y * Y;
                sumz = sumz + Z * Z;
                if (X > maxX)
                { maxX = X; }
                if (X < minX)
                {
                    minX = X;
                }
                if (Y > maxY)
                { maxY = Y; }
                if (Y < minY)
                {
                    minY = Y;
                }
                if (Z > maxZ)
                { maxZ = Z; }
                if (Z < minZ)
                {
                    minZ = Z;
                }

            }
            skzX = Math.Sqrt(sumx / counter);
            skzY = Math.Sqrt(sumy / counter);
            skzZ = Math.Sqrt(sumz / counter);
            dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[21].Value = Math.Round(skzX, 2) * 10;
            dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[22].Value = Math.Round(skzY, 2) * 10;
            dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[23].Value = Math.Round(skzZ, 2) * 10;
            dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[18].Value = (Math.Round(maxX - minX, 2)) * 10;
            dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[19].Value = (Math.Round(maxY - minY, 2)) * 10;
            dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[20].Value = (Math.Round(maxZ - minZ, 2)) * 10;
            
        }

        private void chartY_SelectionRangeChanged(object sender, CursorEventArgs e)
        {
            double t = 0;
            double startPoint = this.chartY.ChartAreas[0].CursorX.SelectionStart;
            double stopPoint = this.chartY.ChartAreas[0].CursorX.SelectionEnd;
            if (startCounter > 0)
            {
                if (startPoint != stopPoint)
                {
                    if (stopPoint < startPoint)
                    {
                        t = startPoint;
                        startPoint = stopPoint;
                        stopPoint = t;

                    }
                    this.chartX.ChartAreas[0].CursorX.SelectionStart = startPoint;
                    this.chartX.ChartAreas[0].CursorX.SelectionEnd = stopPoint;
                    this.chartZ.ChartAreas[0].CursorX.SelectionStart = startPoint;
                    this.chartZ.ChartAreas[0].CursorX.SelectionEnd = stopPoint;
                    calculateSelection(startPoint, stopPoint, stc);
                    colorsForGrid();
                    dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[24].Value = startPoint;
                    dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[25].Value = stopPoint;
                }
            }
        }

        private void chartZ_SelectionRangeChanged(object sender, CursorEventArgs e)
        {
            double t = 0;
            double startPoint = this.chartZ.ChartAreas[0].CursorX.SelectionStart;
            double stopPoint = this.chartZ.ChartAreas[0].CursorX.SelectionEnd;
            if (startCounter > 0)
            {
                if (startPoint != stopPoint)
                {
                    if (stopPoint < startPoint)
                    {
                        t = startPoint;
                        startPoint = stopPoint;
                        stopPoint = t;

                    }
                    this.chartX.ChartAreas[0].CursorX.SelectionStart = startPoint;
                    this.chartX.ChartAreas[0].CursorX.SelectionEnd = stopPoint;
                    this.chartY.ChartAreas[0].CursorX.SelectionStart = startPoint;
                    this.chartY.ChartAreas[0].CursorX.SelectionEnd = stopPoint;
                    calculateSelection(startPoint, stopPoint, stc);
                    colorsForGrid();
                    dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[24].Value = startPoint;
                    dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[25].Value = stopPoint;
                }
            }
        }

        private void chartX_SelectionRangeChanging(object sender, CursorEventArgs e)
        {
            selectionChanging(e);
        }

        private void chartX_CursorPositionChanging(object sender, CursorEventArgs e)
        {
            
        }

        private void chartY_SelectionRangeChanging(object sender, CursorEventArgs e)
        {
            selectionChanging(e);
        }

        private void selectionChanging(CursorEventArgs e)
        {
            double startPoint = e.NewSelectionStart;
            double stopPoint = e.NewSelectionEnd;

            if(startPoint <= 0)
            {
                startPoint = 1;
            }
            if (stopPoint <= 0)
            {
                stopPoint = 1;
            }

            if (startCounter > 0)
            {
                int count = chartX.Series[stc].Points.Count();
                if (startPoint > count)
                {
                    startPoint = count;
                }
                if(stopPoint > count)
                {
                    stopPoint = count;
                }
                    String filter = "SeriesNumber='" + stc + "' and Number =" + startPoint;// + " and number =" + stopPoint;
                    DataView custDV = new DataView(DataSetValues.Tables["AllValues"], filter, "startNumber", DataViewRowState.CurrentRows);
                    String selectionString = "";
                    selectionString = custDV[0][4].ToString();
                    filter = "SeriesNumber='" + stc + "' and Number =" + stopPoint;
                    custDV = new DataView(DataSetValues.Tables["AllValues"], filter, "startNumber", DataViewRowState.CurrentRows);
                    selectionString = selectionString + "-" + custDV[0][4].ToString();
                    //  chartX.Titles.Insert(0, new Title(selectionString));
                    if (chartX.Titles.Count == 0)
                    {
                        chartX.Titles.Add(selectionString);
                        chartY.Titles.Add(selectionString);
                        chartZ.Titles.Add(selectionString);
                    }
                    else
                    {
                        chartX.Titles[0].Text = selectionString;
                        chartY.Titles[0].Text = selectionString;
                        chartZ.Titles[0].Text = selectionString;
                    }
                }
            
        }

        private void allSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Setting.Show();
        }

        private void timerTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!_isServerStarted)
            Setting.settings.Timer = timerTextBox.Text;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void chartZ_SelectionRangeChanging(object sender, CursorEventArgs e)
        {
            selectionChanging(e);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    //public class ProgramSetting
    //{
    //    public String Timer = "";
    //    public String Interval = "";
    //    public String minDx = "";
    //    public String minDy = "";
    //    public String minDz = "";
    //    public String countPoint = "";
    //    public String Source = "";
    //    public String UDPPort = "";
    //    public String COMPort = "";
    //    public String PortSpeed = "";
    //    public String FlexInerval = "";
    //}

    
}
