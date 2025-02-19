using System;

namespace lesson02
{
    static class Lambdas
    {
        public static void InTransaction(Action action)
        {
            Console.WriteLine("Init transaction...");
            action();
            Console.WriteLine("Clean up transaction...");
        }
    }
}
