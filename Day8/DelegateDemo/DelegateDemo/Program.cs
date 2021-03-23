using System;

namespace DelegateDemo
{
    class Program
    {
        delegate void Del(string str);
        static void Main(string[] args)
        {
            foo(7);
            Del d = new Del(Notify);
                d("India");
                d("USA");

            Del d1 = new Del(Notify);
            abc(d1);

            d1 = Greet;
            abc(d1);


           
        }
        static void foo(int a)
        {
            Console.WriteLine(a);
        }
        static void Notify(string a)
        {
            Console.WriteLine($" Notification received for:{a}");
        }
        static void abc(Del d1)
        {
            d1("Japan");
        }
        static void Greet(string a)
        {
            Console.WriteLine($" Greet received for:{a}");
        }
    }
}
