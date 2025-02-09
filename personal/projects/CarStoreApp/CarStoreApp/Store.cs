using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    public abstract class Store
    {
        public static int VehiclesCount { get; set; } = 0;
        public static int InsurancesCount { get; set; } = 0;

        public string Name { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Insurance> Insurances { get; set; }

        public Store(string name)
        {
            Name = name;
            Vehicles = new List<Vehicle>();
            Insurances = new List<Insurance>();
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Store: {Name}");
            if (!Insurances.Any())
            {
                Console.WriteLine("No insurances added yet!");
                return;
            }

            Console.WriteLine($"Insurances: {Insurances.Count()}");
            foreach(Insurance insurance in Insurances)
            {
                Console.WriteLine(insurance);
            }

            Console.WriteLine($"Vehicles: {Vehicles.Count()}");
            foreach (Insurance insurance in Insurances)
            {
                Console.Write($"{insurance} -> ");
                foreach(Vehicle vehicle in insurance.Vehicles)
                {
                    Console.Write($"{vehicle}, ");
                }
                Console.WriteLine();
            }
        }

        public virtual void AddInsurance(Insurance insurance)
        {
            if (Insurances.Contains(insurance))
            {
                Console.WriteLine("Insurance already added to the store!");
                return;
            }

            Insurances.Add(insurance);
            InsurancesCount++;
            foreach(Vehicle vehicle in insurance.Vehicles)
            {
                Vehicles.Add(vehicle);
                VehiclesCount++;
            }

            Console.WriteLine($"{insurance} added successfully!");
        }

        public virtual void RemoveInsurance(Insurance insurance)
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
                Vehicles.Remove(vehicle);
                VehiclesCount--;
            }

            Console.WriteLine($"{insurance} removed successfully!");
        }

        public abstract override string ToString();
    }
}
