using System;
using System.Collections.Generic;
using System.Linq;
using Project_Valeri.Model;
using Project_Valeri.Others;
using Project_Valeri_Extended.Data;

namespace Project_Valeri_Extended.Helpers
{
    internal static class UserHelper
    {
        public static string ToString(this User user)
        {
            return $"User: {user.Name}, Email: {user.Email}, Role: {user.Role}, Expires: {user.Expires}";
        }

        public static void ValidateCredentials(this UserData userData, string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The name field cannot be empty");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The password field cannot be empty");

            bool isValid = userData.ValidateUser(name, password);

            if (!isValid)
                throw new UnauthorizedAccessException("Invalid credentials!");

            Console.WriteLine("Credentials validated successfully.");
        }

        public static User GetUser(this UserData userData, string name, string password)    
        {
            return userData.GetUser(name, password);
        }
    }
}
