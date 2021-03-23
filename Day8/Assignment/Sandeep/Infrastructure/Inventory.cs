using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Core;
namespace Infrastructure
{
    public class Inventory
    {
        static ArrayList list = new ArrayList();
        public void AddProduct(string title,decimal price,string color)
        {
            list.Add(new Product
            {
                Title = title,
                Price = price,
                Color = color
            });
        }

        static Inventory()
        {
             list.Add(new Product
            {
                Title = "Pencil",
                Price = 20,
                Color = "Black"
            });
            list.Add(new Product
            {
                Title = "Book",
                Price = 200,
                Color = "White"
            });
            list.Add(new Product
            {
                Title = "Bat",
                Price = 350,
                Color = "white"
            });
            list.Add(new Product
            {
                Title = "Ball",
                Price = 50,
                Color = "Red"
            });
            list.Add(new Product
            {
                Title = "MX",
                Price = 600,
                Color = "Blue"
            });

        }
        public override string ToString()
        {
            string str = "\nTitle\tPrice\tColor";
            foreach (Product p in list)
            {
                str += "\n" + p.Title + "\t" + p.Price + "\t" + p.Color;
            }
            return str;
        }

    }
}
