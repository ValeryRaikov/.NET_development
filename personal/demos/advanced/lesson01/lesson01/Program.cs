using System;

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

        static void Main(string[] args)
        {
            // FizzBuzz fb = new FizzBuzz(new ConsoleFizzOutput());
            // fb.Run(1, 100);

            Run(WriteFizzBuzz, 1, 100);

            Console.ReadKey();
        }
    }
}
