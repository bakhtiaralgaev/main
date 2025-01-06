using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LockheedMartin.Prepar3D.SimConnect;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Sual103
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
        public Form1()
        {
            InitializeComponent();
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
        private void Cavokbutton_Click(object sender, EventArgs e)
        {
            simconnect.WeatherSetObservation(1, "GLOB CAVOK");
            simconnect.WeatherSetModeCustom();
            simconnect.WeatherSetModeGlobal();
        }

        private void SetWeatherbutton_Click(object sender, EventArgs e)
        {
            if (wspeed.Text == "")
            {
                wspeed.Text = "0";
                wdirection.Text = "0";
            }
            //Kill all on screen keyboards
            Process[] oskProcessArray = Process.GetProcessesByName("TabTip");
            foreach (Process onscreenProcess in oskProcessArray)
            {
                onscreenProcess.Kill();
            }
            string prec = "", turb = "", wshear = "G", gust = "", gustspeed = "";
            //turbulence
            if (comboBox_turb.Text == "NONE")
                turb = "N";
            if (comboBox_turb.Text == "LIGHT")
                turb = "L";
            if (comboBox_turb.Text == "MODERATE")
                turb = "M";
            if (comboBox_turb.Text == "HEAVY")
                turb = "H";
            if (comboBox_turb.Text == "SEVER")
                turb = "S";
            //precipitation
            if (comboBox_prec.Text == "NONE")
                prec = "";
            if (comboBox_prec.Text == "SNOW")
                prec = "+SN";
            if (comboBox_prec.Text == "RAIN")
                prec = "+RA";
            //windshear
            if (comboBox_wshear.Text == "NONE")
                wshear = "G";
            if (comboBox_wshear.Text == "MODERATE")
                wshear = "M";
            if (comboBox_wshear.Text == "STEEP")
                wshear = "S";
            if (comboBox_wshear.Text == "INSTANTANEOUS")
                wshear = "T";
            if (wdirection.Text.Length < 2 & wdirection.Text.Length > 0)
                wdirection.Text = "00" + wdirection.Text;
            if (wdirection.Text.Length < 3 & wdirection.Text.Length > 0)
                wdirection.Text = "0" + wdirection.Text;
            if (wspeed.Text.Length < 2 & wspeed.Text.Length > 0)
                wspeed.Text = "0" + wspeed.Text;
            simconnect.WeatherSetModeGlobal();
            simconnect.WeatherSetObservation(1, "GLOB 030405Z" + " " + wdirection.Text + wspeed.Text + "KT&D5800" + turb + wshear + " " + visibilty.Text + "SM" + " " + prec + " " + "BKN262 M10/ 00 A2992");
        }
    }
}
