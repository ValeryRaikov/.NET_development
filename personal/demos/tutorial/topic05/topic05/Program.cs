using System;

namespace topic05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Messages.Hello();
            Messages.Hello("Valery");
            Messages.Wait();
            Console.Write("Enter your data: ");
            String data = Console.ReadLine();
            Console.WriteLine(Messages.PrintData(data));

            TestClass.Info();
            */

            // 02. Simple Objects
            Person p1 = new Person();

            p1.name = "Valery";
            p1.age = 21;
            p1.gender = 'M';

            p1.Eat();
            p1.Sleep();

            Person p2 = new Person();
            p2.name = "Meggie";
            p2.age = 19;
            p2.gender = 'F';

            p2.Eat();
            p2.Sleep();

            Animal a1 = new Animal("Ivan", 4);
            Animal a2 = new Animal("Dragan", 7);
            a1.DisplayInfo();
            a2.DisplayInfo();
            Console.WriteLine("Total animals registered: " + Animal.numberOfAnimals);

            Animal a3 = new Animal("Meggie");
            Animal a4 = new Animal(6);
            a3.DisplayInfo();
            a4.DisplayInfo();
            Console.WriteLine("Total animals registered: " + Animal.numberOfAnimals);
        }
    }

    // 01. Classes
    static class Messages
    {
        public static void Hello(String name = "User")
        {
            Console.WriteLine($"Hello, {name}");
        }

        public static void Wait()
        {
            Console.WriteLine("Waiting for commands...");
        }

        public static String PrintData(String data)
        {
            return (data != "") ? $"-> {data}" : "No data provided!";
        }
    }
}
