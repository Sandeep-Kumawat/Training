using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void display(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Console.WriteLine( Name+" is "+Age);
        }
        public override string ToString()
        {
            string str = this.Name + " is " + this.Age + " years old";
            Console.WriteLine(str);
            return (str);
    }


    }
}
