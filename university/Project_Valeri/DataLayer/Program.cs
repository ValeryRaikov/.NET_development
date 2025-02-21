using System;
using System.Linq;
using DataLayer.Database;
using DataLayer.Model;
using DataLayer.Loggers;
using Project_Valeri.Others;

namespace DataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();

                if (!context.Users.Any(u => u.Name == "User"))
                {
                    var newUser = new DatabaseUser()
                    {
                        Name = "User",
                        Password = Utils.HashPassword("$USERuser123"),
                        Role = UserRolesEnum.ANONYMOUS,
                        Email = "user_@example.com",
                        Expires = DateTime.Now,
                    };

                    context.Users.Add(newUser);
                    context.SaveChanges();

                    DatabaseLogger.Log(context, $"User '{newUser.Name}' was created.");
                }

                // DisplayUsers(context);
                // DisplayUserLogs(context);
                // AuthenticateUser(context);

                int choice = 0;

                Console.WriteLine("User Login Management System Menu:");
                while (choice != 6)
                {
                    Console.WriteLine("Choose one of the following options:");
                    Console.WriteLine("1 - Display All Users.");
                    Console.WriteLine("2 - Display User Logs.");
                    Console.WriteLine("3 - Authenticate User.");
                    Console.WriteLine("4 - Add New User.");
                    Console.WriteLine("5 - Remove Existing User.");
                    Console.WriteLine("6 - Exit Program.");

                    Console.Write("Enter option: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            DisplayUsers(context);
                            break;
                        case 2:
                            DisplayUserLogs(context);
                            break;
                        case 3:
                            AuthenticateUser(context);
                            break;
                        case 4:
                            AddUser(context);
                            break;
                        case 5:
                            RemoveUser(context);
                            break;
                        default:
                            Console.WriteLine("Invalid input. Try again...");
                            break;
                    }
                }
            }
        }

        private static bool FoundUser(DatabaseContext context, string username, string password)
        {
            var user = context.Users.FirstOrDefault(u => u.Name == username && u.Password == Utils.HashPassword(password));

            return user != null ? true : false;
        }

        private static void DisplayUsers(DatabaseContext context)
        {
            Console.WriteLine("Users:");
            foreach (var user in context.Users)
                Console.WriteLine($"{user.Name} - {user.Email} - {user.Role} - {user.Expires}");
        }

        private static void DisplayUserLogs(DatabaseContext context)
        {
            Console.WriteLine("User Logs:");
            foreach (var log in context.Logs)
                Console.WriteLine($"{log.Id} - {log.Message} - {log.Timestamp}");
        }

        private static void AuthenticateUser(DatabaseContext context)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var user = context.Users.FirstOrDefault(u => u.Name == username && u.Password == Utils.HashPassword(password));

            if (FoundUser(context, username, password))
            {
                Console.WriteLine("Valid user.");
                DatabaseLogger.Log(context, $"Successful login for user '{username}'.");
            }
            else
            {
                Console.WriteLine("Invalid user!");
                DatabaseLogger.Log(context, $"Failed login attempt for username '{username}'.");
            }
        }

        private static void AddUser(DatabaseContext context)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (FoundUser(context, username, password))
            {
                Console.WriteLine("User with this username and password already exists!");
                return;
            }

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            var newUser = new DatabaseUser()
            {
                Name = username,
                Password = password,
                Role = UserRolesEnum.ANONYMOUS, // Register new users as anonymous at first
                Email = email,
                Expires = DateTime.Now.AddYears(3), // Set expiration date after 3 years
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            DatabaseLogger.Log(context, $"User '{username}' was created.");

            Console.WriteLine($"User '{username}' has been added successfully.");
        }

        private static void RemoveUser(DatabaseContext context)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (!FoundUser(context, username, password))
            {
                Console.WriteLine("User with this username and password doesn't exist!");
                return;
            }

            var userToRemove = context.Users.FirstOrDefault(u => u.Name == username && u.Password == password);

            context.Users.Remove(userToRemove);
            context.SaveChanges();

            DatabaseLogger.Log(context, $"User '{username}' was removed.");

            Console.WriteLine($"User '{username}' has been removed successfully.");
        }
    }
}
