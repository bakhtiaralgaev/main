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

namespace Sual105
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

        private void SetWindbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(wspeed.Text))
            {
                wspeed.Text = "0";
            }
            if (string.IsNullOrEmpty(wdirection.Text))
            {
                wdirection.Text = "0";
            }

            // İstiqamət və sürəti düzgün formatlamaq üçün sıfır əlavə edin
            if (wdirection.Text.Length < 2)
                wdirection.Text = wdirection.Text.PadLeft(3, '0');
            if (wspeed.Text.Length < 2)
                wspeed.Text = wspeed.Text.PadLeft(2, '0');

            try
            {
                // SimConnect vasitəsilə külək parametrlərini yeniləyin
                simconnect.WeatherSetModeGlobal();
                simconnect.WeatherSetObservation(1, $"GLOB 030405Z {wdirection.Text}{wspeed.Text}KT");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Külək dəyişdirilərkən xəta baş verdi: {ex.Message}");
            }
        }
    }
}