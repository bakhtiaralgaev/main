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

namespace Sual72
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
        int i = 0;
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
                    richTextBox1.Text = "Connected";
                    timer1.Enabled = true;
                }
                catch (COMException ex)
                {
                    richTextBox1.Text = "Unable to connect to Prepar3D: \n\n" + ex.Message;
                }
            }
        }
        private void closeConnection()
        {
            if (simconnect != null)
            {
                simconnect.Dispose();
                simconnect = null;
                richTextBox1.Text = "Connection Closed\n";
            }
        }
        private void Disconnectbutton_Click(object sender, EventArgs e)
        {
            closeConnection();
            timer1.Enabled = false;
            i = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = i.ToString();
            i++;
        }
    }
}
