using System;
using CalculatorLib;
namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator
            {
                Num1 = 9,
                Num2 = 10
            };
            var c1add = c1.Mul();
            Console.WriteLine(c1add);

            String str = new String("sandeep");
            var i=str.wordCount();
            Console.WriteLine(i);
        }
    }
}
