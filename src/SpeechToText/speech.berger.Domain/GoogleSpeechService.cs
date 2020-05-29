using speech.berger.Domain.Interfaces.Services;
using System;
using Google.Cloud.Speech.V1;

namespace speech.berger.Domain
{
    public class GoogleSpeechService: ISpeechService
    {
        public string SyncRecognize(byte[] bytes)
        {
            System.Diagnostics.Debug.Print($"Credenciais Google: [{Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS")}]");

            string text = string.Empty;
            var speech = SpeechClient.Create();
            var response = speech.Recognize(new RecognitionConfig()
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                LanguageCode = "pt-br",
            }, RecognitionAudio.FromBytes(bytes));
            foreach (var result in response.Results)
            {
                foreach (var alternative in result.Alternatives)
                {
                    text += alternative.Transcript;
                }
            }
            return text;
        }
    }
}