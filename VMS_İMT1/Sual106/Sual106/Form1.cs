using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LockheedMartin.Prepar3D.SimConnect;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Sual106
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Connectbutton_Click(object sender, EventArgs e)
        {
            if (simconnect == null)
            {
                try
                {
                    simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    richTextBox1.Text += "Connected to Prepar3D\n";
                }
                catch (COMException ex)
                {
                    richTextBox1.Text += Environment.NewLine + "Error - try again";
                    closeConnection();
                }
            }
        }
        private void Disconnectbutton_Click(object sender, EventArgs e)
        {
            closeConnection();
        }
        private void closeConnection()
        {
            if (simconnect != null)
            {
                simconnect.Dispose();
                simconnect = null;
                richTextBox1.Text = "Connection closed";
            }
        }

        private void SetWeatherbutton_Click(object sender, EventArgs e)
        {
            // Əgər yağıntı seçilməyibsə, default NONE təyin edin
            string precipitationType = comboBox_prec.Text.ToUpper();
            if (string.IsNullOrEmpty(precipitationType))
            {
                precipitationType = "NONE";
            }
            // Yağıntı növünü təyin edin
            string prec = "";
            switch (precipitationType)
            {
                case "NONE":
                    prec = "";
                    break;
                case "SNOW":
                    prec = "+SN";
                    break;
                case "RAIN":
                    prec = "+RA";
                    break;
                default:
                    MessageBox.Show("Naməlum yağıntı növü seçildi.");
                    return;
            }

            try
            {
                // Hava rejimini qlobal olaraq təyin edin
                simconnect.WeatherSetModeGlobal();

                // Müşahidə məlumatını hava şəraitinə tətbiq edin
                string observation = $"GLOB 030405Z 00000KT 10SM {prec} BKN262 M10/00 A2992";
                simconnect.WeatherSetObservation(1, observation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hava şəraiti dəyişdirilə bilmədi: {ex.Message}");
            }
        }

        private void Cavokbutton_Click_1(object sender, EventArgs e)
        {
            simconnect.WeatherSetObservation(1, "GLOB CAVOK");
            simconnect.WeatherSetModeCustom();
            simconnect.WeatherSetModeGlobal();
        }
    }
}
