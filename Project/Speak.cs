using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Droid_Speaker
{
    public static class Speak
    {
        private static SpeechSynthesizer _synthetizer;

        static Speak()
        {
            Init();
        }

        public static void Say(string sentense)
        {
            _synthetizer.Speak(sentense);
        }

        private static void Init()
        {
            _synthetizer = new SpeechSynthesizer();
            _synthetizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            //_synthetizer.SelectVoice("Cepstral Do");
            //_synthetizer.SelectVoice("Microsoft Zira Desktop - English (United States)");
            //_synthetizer.SelectVoice("Microsoft Hortense Desktop - French");

            foreach (var v in _synthetizer.GetInstalledVoices().Select(v => v.VoiceInfo))
            {
                Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}",
                  v.Description, v.Gender, v.Age);
            }

            // select male senior (if it exists)
            _synthetizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);

            // select audio device
            _synthetizer.SetOutputToDefaultAudioDevice();
            
        }
    }
}
