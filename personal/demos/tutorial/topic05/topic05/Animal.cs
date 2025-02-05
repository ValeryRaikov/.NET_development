using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic05
{
    // 03. Constuctors
    class Animal
    {
        // 04. Static modifier
        public static int numberOfAnimals = 0;

        public String ownerName;
        public int age;

        public Animal(String ownerName, int age)
        {
            this.ownerName = ownerName;
            this.age = age;
            numberOfAnimals++;
        }

        // 05. Overloaded constructor
        public Animal(String ownerName)
        {
            this.ownerName = ownerName;
            numberOfAnimals++;
        }

        public Animal(int age)
        {
            this.age = age;
            numberOfAnimals++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Owner: {ownerName}, age: {age}");
        } 
    }
}
