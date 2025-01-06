using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LockheedMartin.Prepar3D.SimConnect;
using System.Speech.Synthesis;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Sual109
{
    public partial class Form1 : Form
    {
        SimConnect simconnect = null;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        private SimConnect simConnect = null;
        private const int WM_USER_SIMCONNECT = 0x0402;
        private enum DataRequest
        {
            Request_1
        }
        private struct EngineData
        {
            public double rpm;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                simConnect = new SimConnect("Mooney Bravo RPM Monitor", Handle, WM_USER_SIMCONNECT, null, 0);

                simConnect.AddToDataDefinition(DataRequest.Request_1, "GENERAL ENG RPM:1", "rpm",
                    SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.RegisterDataDefineStruct<EngineData>(DataRequest.Request_1);
                simConnect.RequestDataOnSimObject(
                    DataRequest.Request_1,
                    DataRequest.Request_1,
                    SimConnect.SIMCONNECT_OBJECT_ID_USER,
                    SIMCONNECT_PERIOD.SECOND,
                    SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT,
                    0, 0, 0
                );
                rpmLabel.Text = "Connected to Prepar3D";
                simConnect.OnRecvSimobjectData += SimConnect_OnRecvSimobjectData;
            }
            catch (Exception ex)
            {
                rpmLabel.Text = $"Connection Error: {ex.Message}";
            }
        }
        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (simConnect != null)
            {
                simConnect.Dispose();
                simConnect = null;
                rpmLabel.Text = "Disconnected";
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                simConnect?.ReceiveMessage();
            }
            base.WndProc(ref m);
        }
        private void SimConnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            if (data.dwRequestID == (uint)DataRequest.Request_1)
            {
                EngineData engineData = (EngineData)data.dwData[0];
                rpmLabel.Text = $"Engine RPM: {engineData.rpm:F1}";
                richTextBox1.Text = $" {engineData.rpm:F1}";
            }
        }
        private void connectButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                simConnect = new SimConnect("Mooney Bravo RPM Monitor", Handle, WM_USER_SIMCONNECT, null, 0);
                simConnect.AddToDataDefinition(DataRequest.Request_1, "GENERAL ENG RPM:1", "rpm",
                    SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.RegisterDataDefineStruct<EngineData>(DataRequest.Request_1);
                simConnect.RequestDataOnSimObject(
                    DataRequest.Request_1,
                    DataRequest.Request_1,
                    SimConnect.SIMCONNECT_OBJECT_ID_USER,
                    SIMCONNECT_PERIOD.SECOND,
                    SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT,
                    0, 0, 0
                );

                rpmLabel.Text = "Connected to Prepar3D";
                simConnect.OnRecvSimobjectData += SimConnect_OnRecvSimobjectData;
            }
            catch (Exception ex)
            {
                rpmLabel.Text = $"Connection Error: {ex.Message}";
            }
            timer1.Enabled = true;
        }
        private void disconnectButton_Click_1(object sender, EventArgs e)
        {
            if (simConnect != null)
            {
                simConnect.Dispose();
                simConnect = null;
                rpmLabel.Text = "Disconnected";
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > Convert.ToDouble(richTextBox1.Text))
            {
                synth.SpeakAsync("Warning");
            }
        }
    }
}