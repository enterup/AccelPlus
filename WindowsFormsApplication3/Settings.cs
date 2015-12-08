using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication3
{
    public partial class SettingsForm: Form
    {
        public ProgramSetting settings;
        public SettingsForm()
        {
            InitializeComponent();
            settings = new ProgramSetting();
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;
            String delimeter = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            String delMask = "0.00";
            dxMaskedBox.Mask = delMask;
            dyMaskedBox.Mask = delMask;
            dzMaskedBox.Mask = delMask;
            foreach (String st in SerialPort.GetPortNames())
            {
                comBox.Items.Add(st);
            }
            try
            {
                 using (Stream stream = new FileStream("settings.xml", FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(ProgramSetting));
                        settings = (ProgramSetting)serializer.Deserialize(stream);
                        if (settings.Source == "UDP")
                        {
                            portBox.Text = settings.UDPPort;
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
                            boudRateBox.Text = settings.PortSpeed;
                            comBox.Text = settings.COMPort;
                        }
                        if (settings.minDx != "")
                        {
                            try
                            {
                                Double test = Convert.ToDouble(settings.minDx);
                                dxMaskedBox.Text = settings.minDx;
                            }
                            catch (Exception e)
                            {
                                dxMaskedBox.Text = Convert.ToString(12.0 / 100.0);
                            }


                        }
                        if (settings.minDy != "")
                        {
                            try
                            {
                                Double test = Convert.ToDouble(settings.minDy);
                                dyMaskedBox.Text = settings.minDy;
                            }
                            catch (Exception e)
                            {
                                dyMaskedBox.Text = Convert.ToString(6.0 / 100.0);
                            }

                        }
                        if (settings.minDz != "")
                        {
                            try
                            {
                                Double test = Convert.ToDouble(settings.minDz);
                                dzMaskedBox.Text = settings.minDz;
                            }
                            catch (Exception e)
                            {
                                dzMaskedBox.Text = Convert.ToString(6.0 / 100.0);
                            }

                        }
                        if (settings.Timer != "")
                        {
                            timerTextBox.Text = settings.Timer;
                        }
                        else
                        {
                            timerTextBox.Text = "30";
                            settings.Timer = "30";
                        }
                        if (settings.FlexInerval != "")
                        {
                            flexBox.Text = settings.FlexInerval;
                        }
                        else
                        {
                            flexBox.Text = "3";
                            settings.FlexInerval = "3";
                        }
                        if (settings.countPoint != "0")
                        {
                            intervalMaskedBox.Text =settings.countPoint;
                        }
                        else
                        {
                            intervalMaskedBox.Text = "300";
                             settings.countPoint = "300";
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
                    settings.minDx = Convert.ToString(12.0 / 100.0);
                    settings.minDy = Convert.ToString(6.0 / 100.0);
                    settings.minDz = Convert.ToString(6.0 / 100.0);
                    settings.Timer = "30";
                    settings.FlexInerval = "3";
                    settings.PortSpeed = "38400";
                    settings.Source = "UDP";
                    settings.UDPPort = "5555";
                    
                    comBox.Text = "COM3";
                    dxMaskedBox.Text = Convert.ToString(12.0 / 100.0);
                    dyMaskedBox.Text = Convert.ToString(6.0 / 100.0);
                    dzMaskedBox.Text = Convert.ToString(6.0 / 100.0);
                    intervalMaskedBox.Text  = "300";
                    settings.countPoint = "300";

                }
            }

       


        private void Settings_Load(object sender, EventArgs e)
        {
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            settings.COMPort = this.comBox.Text;
            settings.minDx = this.dxMaskedBox.Text;
            settings.minDy = this.dyMaskedBox.Text;
            settings.minDz = this.dzMaskedBox.Text;
            settings.countPoint = this.intervalMaskedBox.Text;
            settings.PortSpeed = this.boudRateBox.Text;
            settings.UDPPort = this.portBox.Text;
            settings.FlexInerval = this.flexBox.Text;
            
            if (udpRadio.Checked)
            {
                settings.Source = "UDP";
            }
            else
            {
                settings.Source = "Serial";
            }
            settings.Timer = this.timerTextBox.Text;
            Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void udpRadio_CheckedChanged(object sender, EventArgs e)
        {
            comBox.Hide();
            boudRateBox.Hide();
            label3.Hide();
            portBox.Show();
        }

        private void serialRadio_CheckedChanged(object sender, EventArgs e)
        {
            comBox.Show();
            boudRateBox.Show();
            portBox.Hide();
            label3.Show();
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
