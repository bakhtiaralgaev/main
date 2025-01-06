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

namespace Sual101
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
        public Form1()
        {
            InitializeComponent();
        }
        enum DEFINITIONS
        {
            Struct1,
        }
        enum DATA_REQUEST
        {
            REQUEST_1,
        };
        enum EVENT_CTRL1
        {
            MIXTURE_SET,
        }
        enum GROUP_IDS
        {
            GROUP_1,
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
        private void Connectbutton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (simconnect == null)
            {
                try
                {
                    simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    CinitDataRequest();
                    initDataRequest();
                    richTextBox1.Text = "Connected";
                }
                catch (COMException ex)
                {
                    richTextBox1.Text = "Unable to connect to Prepar3D:\n\n" + ex.Message;
                }
            }
            else
            {
                simconnect.Dispose();
                simconnect = null;
                richTextBox1.Text = "Connection closed";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = trackBar_Mix.Value.ToString(); 
            simconnect.RequestDataOnSimObjectType(DATA_REQUEST.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
            simconnect.SetDataOnSimObject(DEFINITIONS.Struct1, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_DATA_SET_FLAG.DEFAULT, new Struct1 { GENERAL_ENG_MIXTURE_LEVER_POSITION = trackBar_Mix.Value });
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            public double GENERAL_ENG_MIXTURE_LEVER_POSITION;
        };
        private void CinitDataRequest()
        {
            try
            {
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.MIXTURE_SET, "MIXTURE_SET");
            }
            catch (COMException ex)
            {
                richTextBox1.Text = richTextBox1.Text + ex.Message;
            }
        }
        private void initDataRequest()
        {
            try
            {
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "GENERAL ENG MIXTURE LEVER POSITION:1", "percent", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
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
                    richTextBox2.Text = "Mixture: " + s1.GENERAL_ENG_MIXTURE_LEVER_POSITION;
                    //trackBar_Mix.Value = Convert.ToInt32(s1.GENERAL_ENG_MIXTURE_LEVER_POSITION);
                    break;

                default:
                    richTextBox2.Text = "Unknown request ID: " + data.dwRequestID;
                    break;
            }
        }
    }
}
