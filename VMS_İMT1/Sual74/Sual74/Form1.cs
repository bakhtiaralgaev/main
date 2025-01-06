using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using LockheedMartin.Prepar3D.SimConnect;
using System.Runtime.InteropServices;

namespace Sual74
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;
        SimConnect simconnect = null;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        SpeechRecognitionEngine engine1 = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            engine1.SetInputToDefaultAudioDevice();
            Choices ch1 = new Choices();
            ch1.Add(new string[] { "Connect", "Disconnect" });
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
            if (e.Result.Text == "Connect")
            {                
                if (simconnect == null)
                {
                    try
                    {
                        simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
                        richTextBox1.Text = "Connected\n\n";
                        label2.Text = "Connected";
                    }
                    catch (COMException ex)
                    {
                        richTextBox1.Text = "Unable to connect to Prepar3D:\n";
                        label2.Text = "Not Connected";
                    }
                }
            }
            else if (e.Result.Text == "Disconnect")
            {
                {
                    simconnect.Dispose();
                    simconnect = null;
                    richTextBox1.Text = "Connection closed \n\n";
                    label2.Text = "Disconnected";
                }
            }
            synth.Speak(label2.Text);
            synth.Dispose();
            synth = new SpeechSynthesizer();
        }
    }
}
