using System;
using bgrutils.SpeechToText.Application.Interfaces;
using bgrutils.SpeechToText.Application.ViewModels;
using bgrutils.SpeechToText.Domain.Interfaces.Services;

namespace bgrutils.SpeechToText.Application
{
    public class SpeechApplication : ISpeechApplication
    {
        private readonly ISpeechService _speechService;
        public SpeechApplication(ISpeechService speechService)
        {
            _speechService = speechService;
        }
        public string SyncRecognize(SpeechViewModel data)
        {
            var bytes = Convert.FromBase64String(data.Content);
            return _speechService.SyncRecognize(bytes);
        }
    }
}