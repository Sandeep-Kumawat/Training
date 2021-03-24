using System;

namespace UseCaseDelegate
{
    class Program
    {
        //delegate void Del(string str);
        public delegate void del();
        static void Main(string[] args)
        {
            Email em = new Email();
            Phone ph = new Phone();
            Text tx = new Text();

            del d = em.CallByEmail;
            d += tx.CallByText;
            d();



           // Del d = new Del(CallByEmail);
           // d += CallByPhone;
            //d += CallByText;
            //d("Work Complete");

        }
        //static void CallByEmail(string a)
        //{
        //    Console.WriteLine($"Notification received By Email:{a}");
        //}
        //static void CallByPhone(string a)
        //{
        //    Console.WriteLine($"Notification received By Phone:{a}");
        //}
        //static void CallByText(string a)
        //{
        //    Console.WriteLine($"Notifition received By Text:{a}");
        //}
    }
}
