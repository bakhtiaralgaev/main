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

namespace Sual90
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
        enum DEFINITIONS
        {
            Struct1,
        }
        enum DATA_REQUEST
        {
            REQUEST_1,
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
                    simconnect = new SimConnect("Altitude Display", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    initDataRequest();
                    richTextBox1.Text = "Connected to Prepar3D";
                    timer1.Enabled = true;
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
                richTextBox1.Text = "Connection closed.";
            }
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            public double BarometricAltitude;
            public double RadioAltitude;
        };
        private void initDataRequest()
        {
            try
            {
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "PLANE ALTITUDE", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED); // Barometrik hündürlük
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "RADIO HEIGHT", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);   // Radio hündürlük

                simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);
                simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(simconnect_Onreceivedata);
            }
            catch (COMException ex)
            {
                richTextBox1.Text += "Data definition error: " + ex.Message;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            simconnect.RequestDataOnSimObjectType(DATA_REQUEST.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
        }
        void simconnect_Onreceivedata(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {
            switch ((DATA_REQUEST)data.dwRequestID)
            {
                case DATA_REQUEST.REQUEST_1:
                    Struct1 s1 = (Struct1)data.dwData[0];
                    label2.Text = s1.BarometricAltitude.ToString();
                    label4.Text = s1.RadioAltitude.ToString();
                    break;
                default:
                    richTextBox1.Text = "Unknown request ID: " + data.dwRequestID;
                    break;
            }
        }
    }
}