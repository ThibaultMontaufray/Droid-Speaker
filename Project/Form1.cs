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

namespace Droid_Speaker
{
    public partial class Form1 : Form
    {
        private AutomaticSpeechRecognition ASR;
        private DateTime _warningDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
        private DateTime _exitDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 10, 0);
        private Timer _timer;

        public Form1()
        {

            InitializeComponent();
            ASR = new AutomaticSpeechRecognition(ref this.recoText, ref this.commandText, ref this.devine, ref this.affiche, ref this.confidenceText);
            this.KeyPress += ActivateASR;

            PromptBuilder builder = new PromptBuilder();

            builder.StartSentence();
            builder.AppendText("Bonjour Monsieur, il est " + DateTime.Now.Hour + " heures " + DateTime.Now.Minute);
            builder.EndSentence();

            //int minutesLeft = (_exitDate - DateTime.Now).Minutes;
            //if (minutesLeft > 0)
            //{
            //    builder.StartSentence();
            //    builder.AppendText("Il vous reste " + minutesLeft + " minutes avant de partir");
            //    builder.EndSentence();
            //}
            //else
            //{
            //    builder.StartSentence();
            //    builder.AppendText("Vous devriez être partis depuis " + (minutesLeft*-1) + " minutes");
            //    builder.EndSentence();
            //}
            //SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            //synthesizer.Speak(builder);
            //synthesizer.Dispose();

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();

            PromptBuilder builder = new PromptBuilder();

            int minutesLeft = (_warningDate - DateTime.Now).Minutes;
            if (minutesLeft == 0)
            {
                builder.StartSentence();
                builder.AppendText("Monsieur vous devez vous préparer ...");
                builder.EndSentence();
                builder.StartSentence();
                builder.AppendText("il est " + DateTime.Now.Hour + " heures " + DateTime.Now.Minute);
                builder.EndSentence();
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Speak(builder);
                synthesizer.Dispose();
            }
            else
            {
                minutesLeft = (_exitDate - DateTime.Now).Minutes;
                if (minutesLeft == 0)
                {
                    builder.StartSentence();
                    builder.AppendText("Vous devez partir monsieur");
                    builder.EndSentence();
                    builder.StartSentence();
                    builder.AppendText("il est " + DateTime.Now.Hour + " heures " + DateTime.Now.Minute);
                    builder.EndSentence();
                    SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                    synthesizer.Speak(builder);
                    synthesizer.Dispose();
                }
                else
                {
                    _timer.Start();
                }
            }
        }

        /// <summary>
        /// Active la reconnaissance vocale lors de la pression sur la touche
        /// espace pour une séquence de commande
        /// </summary>
        private void ActivateASR(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                try
                {
                    //Activation de la reconnaissance vocale pour une commande
                    ASR.ASREngine.RecognizeAsync(RecognizeMode.Single);
                }
                catch { }
            }
        }

    }
}