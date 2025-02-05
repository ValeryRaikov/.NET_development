using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic05
{
    class Person
    {
        public String name;
        public int age;
        public char gender;

        public void Eat()
        {
            Console.WriteLine(name + " is eating...");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping...");
        }
    }
}
