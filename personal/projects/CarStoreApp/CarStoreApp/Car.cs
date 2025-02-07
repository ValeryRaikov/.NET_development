using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    public class Car : Vehicle
    {
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string FuelType { get; set; }

        public Car(string make, string model, decimal price, int year, int mileage, string fuelType) 
            : base(make, model, price)
        {
            Year = year;
            Mileage = mileage;
            FuelType = fuelType;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Car Information:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Mileage: {Mileage}");
            Console.WriteLine($"Fuel Type: {FuelType}");
        }

        public override string ToString()
        {
            return $"Car -> {Make} {Model}";
        }
    }
}
