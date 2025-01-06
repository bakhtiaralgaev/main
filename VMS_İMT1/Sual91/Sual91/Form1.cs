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

namespace Sual91
{
    public partial class Form1 : Form
    {
        double currentThrottle = 0;
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
        enum EVENT_IDS
        {
            THROTTLE_INCR,
        }
        enum GROUP_IDS
         {
             GROUP_1,
         }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            public double ThrottlePosition; // Throttle dəyəri (0-100%)
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
                    simconnect = new SimConnect("Throttle Control", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    CinitDataRequest();
                    initThrottleRequest();
                    richTextBox1.Text = "Connected to Prepar3D";
                    timer1.Enabled = true;
                    currentThrottle = 0;
                }
                catch (COMException ex)
                {
                    richTextBox1.Text += "Unable to connect to Prepar3D: \n\n" + ex.Message;
                }
            }
            else
            {
                timer1.Enabled = false;
                simconnect.Dispose();
                simconnect = null;
                richTextBox1.Text = "Connection closed.";
            }
        }
        private void initThrottleRequest()
        {
            try
            {
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1,"GENERAL ENG THROTTLE LEVER POSITION:1","percent",SIMCONNECT_DATATYPE.FLOAT64,0.0f,SimConnect.SIMCONNECT_UNUSED);
                simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);
                simconnect.RequestDataOnSimObject(DATA_REQUEST.REQUEST_1,DEFINITIONS.Struct1,SimConnect.SIMCONNECT_OBJECT_ID_USER,SIMCONNECT_PERIOD.SIM_FRAME,SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT,0,0,0);
                simconnect.OnRecvSimobjectData += new SimConnect.RecvSimobjectDataEventHandler(simconnect_OnThrottleReceived);
            }
            catch (COMException ex)
            {
                richTextBox1.Text += "Throttle oxuma xəta: " + ex.Message;
            }
        }
        private void simconnect_OnThrottleReceived(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            if ((DATA_REQUEST)data.dwRequestID == DATA_REQUEST.REQUEST_1)
            {
                // Məlumatı oxuyur
                Struct1 throttleData = (Struct1)data.dwData[0];
                // Throttle dəyərini double formatında yazır
                label2.Text = throttleData.ThrottlePosition.ToString();
                double a = throttleData.ThrottlePosition;
            }
        }


        private void CinitDataRequest()
        {
            try
            {
                simconnect.MapClientEventToSimEvent(EVENT_IDS.THROTTLE_INCR, "THROTTLE_INCR");
            }
            catch (COMException ex)
            {
                richTextBox1.Text += "Xəta: " + ex.Message;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (simconnect == null)
            {
                timer1.Enabled = false;
                MessageBox.Show("SimConnect bağlantısı yoxdur. Zəhmət olmasa əvvəlcə bağlanın.");
                return;
            }
            string a = label2.Text;
            if ( Convert.ToDouble(a) >= 75)
            {
                timer1.Enabled = false;
                MessageBox.Show("Throttle 75%-ə çatdı");
                return;
            }
            else
            {
                simconnect.TransmitClientEvent(0, EVENT_IDS.THROTTLE_INCR, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            }          

        }

    }
}