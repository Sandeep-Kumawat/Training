using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    public class TimeInfoEventArgs : EventArgs
    {
        public int hour;
        public int minute;
        public int second;

        public TimeInfoEventArgs(int Hour, int Minute, int Second)
        {
            this.hour = Hour;
            this.minute = Minute;
            this.second = Second;
        }
    }
}
