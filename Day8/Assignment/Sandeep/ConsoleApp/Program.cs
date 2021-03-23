using Infrastructure;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory products = new Inventory();
            Console.WriteLine(products.ToString());
            products.displayProduct(new Core.Product
            {
                Title = "Car",
                Color = "Silver",
                Price = 200000
            });

        }
    }
}