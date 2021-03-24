using System;

namespace RealTimeDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaStorage ms = new MediaStorage();
            AudioPlayer ap = new AudioPlayer();
            VideoPlayer vp = new VideoPlayer();

            MediaStorage.PlayerMedia playerDelegate = ap.playAudioFile;
            //ms.ReportResult(playerDelegate, "Mp3");
            playerDelegate += vp.playVideoFile;
            //playerDelegate = vp.playVideoFile;
            ms.ReportResult(playerDelegate, "mp4");
        }
    }
}
