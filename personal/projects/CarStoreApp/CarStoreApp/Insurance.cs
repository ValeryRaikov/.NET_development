using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    public class Insurance
    {
        public string Name { get; set; }
        public decimal VehicleRate { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public Insurance(string name, decimal vehicleRate)
        {
            Name = name;
            VehicleRate = vehicleRate;
            Vehicles = new List<Vehicle>();
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Insurance Company: {Name}");
            Console.WriteLine($"Vehicle Rate: {VehicleRate}");
            
            if (!Vehicles.Any())
            {
                Console.WriteLine("No Vehicles registered yet!");
                return;
            }

            Console.WriteLine($"Registered vehicles: {Vehicles.Count()}");
            foreach(Vehicle vehicle in Vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        public override string ToString()
        {
            return $"Insurance -> {Name}";
        }
    }
}
