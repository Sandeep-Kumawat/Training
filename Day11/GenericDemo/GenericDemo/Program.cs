using System;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass<int> intobj = new TestClass<int>();
            intobj.Add(5);
            intobj.Add(6);
            intobj.Add(7);
            intobj.Add(8);
            intobj.Add(9);

            TestClass<Product> productobj = new TestClass<Product>();
            productobj.Add(new Product
            {
                Id = 1,
                Title="Car",
                Price = 250000
            });
            productobj.Add(new Product
            {
                Id = 2,
                Title = "bat",
                Price = 250
            });
            productobj.Add(new Product
            {
                Id = 3,
                Title = "Ball",
                Price = 25
            });
            productobj.Add(new Product
            {
                Id = 4,
                Title = "Book",
                Price = 250
            });
            productobj.Add(new Product
            {
                Id = 5,
                Title = "bottle",
                Price = 20
            });

            for (int i=0;i<5;i++)
            {
                Console.WriteLine(intobj[i]);
                
               
            }
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine(productobj[i].ToString());

            }
            Product p1 = new Product
            {
                Price = 20
            };
            Product p2 = new Product
            {
                Price = 50
            };
            Console.WriteLine($"Before Swap P1={p1.Price} and p2={p2.Price}");
            ProductSwap<Product>(ref p1, ref p2);
            Console.WriteLine($"After Swap P1={p1.Price} and p2={p2.Price}");


        }
        static void ProductSwap<T>(ref T a,ref T b)   // Generic Method
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
