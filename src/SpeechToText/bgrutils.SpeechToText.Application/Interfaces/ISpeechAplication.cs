using bgrutils.SpeechToText.Application.ViewModels;

namespace bgrutils.SpeechToText.Application.Interfaces
{
    public interface ISpeechApplication
    {
         string SyncRecognize(SpeechViewModel data);
    }
}