using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegate
{
    public static class SendTypes
    {
        public static bool SendByEmail(Message m)
        {
            Console.WriteLine($"{m.Content} is delivered by email to {m.Address}");
            return true;
        }
        public static bool SendByCar(Message m)
        {
            Console.WriteLine($"{m.Content} is delivered by email to {m.Address}");
            return true;
        }
        public static bool SendByTrain(Message m)
        {
            Console.WriteLine($"{m.Content} is delivered by email to {m.Address}");
            return false;
        }
    }
}
