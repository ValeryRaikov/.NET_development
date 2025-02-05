using System;
using System.Threading;

namespace topic09
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01. Generics
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.25, 2.50, 3.75, 4.99, 5.99 };
            String[] stringArray = { "1", "2", "3", "4", "5" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            // 02. Threading
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);

            Thread th1 = new Thread(CountDown);
            Thread th2 = new Thread(CountUp);

            th1.Start();
            th2.Start();
        }

        public static void displayElements<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; --i)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer #1 is done!");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; ++i)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer #2 is done!");
        }
    }
}
