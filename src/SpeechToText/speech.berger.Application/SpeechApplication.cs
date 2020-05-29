using System;
using System.IO;
using speech.berger.Application.Interfaces;
using speech.berger.Application.ViewModels;
using speech.berger.Domain.Interfaces.Services;

namespace speech.berger.Application
{
    public class SpeechApplication : ISpeechApplication
    {
        private readonly ISpeechService _speechService;
        private readonly IAudioConverterService _audioConverterService;
        private readonly IDownloadService _downloadService;
        public SpeechApplication(ISpeechService speechService, 
            IAudioConverterService audioConverterService,
            IDownloadService downloadService)
        {
            _speechService = speechService;
            _audioConverterService = audioConverterService;
            _downloadService = downloadService;
        }
        public string SyncRecognize(SpeechViewModel data)
        {
            var file = _downloadService.DownloadFile(data.Url);
            var wav = _audioConverterService.ConvertAudio(file);
            
            var bytes = File.ReadAllBytes(wav); 
            return _speechService.SyncRecognize(bytes);
        }
    }
}