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

namespace Sual79
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
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            public double latitude;
            public double longitude;
            public double altitude;
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
        private void initDataRequest()
        {
            try
            {
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Latitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Longitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Altitude", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
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
                    richTextBox2.Text = "Lat:" + s1.latitude + "\n";
                    richTextBox2.Text += "Lon:" + s1.longitude + "\n";
                    richTextBox2.Text += "Alt:" + s1.altitude + "\n";
                    break;

                default:
                    richTextBox2.Text = "Unknown request ID: " + data.dwRequestID;
                    break;
            }
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
                    initDataRequest();
                    richTextBox1.Text = "Connected\n\n";
                }
                catch (COMException ex)
                {
                    richTextBox1.Text = "Unable to connect to Prepar3D:\n";
                }
            }
            else
            {
                simconnect.Dispose();
                simconnect = null;
                richTextBox1.Text = "Connection closed \n\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simconnect.RequestDataOnSimObjectType(DATA_REQUEST.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
        }
    }
}