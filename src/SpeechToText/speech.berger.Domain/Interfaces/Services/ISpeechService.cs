namespace speech.berger.Domain.Interfaces.Services
{
    public interface ISpeechService
    {
         string SyncRecognize(byte[] bytes);
    }
}