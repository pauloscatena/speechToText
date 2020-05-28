using System.Collections.Generic;
using System.IO;
using bgrutils.SpeechToText.Domain.Interfaces.Services;
using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.SpeechToText.v1;

namespace bgrutils.SpeechToText.Domain
{
    public class WatsonSpeechService : ISpeechService
    {
        string apikey = "NTE4s9PMeTivjWVpQ-w7oVHkPBpjt4E9S8vdY34mLzgq";
        string url = "https://api.us-south.speech-to-text.watson.cloud.ibm.com/instances/6722418d-dc8d-43c6-9335-6f603c010be2";

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