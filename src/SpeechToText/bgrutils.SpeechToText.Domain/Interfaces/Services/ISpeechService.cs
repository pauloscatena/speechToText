namespace bgrutils.SpeechToText.Domain.Interfaces.Services
{
    public interface ISpeechService
    {
         string SyncRecognize(byte[] bytes);
    }
}