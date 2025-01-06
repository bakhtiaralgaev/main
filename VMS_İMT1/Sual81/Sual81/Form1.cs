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
using System.Reflection.Emit;
using System.IO;
using System.Speech.Synthesis;

namespace Sual81
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        enum DEFINITIONS
        {
            Struct1,
        }
        enum DATA_REQUEST
        {
            REQUEST_1,
        };
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
                    initDataRequest();
                    richTextBox1.Text = "Connected";
                    timer1.Enabled = true;
                    timer2.Enabled = true;
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
                richTextBox1.Text = "Connection closed \n";
            }            
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            public double altitude;
        };
        private void initDataRequest()
        {
            try
            {
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "PLANE ALTITUDE", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);
                simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(simconnect_Onreceivedata);
            }
            catch (COMException ex)
            {
                richTextBox2.Text = "ex.Message";
            }
        }
        void simconnect_Onreceivedata(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {
            switch ((DATA_REQUEST)data.dwRequestID)
            {
                case DATA_REQUEST.REQUEST_1:
                    Struct1 s1 = (Struct1)data.dwData[0];
                    richTextBox2.Text = s1.altitude.ToString();
                    if (s1.altitude <= 110)
                    {
                        label5.Text = " ";
                    }
                    else if (s1.altitude < Convert.ToDouble(textBox1.Text))
                    {
                        label5.Text = "Pull up";
                    }
                    else if ((s1.altitude > Convert.ToDouble(textBox1.Text)) && (s1.altitude < Convert.ToDouble(textBox2.Text)))
                    {
                        label5.Text = " ";
                    }
                    else if (s1.altitude > Convert.ToDouble(textBox2.Text))
                    {
                        label5.Text = "Pull down";
                    }
                    break;
                default:
                    richTextBox1.Text = "Unknown request ID: " + data.dwRequestID;
                    break;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            synth.SpeakAsync(label5.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            simconnect.RequestDataOnSimObjectType(DATA_REQUEST.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
        }
    }
}
