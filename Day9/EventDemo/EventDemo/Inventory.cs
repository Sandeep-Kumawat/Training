using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    public class Inventory
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += new Clock.SecondChangeHandler(InventoryHasChanged);
        }
        public void InventoryHasChanged(object theClock,TimeInfoEventArgs ti)
        {
            Console.WriteLine("Inventory Time: {0}:{1}:{2}",
            ti.hour.ToString(),
            ti.minute.ToString(),
            ti.second.ToString());
        }
    }
}
