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
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Sual93
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        SpeechRecognitionEngine engine1 = new SpeechRecognitionEngine();
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
            ELEVATOR_DOWN, ELEVATOR_UP,
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
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.ELEVATOR_UP, "ELEVATOR_UP");
                simconnect.MapClientEventToSimEvent(EVENT_CTRL1.ELEVATOR_DOWN, "ELEVATOR_DOWN");
            }
            catch (COMException ex)
            {
                richTextBox1.Text = richTextBox1.Text + ex.Message;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            engine1.SetInputToDefaultAudioDevice();
            Choices ch1 = new Choices();
            ch1.Add(new string[] { "up", "down" });
            GrammarBuilder GB1 = new GrammarBuilder();
            GB1.Append(ch1);
            Grammar g = new Grammar(GB1);
            engine1.LoadGrammarAsync(g);
            engine1.SpeechRecognized += Engine1_SpeechRecognized;
            engine1.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void Engine1_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string command = e.Result.Text;
            if (e.Result.Text == "up")
            {
                simconnect.TransmitClientEvent(0, EVENT_CTRL1.ELEVATOR_UP, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            }
            else if (e.Result.Text == "down")
            {
                simconnect.TransmitClientEvent(0, EVENT_CTRL1.ELEVATOR_DOWN, 1, GROUP_IDS.GROUP_1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            }
        }
    }
}
