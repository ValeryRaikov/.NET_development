using System;
using System.Collections.Generic;

namespace lesson01
{
    class Program
    {
        // 01. Object Oriented Implementation
        interface IFizzOutput
        {
            void Write(string output);
        }

        class FizzBuzz
        {
            private readonly IFizzOutput _output;

            public FizzBuzz(IFizzOutput output)
            {
                _output = output;
            }

            public void Run(int from, int count)
            {
                for (int i = from; i < from + count; i++)
                {
                    var div3 = i % 3 == 0;
                    var div5 = i % 5 == 0;

                    if (div3 && div5)
                        _output.Write("FizzBuzz");
                    else if (div3)
                        _output.Write("Fizz");
                    else if (div5)
                        _output.Write("Buzz");
                    else
                        _output.Write(i.ToString());
                }
            }
        }

        class ConsoleFizzOutput : IFizzOutput
        {
            public void Write(string output)
            {
                Console.WriteLine(output);
            }
        }

        // 02. Delegate Implementation
        public delegate void FizzBuzzOutput(string output);

        public static void WriteFizzBuzz(string output)
        {
            Console.WriteLine(output);
        }

        public static void Run(FizzBuzzOutput output, int from, int count)
        {
            for (int i = from; i < from + count; i++)
            {
                var div3 = i % 3 == 0;
                var div5 = i % 5 == 0;

                if (div3 && div5)
                    output("FizzBuzz");
                else if (div3)
                    output("Fizz");
                else if (div5)
                    output("Buzz");
                else
                    output(i.ToString());
            }
        }

        // 03. 
        class Blegh
        {
            private readonly string _prefix;

            public Blegh(string prefix)
            {
                _prefix = prefix;
            }

            public void DoStuff(string output)
            {
                Console.WriteLine($"From Blegh {_prefix} -> {output}");
            }
        }

        // 04.
        delegate bool IntPredicate(int number);

        static IEnumerable<int> Filter(IEnumerable<int> source, IntPredicate predicate)
        {
            List<int> list = new List<int>();

            foreach(int item in source)
            {
                if (predicate(item))
                    list.Add(item);
            }

            return list;
        }

        static bool IsMod3(int number)
        {
            return number % 3 == 0;
        }

        static void Main(string[] args)
        {
            // FizzBuzz fb = new FizzBuzz(new ConsoleFizzOutput());
            // fb.Run(1, 100);

            // Run(WriteFizzBuzz, 1, 100);

            // Blegh b1 = new Blegh("Blegh 1");
            // Blegh b2 = new Blegh("Blegh 2");

            // Run(b1.DoStuff, 1, 10);
            // Run(b2.DoStuff, 1, 10);

            // var arr = new[] { 1, 2, 3, 4, 5, 6 };
            // var filteredList = Filter(arr, IsMod3);
            // foreach (int item in filteredList)
            // {
            //     Console.WriteLine(item);
            // }

            Button button = new Button();
            button.AppendToClick(ButtonClickedBehavior);
            button.AppendToClick(OtherButtonClickedBehavior);

            button.SimulateClick();

            button._click += ButtonClickedBehavior;
            button._click += OtherButtonClickedBehavior;

            button.SimulateClick();

            static void ButtonClickedBehavior(Button button)
            {
                Console.WriteLine("Button Clicked!");
            }

            static void OtherButtonClickedBehavior(Button button)
            {
                Console.WriteLine("Other Button Clicked!");
            }

            Console.ReadKey();
        }
    }
}
