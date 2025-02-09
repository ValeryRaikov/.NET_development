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

        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Contains(vehicle))
            {
                Console.WriteLine("This vehicle is already registered!");
                return;
            }

            Vehicles.Add(vehicle);
            Console.WriteLine($"{vehicle} registered successfully!");
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            if (!Vehicles.Contains(vehicle))
            {
                Console.WriteLine("This vehicle is not yet registered!");
                return;
            }

            Vehicles.Remove(vehicle);
            Console.WriteLine($"{vehicle} removed successfully!");
        }

        public decimal CalculateBudget()
        {
            decimal total = 0;

            foreach(Vehicle vehicle in Vehicles)
            {
                total += vehicle.Price * VehicleRate;
            }

            return total;
        }

        public override string ToString()
        {
            return $"Insurance -> {Name}";
        }
    }
}
