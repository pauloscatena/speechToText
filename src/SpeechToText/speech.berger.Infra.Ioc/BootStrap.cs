using System;
using speech.berger.Application;
using speech.berger.Application.Interfaces;
using speech.berger.Domain;
using speech.berger.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace speech.berger.Infra.Ioc
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
