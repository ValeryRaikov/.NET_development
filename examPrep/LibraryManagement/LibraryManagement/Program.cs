using LibraryManagement.Library;

namespace LibraryManagement
{
    public class Program
    {
        static Services service;

        static void Main(string[] args)
        {
            service = new Services();

            Console.WriteLine("Welcome to Library Management System!");

            int choice;
            do
            {
                Console.WriteLine("1. Login\n2. New user\n3. Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        NewUser();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Try again!");
                        break;
                }
            } while (choice != 3);
        }

        private static void Login()
        {
            Console.WriteLine("Enter phone number:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            int found = service.Login(phoneNumber, email);
            if (found != -1)
            {
                User user = service.getUser(found);
                Console.WriteLine($"Welcome, {user.Name}");
                user.Menu(service, user);
            }
            else
            {
                Console.WriteLine("Login failed! Try again!");
                return;
            }
        }   

        private static void NewUser()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter phone number:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            Console.WriteLine("1. Admin\n2. Normal user");
            int choice = Convert.ToInt32(Console.ReadLine());

            User user;
            if (choice == 1)
            {
                user = new Admin(name, email, phoneNumber);
            } else
            {
                user = new NormalUser(name, email, phoneNumber);
            }
            service.AddUser(user);

            Console.WriteLine("User created successfully!");

            user.Menu(service, user);
        }
    }
}
