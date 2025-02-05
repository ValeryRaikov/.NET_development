using System;

namespace topic04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01. Exceptions
            try
            {
                Console.Write("Enter number 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                double result = num1 / num2;
                Console.WriteLine("Result of division is: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers!\n" + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero!\n" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error!\n" + e.Message);
            }
            finally
            {
                Console.WriteLine("Exiting the program...");
            }

            // 02. Conditional operator
            double temp = 21.7;
            String message;

            message = (temp >= 20) ? "It is warm outside." : "It is cold outside.";
            Console.WriteLine(message);

            // 03. String interpolation
            String firstName = "Valery";
            String lastName = "Raikov";
            int age = 21;

            Console.WriteLine($"Hello, {firstName} {lastName}, you are {age} years old.");

            // 04. Multidimensional arrays
            String[,] parkingLot =
            {
                {"BMW", "Audi", "Mercedes"},
                {"Toyota", "Nissan", "Subaru"},
                {"Citroen", "Peugeot", "Renault"},
            };
            Console.WriteLine(parkingLot[0, 2]);
            Console.WriteLine(parkingLot[1, 1]);

            Console.WriteLine("All cars:");
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("All cars:");
            for (int i = 0; i < parkingLot.GetLength(0); ++i)
            {
                for (int j = 0; j < parkingLot.GetLength(1); ++j)
                {
                    Console.Write(parkingLot[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
