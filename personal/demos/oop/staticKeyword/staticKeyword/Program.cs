using System;

namespace staticKeyword
{
    public class Person
    {
        public static int PopulationCounter { get; set; } = 0;
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
            PopulationCounter++;
        }
    }

    public class Calculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Valery");
            Person p2 = new Person("Meggie");
            Person p3 = new Person("Ivan");

            Console.WriteLine(Person.PopulationCounter);

            Calculator c1 = new Calculator();
            Console.WriteLine($"Sum is: {c1.Sum(5, 10)}");
            Console.WriteLine($"Mult is: {Calculator.Multiply(5, 10)}");
        }
    }
}
