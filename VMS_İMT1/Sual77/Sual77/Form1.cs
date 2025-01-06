﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LockheedMartin.Prepar3D.SimConnect;

namespace Sual77
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
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
            AILERONS_LEFT, AILERONS_RIGHT, ELEVATOR_DOWN, ELEVATOR_UP, THROTTLE_FULL,
        }
        enum GROUP_IDS
        {
            GROUP_1,
        }
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
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.AILERONS_LEFT, "AILERONS_LEFT");
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.AILERONS_RIGHT, "AILERONS_RIGHT");
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.ELEVATOR_UP, "ELEVATOR_UP");
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.ELEVATOR_DOWN, "ELEVATOR_DOWN");
            }
            catch (COMException ex)
            {
                richTextBox1.Text = richTextBox1.Text + ex.Message;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.ELEVATOR_UP, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.ELEVATOR_DOWN, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.AILERONS_LEFT, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            simconnect.TransmitClientEvent(0, EVENT_CTRL1.AILERONS_RIGHT, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }
    }
}
