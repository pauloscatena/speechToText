using System.Collections.Generic;
using System.IO;
using speech.berger.Domain.Interfaces.Services;
using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.SpeechToText.v1;

namespace speech.berger.Domain
{
    public class WatsonSpeechService : ISpeechService
    {
        string apikey = "{apiKey da IBM}";
        string url = "{URL da IBM}";

        public string SyncRecognize(byte[] bytes)
        {
            IamAuthenticator authenticator = new IamAuthenticator(
                apikey: apikey);

            SpeechToTextService service = new SpeechToTextService(authenticator);
            service.SetServiceUrl(url);

            var result = service.Recognize(
                audio: bytes,
                contentType: "audio/ogg");
            return result.Response;
        }
    }
}