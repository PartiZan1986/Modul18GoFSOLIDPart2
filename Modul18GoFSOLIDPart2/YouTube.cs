using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Modul18GoFSOLIDPart2
{
    internal class YouTube
    {
        async public void GetTitle(string url)
        {
            Console.WriteLine("Введите путь для сохранения видео...");
            string path = @"D:\BackUP";

            var youtubeclient = new YoutubeClient();

            var videotitle = await youtubeclient.Videos.GetAsync(url);
            var streamManifest = await youtubeclient.Videos.Streams.GetManifestAsync(videotitle.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            var fileName = $"{videotitle.Title}.{streamInfo.Container}";
            var filePath = Path.Combine(path, fileName);
            await youtubeclient.Videos.Streams.DownloadAsync(streamInfo, filePath);

            Console.WriteLine("Скачивание завершено");
        }

        public void GetDownload(string url)
        {
            Console.WriteLine("Скачиваю");
        }
    }
}
