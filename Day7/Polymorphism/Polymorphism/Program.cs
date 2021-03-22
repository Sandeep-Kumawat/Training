using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                  new Rectangle(),
                  new Circle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            //Person p = new Person();
            //p.display("Sandeep", 24);
            //p.ToString();
        }
    }
}
