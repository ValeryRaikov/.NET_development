using System;

namespace topic03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01. Arrays
            String[] cars = { "Skoda", "BMW", "Toyota", "VW" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);

            cars[3] = "Nissan";
            Console.WriteLine(cars[3]);

            Console.WriteLine("Available cars:");
            for (int i = 0; i < cars.Length; ++i)
            {
                Console.WriteLine(cars[i]);
            }

            String[] students = new string[3];
            students[0] = "Valery";
            students[1] = "Ivan";
            students[2] = "Pesho";

            // foreach
            Console.WriteLine("Students:");
            foreach(String student in students)
            {
                Console.WriteLine(student);
            }

            // 02. Methods 
            doSomething();
            greetPerson(students[1]);

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Result is: " + calculateResult(num1, num2, op));

            // 03. Method overloading
            Console.WriteLine("Result is: " + calculateResult(10, 20, 30, '+'));

            // 04. params keyword
            double t1 = checkOut(3.99, 5.75, 10, 14.25, 18.75);
            double t2 = checkOut(7.99, 8.99, 45.5);

            Console.WriteLine("Total 1 is: " + t1);
            Console.WriteLine("Total 2 is: " + t2);
        }

        static void doSomething()
        {
            Console.WriteLine("Doing some work...");
            Console.WriteLine("Doing more work...");
            Console.WriteLine("Doing even more work...");
            Console.WriteLine("Finished!");
        }

        static void greetPerson(String name)
        {
            if (name != "" && name != "Peder")
            {
                Console.WriteLine("Hello, " + name);
                return;
            }

            Console.WriteLine("Get away!");
        }

        static int calculateResult(int a, int b, char operation)
        {
            switch (operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return Convert.ToInt32(a / b);
                default:
                    Console.WriteLine("Error!");
                    return 0;
            }
        }

        static int calculateResult(int a, int b, int c, char operation)
        {
            switch (operation)
            {
                case '+':
                    return a + b + c;
                case '-':
                    return a - b - c;
                case '*':
                    return a * b * c;
                case '/':
                    return Convert.ToInt32(a / b / c);
                default:
                    Console.WriteLine("Error!");
                    return 0;
            }
        }

        static double checkOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}
