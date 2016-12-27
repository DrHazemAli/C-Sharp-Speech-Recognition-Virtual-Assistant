using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
namespace VirtualAssistant
{
    // ------------------------------------------------------------------//
    // * Written By Dr. Hazem Ali
    // * FB : facebook.com/Haz4m
    // * License : FREE
    // * SHARING IS SEXY, PLEASE SHARE IT WITH OTHERS, ENJOY =:)
    // ------------------------------------------------------------------//
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            sre.SpeechRecognized += sre_SpeechRecognized;
        }
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        DictationGrammar gr = new DictationGrammar();
        Grammar CustomizedGrammer()
        {

            var choices = new Choices();
            //add custom commands
            choices.Add(File.ReadAllLines(@"Commands.txt"));
            //to add the letters to the dictionary
            choices.Add(Enum.GetNames(typeof(Keys)).ToArray());

            var grammer = new Grammar(new GrammarBuilder(choices));

            return grammer;
        }
        void Speak(string feedBackText)
        {
            if (!String.IsNullOrWhiteSpace(feedBackText))
            {
                synthesizer.SpeakAsync(feedBackText);
                txtChat.AppendText(String.Format("{0} : {1}", "\r\nComputer", feedBackText));
                
            }
            else { Console.WriteLine("feedBack Text is Empty"); }
        }
        void getResponse(string orgText)
        {
            ProgVoice.Value = 100;
            txtChat.AppendText("\r\n-------------[ " + DateTime.Now.ToString() + " ]-------------\r\n");
            txtChat.AppendText("\r\nMe : " + orgText);
            if (orgText == "hi" || orgText == "hello")
            {
                Speak("Hello!");
            }
            if (orgText == "what is your name")
            {
                Speak("My name is Siri!");
            }
            if (orgText == "minimize")
            {
                Speak("Alright!");
                this.WindowState = FormWindowState.Minimized;
            }
            if (orgText == "what time is it")
            {
                Speak("It's " + DateTime.Now.ToString());
            }

          
            Speak("What was that again ?");
            btnSpeak.Text = "Speak!";
            txtChat.AppendText("\r\n");

        }
        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                sre.RecognizeAsyncCancel();
                sre.RecognizeAsyncStop();
                getResponse(e.Result.Text.ToLower());
                btnSpeak.Text = "Speak!";
                return;

            }
            catch(Exception er) {
                Console.WriteLine(er.Message);
               
            }
           
        }
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (btnSpeak.Text == "Speak!")
            {
               
                ProgVoice.Value = 0;
                sre.RecognizeAsync(RecognizeMode.Multiple);
                btnSpeak.Text = "Stop!";
                return;
            }
            else
            {
                btnSpeak.Text = "Speak!";
                sre.RecognizeAsyncStop();
                return;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                sre.SetInputToDefaultAudioDevice();
                sre.LoadGrammar(gr);
                sre.LoadGrammar(CustomizedGrammer());
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
