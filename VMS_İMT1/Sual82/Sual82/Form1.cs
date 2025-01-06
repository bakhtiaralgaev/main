using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LockheedMartin.Prepar3D.SimConnect;

namespace Sual82
{
    public partial class Form1 : Form
    {
        private SimConnect simConnect = null;
        private const int WM_USER_SIMCONNECT = 0x0402;
        private enum DataRequest
        {
            Request_1
        }
        private struct YokePositionData
        {
            public double aileron;  // Yoke-un sağa-sola dönüş açıları
        }
        public Form1()
        {
            InitializeComponent();
        }
        // Connect to Prepar3D
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                simConnect = new SimConnect("Yoke Position Monitor", Handle, WM_USER_SIMCONNECT, null, 0);

                // Aileron (yoke) pozisyonunu oxumaq üçün abunə oluruq
                simConnect.AddToDataDefinition(DataRequest.Request_1, "AILERON POSITION", "position", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.RegisterDataDefineStruct<YokePositionData>(DataRequest.Request_1);

                // Hər saniyə məlumat sorğusu göndər
                simConnect.RequestDataOnSimObject(
                    DataRequest.Request_1,
                    DataRequest.Request_1,
                    SimConnect.SIMCONNECT_OBJECT_ID_USER,
                    SIMCONNECT_PERIOD.SECOND,
                    SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT,
                    0, 0, 0
                );

                yokePositionLabel.Text = "Connected to Prepar3D";
                simConnect.OnRecvSimobjectData += SimConnect_OnRecvSimobjectData;
            }
            catch (Exception ex)
            {
                yokePositionLabel.Text = $"Connection Error: {ex.Message}";
            }
        }
        // Disconnect from Prepar3D
        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (simConnect != null)
            {
                simConnect.Dispose();
                simConnect = null;
                yokePositionLabel.Text = "Disconnected";
            }
        }
        // Handle incoming SimConnect messages
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                simConnect?.ReceiveMessage();
            }
            base.WndProc(ref m);
        }
        // Receive data from SimConnect
        private void SimConnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            if (data.dwRequestID == (uint)DataRequest.Request_1)
            {
                YokePositionData yokeData = (YokePositionData)data.dwData[0];
                yokePositionLabel.Text = $"Yoke Position: {yokeData.aileron:F2}";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void yokePositionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
