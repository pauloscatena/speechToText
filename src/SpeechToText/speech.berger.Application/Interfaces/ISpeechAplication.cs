using speech.berger.Application.ViewModels;

namespace speech.berger.Application.Interfaces
{
    public interface ISpeechApplication
    {
         string SyncRecognize(SpeechViewModel data);
    }
}