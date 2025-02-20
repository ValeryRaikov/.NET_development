using System;
using System.Linq;
using DataLayer.Database;
using DataLayer.Model;
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
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    Name = "User",
                    Password = Utils.HashPassword("$USERuser123"),
                    Role = UserRolesEnum.ANONYMOUS,
                    Email = "user_@example.com",
                    Expires = DateTime.Now,
                });

                context.SaveChanges();
                var users = context.Users;

                Console.WriteLine("Users:");
                foreach (var user in users)
                    Console.WriteLine($"{user.Name} - {user.Email} - {user.Role} - {user.Expires}");

                AuthenticateUser(context);
            }
        }

        private static void AuthenticateUser(DatabaseContext context)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var user = context.Users.FirstOrDefault(u => u.Name == username && u.Password == Utils.HashPassword(password));

            if (user != null)
                Console.WriteLine("Valid user.");
            else
                Console.WriteLine("Invalid user!");
        }
    }
}
