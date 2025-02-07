using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    public class Truck : Vehicle
    {
        public int Capacity { get; set; }
        public string Registration { get; set; }

        public Truck(string make, string model, decimal price, int capacity, string registration)
            : base(make, model, price)
        {
            Capacity = capacity;
            Registration = registration;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Truck Information:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Registration: {Registration}");
        }

        public override string ToString()
        {
            return $"Truck -> {Make} {Model}";
        }
    }
}
