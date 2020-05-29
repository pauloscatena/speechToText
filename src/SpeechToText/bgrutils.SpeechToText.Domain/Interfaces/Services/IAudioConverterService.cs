namespace bgrutils.SpeechToText.Domain.Interfaces.Services
{
    public interface IAudioConverterService
    {
         string ConvertAudio(string fileName);
    }
}