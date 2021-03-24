using System;

namespace DelegateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator
            {
                Num1 = 10,
                Num2 = 5
            };
            Calculator.CalDelegate c = cal.add;
            cal.printRes(c);

            c = cal.sub;
            cal.printRes(c);

            c = cal.mul;
            cal.printRes(c);

            c = cal.div;
            cal.printRes(c);
        }

    }
    
}
