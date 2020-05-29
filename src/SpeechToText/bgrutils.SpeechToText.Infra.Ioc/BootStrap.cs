using System;
using bgrutils.SpeechToText.Application;
using bgrutils.SpeechToText.Application.Interfaces;
using bgrutils.SpeechToText.Domain;
using bgrutils.SpeechToText.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace bgrutils.SpeechToText.Infra.Ioc
{
    public static class BootStrap
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddTransient<ISpeechApplication, SpeechApplication>();
            services.AddTransient<ISpeechService, GoogleSpeechService>();
            services.AddTransient<IAudioConverterService, OggAudioConverterService>();
            services.AddTransient<IDownloadService, DownloadService>();
        }
    }
}
