using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    public class CarStore : Store
    {
        public CarStore(string name) : base(name) {}

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car Store: {Name}");
            if (!Insurances.Any())
            {
                Console.WriteLine("No insurances added yet!");
                return;
            }

            Console.WriteLine($"Insurances: {Insurances.Count()}");
            foreach (Insurance insurance in Insurances)
            {
                Console.WriteLine(insurance);
            }

            Console.WriteLine($"Cars: {Vehicles.Count()}");
            foreach (Insurance insurance in Insurances)
            {
                Console.Write($"{insurance} -> ");
                foreach (Vehicle vehicle in insurance.Vehicles)
                {
                    Console.Write($"{vehicle}, ");
                }
                Console.WriteLine();
            }
        }

        public override void AddInsurance(Insurance insurance)
        {
            if (Insurances.Contains(insurance))
            {
                Console.WriteLine("Insurance already added to the store!");
                return;
            }

            Insurances.Add(insurance);
            InsurancesCount++;
            foreach (Vehicle vehicle in insurance.Vehicles)
            {
                if (vehicle is Car) 
                {
                    Vehicles.Add(vehicle);
                    VehiclesCount++;
                }
            }

            Console.WriteLine($"{insurance} added successfully!");
        }

        public override void RemoveInsurance(Insurance insurance)
        {
            if (!Insurances.Contains(insurance))
            {
                Console.WriteLine("Insurance not yet added!");
                return;
            }

            Insurances.Remove(insurance);
            InsurancesCount--;
            foreach (Vehicle vehicle in insurance.Vehicles)
            {
                if (vehicle is Car)
                {
                    Vehicles.Remove(vehicle);
                    VehiclesCount--;
                }
            }

            Console.WriteLine($"{insurance} removed successfully!");
        }

        public override string ToString()
        {
            return $"Car Store -> {Name}";
        }
    }
}
