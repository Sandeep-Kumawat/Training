using System;
using System.Collections.Generic;
using System.Text;

namespace RealTimeDelegateDemo
{
    public class VideoPlayer
    {
        private int videoPlayerStatus;
        public int playVideoFile(string extensionType)
        {
            if (extensionType != "mp4")
            {
                videoPlayerStatus = -1;
            }
            else
            {
                videoPlayerStatus = 0;
            }
            return videoPlayerStatus;
        }
    }
}
