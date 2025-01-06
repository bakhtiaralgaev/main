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

namespace Sual102
{
    public partial class Form1 : Form
    {
        SimConnect simconnect = null;
        const int WM_USER_SIMCONNECT = 0x0402;
        double a, b;
        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                if (simconnect != null)
                {
                    simconnect.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }
        enum EVENT_CTRL1
        {
            ZULU_HOURS_SET, KEY_ZULU_DAY_SET, SITUATION_RESET, ENGINE_AUTO_START, ENGINE_AUTO_SHUTDOWN,
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
                richTextBox1.Text = "Connection Closed\n";
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

        private void Nightbutton_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.ZULU_HOURS_SET, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }

        private void Daybutton_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.ZULU_HOURS_SET, 0, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }

        private void Connectbutton_Click(object sender, EventArgs e)
        {
            if (simconnect == null)
            {
                try
                {
                    simconnect = new SimConnect("Sim1", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    richTextBox1.Text = "Connected To P3D \n";
                    CinitDataRequest();
                }
                catch (COMException ex)
                {
                    richTextBox1.Text = "Unable to connect to Prepar3D:\n\n" + ex.Message;
                }
            }
            else
            {
                closeConnection();
            }
        }

        private void Restartbutton_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.SITUATION_RESET, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }

        private void Shutdownbutton_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.ENGINE_AUTO_SHUTDOWN, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.ENGINE_AUTO_START, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }

        private void CinitDataRequest()
        {
            try
            {
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.ZULU_HOURS_SET, "ZULU_HOURS_SET");
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.SITUATION_RESET, "SITUATION_RESET");
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.ENGINE_AUTO_START, "ENGINE_AUTO_START");
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.ENGINE_AUTO_SHUTDOWN, "ENGINE_AUTO_SHUTDOWN");
            }
            catch (COMException ex)
            {
                richTextBox1.Text = richTextBox1.Text + ex.Message;
            }
        }
    }
}
