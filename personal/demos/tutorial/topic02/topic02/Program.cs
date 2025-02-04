using System;

namespace topic02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01. If statements
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are successfully signed up.");
            } 
            else
            {
                Console.WriteLine("You must be 18+ to sign up...");
            }

            // 02. Switches
            Console.WriteLine("Enter current day: ");
            String day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It is Monday...");
                    break;
                case "Tuesday":
                    Console.WriteLine("It is Tuesday...");
                    break;
                case "Wednesday":
                    Console.WriteLine("It is Wednesday...");
                    break;
                // And many more...
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

            // 03. While loops
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello, " + name);

            // 04. For loops
            for (int i = 0; i <= 10; ++i)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 30; i+=3)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; --i)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy New Year!");

            // 05. Nested loops
            Console.WriteLine("Enter number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of cols");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your prefered symbol");
            char symbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < cols; ++j)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
