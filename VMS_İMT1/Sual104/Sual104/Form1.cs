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

namespace Sual104
{
    public partial class Form1 : Form
    {
        SimConnect simconnect = null;
        const int WM_USER_SIMCONNECT = 0x0402;
        double a, b;
        enum EVENT_CTRL1
        {
            ZULU_HOURS_SET, KEY_ZULU_DAY_SET,
        }
        enum GROUP_IDS
        {
            GROUP_1,
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
        public Form1()
        {
            InitializeComponent();
        }
        private void Disconnectbutton_Click(object sender, EventArgs e)
        {
            closeConnection();
        }
        private void Connectbutton_Click(object sender, EventArgs e)
        {
            if (simconnect == null)
            {
                try
                {
                    simconnect = new SimConnect("Sim1", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    richTextBox1.Text = richTextBox1.Text + "Connected To P3D \n";
                    CinitDataRequest();
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
        private void Gecebutton_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.ZULU_HOURS_SET, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }
        private void Gunduzbutton_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.ZULU_HOURS_SET, 0, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }
        private void CinitDataRequest()
        {
            try
            {
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.ZULU_HOURS_SET, "ZULU_HOURS_SET");
            }
            catch (COMException ex)
            {
                richTextBox1.Text = richTextBox1.Text + ex.Message;
            }
        }
    }
}
