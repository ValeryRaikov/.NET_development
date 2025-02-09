using System;
using System.Collections.Generic;

namespace CarStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarStore cs = new CarStore("Valery's Garage");

            int choice;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine($"\nWelcome to the menu of car store: {cs.Name}");
                Console.WriteLine("Choose an option:\n1. Add insurance\n2. Remove insurance\n3. Add car" +
                    "\n4. Remove car\n5. Display store information\n6. Quit program");

                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1-6.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter insurance vehicle rate: ");
                        if (!decimal.TryParse(Console.ReadLine(), out decimal rate))
                        {
                            Console.WriteLine("Invalid rate! Please enter a valid decimal number.");
                            break;
                        }

                        cs.AddInsurance(new Insurance(GetInsuranceName(), rate));
                        Console.WriteLine("Insurance added successfully!");
                        break;

                    case 2:
                        RemoveInsurance(cs);
                        break;

                    case 3:
                        AddCarToInsurance(cs);
                        break;

                    case 4:
                        RemoveCarFromInsurance(cs);
                        break;

                    case 5:
                        cs.DisplayInfo();
                        break;

                    case 6:
                        exit = true;
                        Console.WriteLine("Exiting the program...");
                        break;

                    default:
                        Console.WriteLine("Invalid input! Please choose a number between 1-6.");
                        break;
                }
            }
        }

        // Utility method to get insurance name with validation
        public static string GetInsuranceName()
        {
            string name;
            do
            {
                Console.Write("Enter insurance name: ");
                name = Console.ReadLine().Trim();
            } while (string.IsNullOrEmpty(name));

            return name;
        }

        // Utility method to create a Car instance
        public static Vehicle GetCar()
        {
            Console.Write("Enter car make: ");
            string make = Console.ReadLine();

            Console.Write("Enter car model: ");
            string model = Console.ReadLine();

            Console.Write("Enter car fuel type: ");
            string fuelType = Console.ReadLine();

            Console.Write("Enter car year: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid year! Defaulting to 2000.");
                year = 2000;
            }

            Console.Write("Enter car mileage: ");
            if (!int.TryParse(Console.ReadLine(), out int mileage))
            {
                Console.WriteLine("Invalid mileage! Defaulting to 0.");
                mileage = 0;
            }

            Console.Write("Enter car price: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Console.WriteLine("Invalid price! Defaulting to $1000.");
                price = 1000;
            }

            return new Car(make, model, price, year, mileage, fuelType);
        }

        // Utility method to remove an insurance
        public static void RemoveInsurance(CarStore cs)
        {
            string name = GetInsuranceName();
            bool found = false;

            foreach (Insurance insurance in cs.Insurances)
            {
                if (insurance.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    cs.RemoveInsurance(insurance);
                    Console.WriteLine("Insurance removed successfully!");
                    found = true;
                    break;
                }
            }

            if (!found) Console.WriteLine("Insurance not found!");
        }

        // Utility method to add a car to an insurance
        public static void AddCarToInsurance(CarStore cs)
        {
            string name = GetInsuranceName();
            bool found = false;

            foreach (Insurance insurance in cs.Insurances)
            {
                if (insurance.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    insurance.AddVehicle(GetCar());
                    Console.WriteLine("Car added successfully!");
                    found = true;
                    break;
                }
            }

            if (!found) Console.WriteLine("Insurance not found!");
        }

        // Utility method to remove a car from an insurance
        public static void RemoveCarFromInsurance(CarStore cs)
        {
            string name = GetInsuranceName();
            bool found = false;

            foreach (Insurance insurance in cs.Insurances)
            {
                if (insurance.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    insurance.RemoveVehicle(GetCar());
                    Console.WriteLine("Car removed successfully!");
                    found = true;
                    break;
                }
            }

            if (!found) 
                Console.WriteLine("Insurance not found!");
        }
    }
}
