using System.Diagnostics;
using System.IO;
using bgrutils.SpeechToText.Domain.Interfaces.Services;
using System;
using System.Linq;

namespace bgrutils.SpeechToText.Domain
{
    public class OggAudioConverterService : IAudioConverterService
    {
        public string ConvertAudio(string fileName)
        {
            var convertedFile = $"{Path.GetTempPath()}{Path.DirectorySeparatorChar}{Path.GetFileNameWithoutExtension(fileName)}.wav";
            var os = Environment.OSVersion;
            string converterFile = os.Platform == PlatformID.Unix? "/usr/bin/ffmpeg": "ffmpeg.exe";

            ProcessStartInfo parameters = new ProcessStartInfo();
            parameters.FileName = converterFile;
            parameters.Arguments = $"-i {fileName} {convertedFile}";
            parameters.UseShellExecute = false;
            parameters.CreateNoWindow = true;

            var proc = Process.Start(parameters);
            proc.WaitForExit();

            return convertedFile;
        }
    }
}