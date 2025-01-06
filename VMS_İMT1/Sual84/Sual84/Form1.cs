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
using System.IO;
using System.Speech.Synthesis;
using System.Reflection.Emit;

namespace Sual84
{
    public partial class Form1 : Form
    {
        SimConnect simconnect = null;
        const int WM_USER_SIMCONNECT = 0x0402;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (simconnect == null)
            {
                try
                {
                    simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    richTextBox1.Text = "Connected";
                    synth.SpeakAsync("Connected");

                }
                catch (COMException ex)
                {
                    richTextBox1.Text += "Unable to connect to Prepar3D: \n\n" + ex.Message;
                    synth.SpeakAsync("Attention! Unable to connect to Prepar3D");
                }
            }
            else
            {
                simconnect.Dispose();
                simconnect = null;
                richTextBox1.Text = "Connection closed \n";
                synth.SpeakAsync("Attention! Disconnected from Prepar3D");
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
    }
}
