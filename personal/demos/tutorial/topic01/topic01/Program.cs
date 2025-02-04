using System;

namespace topic01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's begin our dotnet journey!");

            // 01. Formatting output
            Console.WriteLine("Simple message");
            Console.Write("Another simple message");
            Console.WriteLine("Hey...");

            // Comment

            /* 
            Multiline
            comment
            ...
            */

            Console.WriteLine("\tHello...");

            // Console.ReadKey();

            // 02. Variables
            int x;
            x = 10;

            int y = 123;

            Console.WriteLine(x + y);

            int age = 21;
            Console.WriteLine("Your age is: " + age);

            double height = 188.5;
            Console.WriteLine("Your height is: " + height);

            bool mature = true;
            char gender = 'M';
            String name = "Valery";
            Console.WriteLine("Name: " + name + ", gender: " + gender + ", mature: " + mature);

            const double PI = 3.1415;

            // 03. Type casting
            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(b);
            Console.WriteLine(a.GetType());

            String number = "1000";
            int num = Convert.ToInt32(number);
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());

            // 04. User input
            /*
            Console.Write("Enter your first name: ");
            String firstName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName);
            */

            // 05. Math methods
            double n = 3;
            Console.WriteLine(Math.Pow(n, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Round(PI));
            Console.WriteLine(Math.Ceiling(PI));
            Console.WriteLine(Math.Floor(PI));

            Random random = new Random();
            int choice = random.Next(1, 7);
            Console.WriteLine(choice);

            // 06. String methods
            String fullName = "Valery Raikov";
            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);
            fullName = fullName.ToLower();
            Console.WriteLine(fullName);
            String phoneNumber = "+359 887 111 899";
            phoneNumber = phoneNumber.Replace(" ", "");
            Console.WriteLine(phoneNumber);
            phoneNumber = phoneNumber.Insert(0, "-> ");
            Console.WriteLine(phoneNumber);
            Console.WriteLine(phoneNumber.Length);
        }
    }
}
