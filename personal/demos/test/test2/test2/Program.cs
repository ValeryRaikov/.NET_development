using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do another test now...");
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
            }

            int x = 10;
            int y = 200;
            int result = x + y + 50;
            Console.WriteLine("Result is: " + result);
        }
    }
}
