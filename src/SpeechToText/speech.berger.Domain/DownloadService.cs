using System;
using System.IO;
using System.Net;
using speech.berger.Domain.Interfaces.Services;

namespace speech.berger.Domain
{
    public class DownloadService : IDownloadService
    {
        public string DownloadFile(string url)
        {
            using(WebClient client = new WebClient())
            {
                var fileName = $"{Path.GetTempPath()}{Path.DirectorySeparatorChar}{Guid.NewGuid().ToString()}.ogg";
                client.DownloadFile(url, fileName);
                return fileName;
            }
        }
    }
}