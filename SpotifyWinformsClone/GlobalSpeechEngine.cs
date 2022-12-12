using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWinformsClone
{
    public static class GlobalSpeechEngine
    {
        public static bool SpeechEngineActivated { get; set; } = false;
        public static bool JustEnteredForm { get; set; } = true;
        public static SpeechSynthesizer SpeechEngine { get; set; } = new SpeechSynthesizer();

        public static void SpeechStandardProcedures(string textToRead)
        {
            SpeechEngine.SpeakAsyncCancelAll();
            if (!SpeechEngineActivated) return;

            SpeechEngine.SpeakAsync(textToRead);
        }

        public static void EnableOrDisableSpeechEngine()
        {
            SpeechEngine.SpeakAsyncCancelAll();
            if (SpeechEngineActivated)
            {
                SpeechEngineActivated = false;
                SpeechEngine.Speak("Narrator Desabled");
            }

            else
            {
                SpeechEngineActivated = true;
                SpeechEngine.SpeakAsync("Narrator Activated");
            }
        }
    }
}
