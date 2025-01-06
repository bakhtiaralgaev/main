using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LockheedMartin.Prepar3D.SimConnect;

namespace Sual78
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
        public Form1()
        {
            InitializeComponent();
        }
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
            ENGINE_AUTO_START, ENGINE_AUTO_SHUTDOWN,
        }
        enum GROUP_IDS
        {
            GROUP_1,
        }
        private void Connectionbutton_Click(object sender, EventArgs e)
        {
            if (simconnect == null)
            {
                try
                {
                    simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    CinitDataRequest();
                    richTextBox1.Text += "Connected";
                }
                catch (COMException ex)
                {
                    richTextBox1.Text += "Unable to connect to Prepar3D: \n\n" + ex.Message;
                }
            }
            else
            {
                simconnect.Dispose();
                simconnect = null;
                richTextBox1.Text += "Connection closed \n";
            }
        }
        private void CinitDataRequest()
        {
            try
            {

                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.ENGINE_AUTO_START, "ENGINE_AUTO_START");
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.ENGINE_AUTO_SHUTDOWN, "ENGINE_AUTO_SHUTDOWN");

            }
            catch (COMException ex)
            {
                richTextBox1.Text = richTextBox1.Text + ex.Message;
            }
        }

        private void Engineoff_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.ENGINE_AUTO_SHUTDOWN, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }

        private void Engineon_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.ENGINE_AUTO_START, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }
    }
}
