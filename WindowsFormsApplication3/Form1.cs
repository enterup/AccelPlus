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

        public MainForm()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;
            String delimeter = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            //String delMask = "0" + delimeter + "00";
            String delMask = "0.00";
            InitializeComponent();
            dxMaskedBox.Mask = delMask;
            dyMaskedBox.Mask = delMask;
            dzMaskedBox.Mask = delMask;
           //  dxMaskedBox.Mask = "";
            foreach (String st in SerialPort.GetPortNames())
            {
                comBox.Items.Add(st);
            }
            //Load configuration from settings.xml file
            configuration = new ProgramSetting();
            try
            {
                using (Stream stream = new FileStream("settings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ProgramSetting));
                    configuration = (ProgramSetting)serializer.Deserialize(stream);
                    if (configuration.Source == "UDP")
                    {
                        portBox.Text = configuration.UDPPort;
                        comBox.Hide();
                        boudRateBox.Hide();
                        portBox.Show();
                        label3.Hide();
                    }
                    else
                    {
                        comBox.Show();
                        boudRateBox.Show();
                        portBox.Hide();
                        label3.Show();
                        serialRadio.Checked = true;
                        boudRateBox.Text = configuration.PortSpeed;
                        comBox.Text = configuration.COMPort;
                    }
                    if (configuration.minDx != "")
                    {
                        try
                        {
                            Double test = Convert.ToDouble(configuration.minDx);
                            dxMaskedBox.Text = configuration.minDx;
                        }
                        catch(Exception e)
                        {
                            dxMaskedBox.Text = Convert.ToString(12.0 / 100.0);
                        }
                        

                    }
                    if (configuration.minDy != "")
                    {
                        try
                        {
                            Double test = Convert.ToDouble(configuration.minDy);
                            dyMaskedBox.Text = configuration.minDy;
                        }
                        catch (Exception e)
                        {
                            dyMaskedBox.Text = Convert.ToString(6.0 / 100.0);
                        }

                    }
                    if (configuration.minDz != "")
                    {
                        try
                        {
                            Double test = Convert.ToDouble(configuration.minDz);
                            dzMaskedBox.Text = configuration.minDz;
                        }
                        catch (Exception e)
                        {
                            dzMaskedBox.Text = Convert.ToString(6.0 / 100.0);
                        }

                    }
                    if (configuration.Timer != "")
                    {
                        timerTextBox.Text = configuration.Timer;
                    }
                    if (configuration.FlexInerval != "")
                    {
                        flexBox.Text = configuration.FlexInerval;
                    }
                    if (configuration.countPoint != "0")
                    {
                        numberOfPoints = Convert.ToInt32(configuration.countPoint);
                    }
                    else
                    {
                        numberOfPoints = 300;
                    }
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                comBox.Hide();
                boudRateBox.Hide();
                portBox.Show();
                label3.Hide();
                boudRateBox.Text = "38400";
                comBox.Text = "COM3";
                dxMaskedBox.Text = Convert.ToString(6.0 / 100.0);
                dyMaskedBox.Text = Convert.ToString(6.0 / 100.0);
                dzMaskedBox.Text = Convert.ToString(6.0 / 100.0);
                numberOfPoints = 300;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
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

            if (udpRadio.Checked)
            {
                configuration.Source = "UDP";
                configuration.UDPPort = portBox.Text;
            }
            else
            {
                configuration.Source = "Serial";
                configuration.PortSpeed = boudRateBox.Text;
                configuration.COMPort = comBox.Text;
            }
            configuration.minDx = dxMaskedBox.Text;
            configuration.minDy = dyMaskedBox.Text;
            configuration.minDz = dzMaskedBox.Text;
            configuration.Timer = timerTextBox.Text;
            configuration.FlexInerval = flexBox.Text;
            configuration.countPoint = numberOfPoints.ToString();
            try
            {
                using (System.IO.Stream writer = new FileStream("settings.xml", FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ProgramSetting));
                    serializer.Serialize(writer, configuration);
                }
            }
            catch (Exception e)
            {

            }
        }
        private void Start()
        {


            if (_isServerStarted == false)
            {


                //Create the server.
                if (udpRadio.Checked)
                {
                    Int32 portNumber = Convert.ToInt32(portBox.Text);
                    IPEndPoint serverEnd = new IPEndPoint(IPAddress.Any, 5555);
                    _server = new UdpClient(serverEnd);

                    //Create the client end.
                    _client = new IPEndPoint(IPAddress.Any, 0);
                }
                else
                {
                    try
                    {
                        comPort.BaudRate = Convert.ToInt32(boudRateBox.Text);
                        comPort.PortName = comBox.Text;
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
                minDx = Convert.ToDouble(dxMaskedBox.Text);
                minDy = Convert.ToDouble(dyMaskedBox.Text);
                minDz = Convert.ToDouble(dzMaskedBox.Text);
                timerNew = new System.Windows.Forms.Timer();
                timerNew.Tick += new EventHandler(TimerEventProcessor);
                timerNew.Interval = 1000;
                timerNew.Start();
                startCounter++;
                stc = "Series" + startCounter.ToString();
                chartX.Series.Add(stc);
                chartX.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartY.Series.Add(stc);
                chartY.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chartZ.Series.Add(stc);
                chartZ.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                timerC = Int16.Parse(timerTextBox.Text);
                origTimer = timerC;
                // }
                //Start listening.
                //Thread 
                _listenThread = new Thread(new ThreadStart(Listening));
                _listenThread.Start();
                //Change state to indicate the server starts.
                _isServerStarted = true;
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
                if (udpRadio.Checked)
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
                    this.DataSetValues.Tables["AllValues"].LoadDataRow(new Object[] { fx, fy, fz, counterXY, DateTime.Now, startCounter }, false);
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
                    if (udpRadio.Checked)
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
                { SendMsg("Server stops. Error.", 0, 0, 0, 0); }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Stop();
            if (_isServerStarted == true && counterXY!=0)
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
                int length = System.Convert.ToInt16(flexBox.Text);

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
                this.chartX.ChartAreas[0].AxisY.Maximum = maxX + 0.1;
                this.chartX.ChartAreas[0].AxisY.Minimum = minX - 0.1;
                this.chartX.ChartAreas[0].AxisY.MaximumAutoSize = 8;

                this.chartY.Series["SeriesYMax"].Points.AddXY(0, maxY);
                this.chartY.Series["SeriesYMax"].Points.AddXY(numberOfPoints, maxY);
                this.chartY.Series["SeriesYMin"].Points.AddXY(0, minY);
                this.chartY.Series["SeriesYMin"].Points.AddXY(numberOfPoints, minY);
                this.chartY.Series["SeriesYMid"].Points.AddXY(0, ymid);
                this.chartY.Series["SeriesYMid"].Points.AddXY(numberOfPoints, ymid);
                this.chartY.ChartAreas[0].AxisY.Maximum = maxY + 0.1;
                this.chartY.ChartAreas[0].AxisY.Minimum = minY - 0.1;
                this.chartY.ChartAreas[0].AxisY.MaximumAutoSize = 8;

                this.chartZ.Series["SeriesZMax"].Points.AddXY(0, maxZ);
                this.chartZ.Series["SeriesZMax"].Points.AddXY(numberOfPoints, maxZ);
                this.chartZ.Series["SeriesZMin"].Points.AddXY(0, minZ);
                this.chartZ.Series["SeriesZMin"].Points.AddXY(numberOfPoints, minZ);
                this.chartZ.Series["SeriesZMid"].Points.AddXY(0, zmid);
                this.chartZ.Series["SeriesZMid"].Points.AddXY(numberOfPoints, zmid);
                this.chartZ.ChartAreas[0].AxisY.Maximum = maxZ + 0.1;
                this.chartZ.ChartAreas[0].AxisY.Minimum = minZ - 0.1;
                this.chartZ.ChartAreas[0].AxisY.MaximumAutoSize = 8;
                
                String[] row = new String[18];
                row[0] = DateTime.Now.ToString();
                row[1] = stc;
                row[2] = counter.ToString(); ;
                row[3] =(Math.Round(xMaxModValue,3)*10).ToString();
                row[4] = (Math.Round(yMaxModValue, 3) * 10).ToString();
                row[5] = (Math.Round(zMaxModValue, 3) * 10).ToString();
                row[6] = (Math.Round(divMinFlexMidX,3)*10).ToString();
                row[7] = (Math.Round(divMinFlexMidY,3)*10).ToString();
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

                if (startCounter > 1)
                {
                    colorsForGrid();
                }

                chartModX.Series["Series1"].Points.AddXY(DateTime.Now.ToString(), xMaxModValue);
                chartModY.Series["Series1"].Points.AddXY(DateTime.Now.ToString(), yMaxModValue);
                chartModZ.Series["Series1"].Points.AddXY(DateTime.Now.ToString(), zMaxModValue);


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
                timerNew.Stop();
                timerTextBox.Text = origTimer.ToString();
              

            }
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
            //comBox.Hide();
            //boudRateBox.Hide();
            //portBox.Show();
            //label3.Hide();
            //boudRateBox.Text = "38400";
            //comBox.Text = "COM3";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comBox.Show();
            boudRateBox.Show();

            portBox.Hide();
            label3.Show();
        }

        private void udpRadio_CheckedChanged(object sender, EventArgs e)
        {
            comBox.Hide();
            boudRateBox.Hide();
            label3.Hide();
            portBox.Show();
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
                chartModX.Series["Series1"].Points.Clear();
                chartModY.Series["Series1"].Points.Clear();
                chartModZ.Series["Series1"].Points.Clear();
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

            if (timerC == 0)
            {
                stopButton_Click(myObject, myEventArgs);
                timerTextBox.Text = origTimer.ToString();
            }
            else
            {
                timerTextBox.Text = timerC.ToString();
                timerC = timerC - 1;
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
            if (e.Axis.AxisName == System.Windows.Forms.DataVisualization.Charting.AxisName.X)
            {
                int start = (int)e.Axis.ScaleView.ViewMinimum;
                int end = (int)e.Axis.ScaleView.ViewMaximum;



                double[] temp = chartX.Series[0].Points.Where((x, i) => i >= start && i <= end).Select(x => x.YValues[0]).ToArray();
                double ymin = temp.Min();
                double ymax = temp.Max();

                chartX.ChartAreas[0].AxisY.ScaleView.Position = ymin;
                chartX.ChartAreas[0].AxisY.ScaleView.Size = ymax - ymin;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_isServerStarted)
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
            chartModX.Series["Series1"].Points.Clear();
            chartModY.Series["Series1"].Points.Clear();
            chartModZ.Series["Series1"].Points.Clear();
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
            int length = System.Convert.ToInt16(flexBox.Text);
            String filter = "startNUmber=" + seriesNumber;
            DataView custDV = new DataView(DataSetValues.Tables["AllValues"], filter, "startNumber", DataViewRowState.CurrentRows);
            int counter = custDV.Count;
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
            //row[0] = DateTime.Now.ToString();
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

            chartModX.Series["Series1"].Points.AddXY(DateTime.Now.ToString(), xMaxModValue);
            chartModY.Series["Series1"].Points.AddXY(DateTime.Now.ToString(), yMaxModValue);
            chartModZ.Series["Series1"].Points.AddXY(DateTime.Now.ToString(), zMaxModValue);

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

        private void colorsForGrid()
        {
            float localMinX = 100;
            int rowMinX = -1;
            int rowMinY = -1;
            int rowMinZ = -1;
            float localMinY = 100;
            float localMinZ = 100;

            float f = 0;
            String cellValue = "";
            for(int i = 3; i<dataGrid.Columns.Count;i++)
            {
                for(int j=0;j<dataGrid.Rows.Count;j++)
                {
                    cellValue = dataGrid.Rows[j].Cells[i].Value.ToString();
                    float.TryParse(cellValue, NumberStyles.Any, CultureInfo.CurrentCulture, out f);
                    if (f < localMinX)
                    {
                        localMinX = f;
                        if (rowMinX > -1)
                        {
                            dataGrid.Rows[rowMinX].Cells[i].Style.BackColor = Color.OrangeRed;
                        }
                        rowMinX = j;
                        dataGrid.Rows[j].Cells[i].Style.BackColor = Color.Green;

                    }
                    else
                    {
                        dataGrid.Rows[j].Cells[i].Style.BackColor = Color.OrangeRed;
                    }
                }
                localMinX = 100;
                rowMinX = -1;
            }
          }



        private void paintSeries(int SeriesNumber)
        {
            float minX = 100;
            float minY = 100;
            float minZ = 100;
            float maxX = -100;
            float maxY = -100;
            float maxZ = -100;
            int length = System.Convert.ToInt16(flexBox.Text);

            String filter = "startNUmber=" + SeriesNumber;
            DataView custDV = new DataView(DataSetValues.Tables["AllValues"], filter, "startNumber", DataViewRowState.CurrentRows);
            stc = "Series" + SeriesNumber.ToString();
            int i = 0;
            if (chartX.Series.FindByName(stc) == null)
            {
                chartX.Series.Add(stc);
                chartX.Series[stc].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                foreach (DataRowView catDRV in custDV)
                {
                    this.chartX.Series[stc].Points.AddXY(i, System.Convert.ToSingle(Convert.ToDouble(catDRV[0])));
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
                    this.chartY.Series[stc].Points.AddXY(i, System.Convert.ToSingle(Convert.ToDouble(catDRV[1])));
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
                    this.chartZ.Series[stc].Points.AddXY(i, System.Convert.ToSingle(Convert.ToDouble(catDRV[2])));
                    i++;
                }
            }

            float xmid = Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[11].Value);
            float ymid = Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[14].Value);
            float zmid = Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[17].Value);
            this.chartX.Series["SeriesXMid"].Points.Clear();
            this.chartX.Series["SeriesXMid"].Points.AddXY(0, xmid);
            this.chartX.Series["SeriesXMid"].Points.AddXY(custDV.Count, xmid);
            this.chartY.Series["SeriesYMid"].Points.Clear();
            this.chartY.Series["SeriesYMid"].Points.AddXY(0, ymid);
            this.chartY.Series["SeriesYMid"].Points.AddXY(custDV.Count, ymid);
            this.chartZ.Series["SeriesZMid"].Points.Clear();
            this.chartZ.Series["SeriesZMid"].Points.AddXY(0, zmid);
            this.chartZ.Series["SeriesZMid"].Points.AddXY(custDV.Count, zmid);
            this.chartX.Series["SeriesXMax"].Points.AddXY(0, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[9].Value));
            this.chartX.Series["SeriesXMax"].Points.AddXY(custDV.Count, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[9].Value));
            this.chartX.Series["SeriesXMin"].Points.AddXY(0, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[10].Value));
            this.chartX.Series["SeriesXMin"].Points.AddXY(custDV.Count, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[10].Value));
            this.chartY.Series["SeriesYMax"].Points.AddXY(0, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[12].Value));
            this.chartY.Series["SeriesYMax"].Points.AddXY(custDV.Count, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[12].Value));
            this.chartY.Series["SeriesYMin"].Points.AddXY(0, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[13].Value));
            this.chartY.Series["SeriesYMin"].Points.AddXY(custDV.Count, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[13].Value));
            this.chartZ.Series["SeriesZMax"].Points.AddXY(0, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[15].Value));
            this.chartZ.Series["SeriesZMax"].Points.AddXY(custDV.Count, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[15].Value));
            this.chartZ.Series["SeriesZMin"].Points.AddXY(0, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[16].Value));
            this.chartZ.Series["SeriesZMin"].Points.AddXY(custDV.Count, Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[16].Value));
            this.chartX.ChartAreas[0].AxisY.Maximum = Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[9].Value) + 0.1;
            this.chartX.ChartAreas[0].AxisY.Minimum = Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[10].Value) - 0.1;
            this.chartX.ChartAreas[0].AxisY.MaximumAutoSize = 8;

            this.chartY.ChartAreas[0].AxisY.Maximum = Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[12].Value) + 0.1;
            this.chartY.ChartAreas[0].AxisY.Minimum = Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[13].Value) - 0.1;
            this.chartY.ChartAreas[0].AxisY.MaximumAutoSize = 8;
            this.chartZ.ChartAreas[0].AxisY.Maximum = Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[15].Value) + 0.1;
            this.chartZ.ChartAreas[0].AxisY.Minimum = Convert.ToSingle(dataGrid.Rows[SeriesNumber - 1].Cells[16].Value) - 0.1;
            this.chartZ.ChartAreas[0].AxisY.MaximumAutoSize = 8;
            this.chartX.Update();
            this.chartY.Update();
            this.chartZ.Update();
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
                paintSeries(e.RowIndex + 1);
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
                try {
                    File.WriteAllText(saveAsCSVDialog.FileName, CSV.ToString(), Encoding.Default);
                }
                catch(Exception e1)
                {
                    MessageBox.Show("Error write CSV file. "+ e1.ToString());
                }
            }
            
        }

        private void comBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
    }
    public class ProgramSetting
    {
        public String Timer = "";
        public String Interval = "";
        public String minDx = "";
        public String minDy = "";
        public String minDz = "";
        public String countPoint = "";
        public String Source = "";
        public String UDPPort = "";
        public String COMPort = "";
        public String PortSpeed = "";
        public String FlexInerval = "";
    }

    
}
