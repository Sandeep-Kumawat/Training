using System;

namespace ExpressionTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Func<int, int> Square = (x) => x * x;
            //Func<int, int> Square = (x) => {return x * x;};
            //Console.WriteLine(Square(7));
            Func<int, int> Square = (x) => x * x;
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);
            var a = e.Compile();
            Console.WriteLine(a(7));



        }
    }
}
