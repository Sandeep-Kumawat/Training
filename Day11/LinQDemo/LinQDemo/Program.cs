using System;
using System.Collections.Generic;
using System.Linq;
namespace LinQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product
            {
                Id = 1,
                Title="bOOK",
                Price=300,
                Owner="Sandeep"

            });
            list.Add(new Product
            {
                Id = 2,
                Title = "bOat",
                Price = 3000,
                Owner = "Pradeep"

            });
            list.Add(new Product
            {
                Id = 3,
                Title = "Car",
                Price = 500,
                Owner = "Kuldeep"

            });
            list.Add(new Product
            {
                Id = 4,
                Title = "Ball",
                Price = 250,
                Owner = "Ritik"

            });
            list.Add(new Product
            {
                Id = 5,
                Title = "Bat",
                Price = 30,
                Owner = "Asif"

            });
            //var owner = list.Where(p => p.Price > 300).Select(p => p.Owner).ToList();  //using Lambda
            //owner.ForEach(owner => Console.WriteLine(owner));

            //var owner1 = from p in list where p.Price > 300 select p.Owner; //using Linq
            //owner1.ToList().ForEach(o => Console.WriteLine(o));

           var Data = list.Where(p => p.Price > 300).Select((p)=>(p.Id,p.Owner)); //using Lambda
             Data.ToList().ForEach(d => Console.WriteLine(d));

            var owner1 = from p in list where p.Price > 300 select new { p.Owner,p.Id};//using Linq
            owner1.ToList().ForEach(o => Console.WriteLine(o));

            var owner2 = from p in list where (p.Price > 300 && p.Id==2) select p.Owner;//using Linq
            owner2.ToList().ForEach(o => Console.WriteLine(o));


        }
    }
}
