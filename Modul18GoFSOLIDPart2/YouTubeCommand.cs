using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul18GoFSOLIDPart2
{
    internal class YouTubeCommand : ICommand
    {
        YouTube youtube;
        string url;

        public YouTubeCommand(YouTube youtube, string url)
        {
            this.youtube = youtube;
            this.url = url;
        }

        public void Execute()
        {
            youtube.GetTitle(url);
            youtube.GetDownload(url);
        }

        public void Undo()
        {

        }
    }
}
