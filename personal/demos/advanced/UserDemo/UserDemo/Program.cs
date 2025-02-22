using System;
using System.Collections.Generic;

namespace UserDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User("@valercho123", "Valrcho123");
            User u2 = new User("@meggie123", "Meggie123");
            User u3 = new User("@ivancho123", "Ivancho123");
            User u4 = new User("@mariika123", "Mariika123");
            User u5 = new User("@petarcho123", "Petarcho123");

            UserManagement um = new UserManagement();

            um.AddUser("@valercho123", "Valrcho123");
            um.AddUser("@meggie123", "Meggie123");
            um.AddUser("@ivancho123", "Ivancho123");

            um.DisplayUsers();

            Console.WriteLine();
            Console.WriteLine(um.GetUser("@valercho123", "Valrcho123"));
            Console.WriteLine(um.GetUser("@petarcho123", "Petarcho123"));

            um.RemoveUser("@meggie123", "Meggie123");
            um.RemoveUser("@mariika123", "Mariika123");

            um.AddUser("@mariika123", "Mariika123");
            um.AddUser("@petarcho123", "Petarcho123");

            Console.WriteLine();
            um.DisplayUsers();

            Func<User, bool> passwordPredicate1 = user => user.Password.Contains("a"); // silly predicate 1
            Func<User, bool> passwordPredicate2 = user => user.Password.Length > 10; // silly predicate 2

            Console.WriteLine("\nFilter username:");
            foreach (var user in um.FilterUsernames("m"))
                Console.WriteLine(user.Username);

            Console.WriteLine("\nFilter password 1:");
            foreach (var user in um.FilterPasswords(passwordPredicate1))
                Console.WriteLine(user.Password);

            Console.WriteLine("\nFilter password 2:");
            foreach (var user in um.FilterPasswords(passwordPredicate2))
                Console.WriteLine(user.Password);

            int count = um.CountFilteredPassword(passwordPredicate2);
            Console.WriteLine($"\nTotal numbers with password length greater than 10: {count}");
        }
    }
}
