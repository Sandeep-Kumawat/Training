using System;
using System.Collections.Generic;
using System.Text;

namespace RealTimeDelegateDemo
{
    public class AudioPlayer
    {
        private int audioPlayerStatus;
        public int playAudioFile(string extensionType)
        {
            if(extensionType != "mvp")
            {
                audioPlayerStatus = -1;
            }
            else
            {
                audioPlayerStatus = 0;
            }
            return audioPlayerStatus;
        }
    }
}
