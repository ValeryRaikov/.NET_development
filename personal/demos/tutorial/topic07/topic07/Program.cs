using System;
using System.Collections.Generic;

namespace topic07
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Skoda", "Octavia", 2015, 150);
            Truck truck = new Truck("Volvo", "XC-90", 50);
            Motorcycle motor = new Motorcycle("Kawasaki", "Racer-X", "petrol");

            Vehicle[] vehicles = { car, truck, motor };
            Console.WriteLine("Available vehicles:");
            foreach(Vehicle v in vehicles)
            {
                Console.WriteLine(v.ToString());
            }

            // Changing fields
            car.Brand = "BMW";
            car.Model = "M3";
            car.Year = 2020;
            car.HorsePower = 450;

            truck.Brand = "Mercedes";
            truck.Model = "Actros";
            truck.Capacity = 70;

            motor.Brand = "Ducati";
            motor.Model = "Panigale V4";
            motor.FuelType = "Electric";

            Console.WriteLine("Available vehicles:");
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v.ToString());
            }

            // 02. Lists
            List<Vehicle> vehiclesList = new List<Vehicle>();

            // Add method
            vehiclesList.Add(car);
            vehiclesList.Add(truck);
            vehiclesList.Add(motor);
            vehiclesList.Add(new Truck("Volvo", "XC-90", 50));
            vehiclesList.Add(new Motorcycle("Kawasaki", "Racer-X", "petrol"));
            Console.WriteLine("Available vehicles:");
            foreach (Vehicle v in vehiclesList)
            {
                Console.WriteLine(v.ToString());
            }

            // Remove method
            vehiclesList.Remove(motor);
            Console.WriteLine("Available vehicles:");
            foreach (Vehicle v in vehiclesList)
            {
                Console.WriteLine(v.ToString());  
            }
        }
    }

    // 01. Polymorphism and Encapsulation
    abstract class Vehicle
    {
        private String brand;
        private String model;

        public String Brand
        {
            get { return brand; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    brand = value;
            }
        }
        /*
        Auto-implemented property
        public String Brand { get; set; } 
        */

        public String Model
        {
            get { return model; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    model = value;
            }
        }

        public Vehicle(String brand, String model)
        {
            Brand = brand;
            Model = model;
        }

        public abstract override string ToString();
    }

    class Car : Vehicle
    {
        private int year;
        private int horsePower;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        public Car(String brand, String model, int year, int horsePower)
            : base(brand, model)
        {
            Year = year;
            HorsePower = horsePower;
        }

        public override string ToString()
        {
            return $"Car: {Brand} {Model} - {Year}y, with {HorsePower}hp.";
        }
    }

    class Truck : Vehicle
    {
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        
        public Truck(String brand, String model, int capacity)
            : base(brand, model)
        {
            Capacity = capacity;
        }

        public override string ToString()
        {
            return $"Truck: {Brand} {Model} with capacity of {capacity}.";
        }
    }

    class Motorcycle : Vehicle
    {
        private String fuelType;

        public String FuelType
        {
            get { return fuelType; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    fuelType = value;
            }
        }

        public Motorcycle(String brand, String model, String fuelType)
            : base(brand, model)
        {
            FuelType = fuelType;
        }

        public override string ToString()
        {
            return $"Motorcycle: {Brand} {Model} works on {fuelType}";
        }
    }
}
