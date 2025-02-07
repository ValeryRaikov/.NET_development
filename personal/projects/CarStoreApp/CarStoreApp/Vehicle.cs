using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    public abstract class Vehicle : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Vehicle(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Vehicle Information:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: {Price:C}");
        }

        public abstract override string ToString();
    }
}
