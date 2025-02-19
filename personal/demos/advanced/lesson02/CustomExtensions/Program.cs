using System;
using System.Collections.Generic;

namespace CustomExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("MySelect (Multiply by 2):");
            foreach (var num in numbers.MySelect(n => n * 2))
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("MyWhere (Only Even Numbers):");
            foreach (var num in numbers.MyWhere(n => n % 2 == 0))
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine($"MyFirst: {numbers.MyFirst()}");

            Console.WriteLine($"MyFirst (Greater than 3): {numbers.MyFirst(n => n > 3)}");

            Console.WriteLine($"MyAll (All > 0): {numbers.MyAll(n => n > 0)}");
            Console.WriteLine($"MyAll (All > 3): {numbers.MyAll(n => n > 3)}");

            Console.WriteLine($"MyAny (Any Elements Exist): {numbers.MyAny()}");
            Console.WriteLine($"MyAny (Any Even Numbers): {numbers.MyAny(n => n % 2 == 0)}");
            Console.WriteLine($"MyAny (Any > 10): {numbers.MyAny(n => n > 10)}");
        }
    }
}
