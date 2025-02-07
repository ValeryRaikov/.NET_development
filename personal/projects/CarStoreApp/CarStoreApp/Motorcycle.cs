using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    public class Motorcycle : Vehicle
    {
        public int MaxSpeed { get; set; }
        public char Category { get; set; }

        public Motorcycle(string make, string model, decimal price, int maxSpeed, char category)
            : base(make, model, price)
        {
            MaxSpeed = maxSpeed;
            Category = category;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Motorcycle Information:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Max Speed: {MaxSpeed}");
            Console.WriteLine($"Category: {Category}");
        }

        public override string ToString()
        {
            return $"Motorcycle -> {Make} {Model}";
        }
    }
}
