using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using LockheedMartin.Prepar3D.SimConnect;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Sual89
{
    public partial class Form1 : Form
    {
        OleDbConnection con1 = new OleDbConnection();
        string constr1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Zenoxid\\Desktop\\Dərs\\VMS\\GPS.accdb";
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
        enum DEFINITIONS
        {
            Struct1,
        };
        enum DATA_REQUESTS
        {
            Request_1,
        };
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            public double latitude;
            public double longitude;

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
        private void initDataRequest()
        {
            try
            {
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Latitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Longitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);
                simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(simconnect_Onreceivedata);
            }
            catch (COMException ex)
            {
                richTextBox1.Text = "ex.Message";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (simconnect == null)
            {
                try
                {
                    simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    initDataRequest();
                    richTextBox1.Text = "Connected";
                    con1 = new OleDbConnection(constr1);
                    con1.Open();
                    string sql2 = "DELETE FROM [Details]";
                    OleDbCommand com2 = new OleDbCommand(sql2, con1);
                    com2.ExecuteNonQuery();
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                }
                catch (COMException ex)
                {
                    richTextBox1.Text = "Unable to connect to Prepar3D: \n\n" + ex.Message;
                }
            }
            else
            {
                simconnect.Dispose();
                simconnect = null;
                richTextBox1.Text = "Connection closed \n";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            con1 = new OleDbConnection(constr1);
            con1.Open();
            try
            {
                string details = "Insert into Details(Latitude, Longtitude) values(@lat, @long)";
                OleDbCommand com1 = new OleDbCommand(details, con1);
                com1.Parameters.Add("@lat", richTextBox2.Text);
                com1.Parameters.Add("@long", richTextBox3.Text);
                com1.ExecuteNonQuery();
                MessageBox.Show("oldi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void simconnect_Onreceivedata(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {
            try
            {
                switch ((DATA_REQUESTS)data.dwRequestID)
                {
                    case DATA_REQUESTS.Request_1:
                        Struct1 s1 = (Struct1)data.dwData[0];
                        richTextBox2.Text = s1.latitude.ToString();
                        richTextBox3.Text = s1.longitude.ToString();
                        break;
                    default:
                        richTextBox1.Text += "Unknown request ID: " + data.dwRequestID;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            simconnect.RequestDataOnSimObjectType(DATA_REQUESTS.Request_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
        }
    }
}