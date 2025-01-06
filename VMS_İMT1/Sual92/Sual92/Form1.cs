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

namespace Sual92
{
    public partial class Form1 : Form
    {
        SimConnect simconnect = null;
        const int WM_USER_SIMCONNECT = 0x0402;
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
                    simconnect = new SimConnect("Sim1", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    richTextBox1.Text = richTextBox1.Text + "Connected To P3D \n";

                }
                catch (COMException ex)
                {
                    richTextBox1.Text = richTextBox1.Text + "Unable to connect to Prepar3D:\n\n" + ex.Message;
                }
            }
            else
            {
                closeConnection();
            }
        }
        private void closeConnection()
        {
            if (simconnect != null)
            {
                simconnect.Dispose();
                simconnect = null;
                richTextBox1.Text = richTextBox1.Text + "Connection Closed\n";
            }
        }

        private void Disconnectbutton_Click(object sender, EventArgs e)
        {
            closeConnection();
        }
    }
}
