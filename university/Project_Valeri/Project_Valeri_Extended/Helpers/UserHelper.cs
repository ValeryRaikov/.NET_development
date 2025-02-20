using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project_Valeri.Model;
using Project_Valeri.Others;
using Project_Valeri_Extended.Data;

namespace Project_Valeri_Extended.Helpers
{
    internal static class UserHelper
    {
        private static readonly string LogFilePath = "login.log";

        private static void LogLoginAttempt(string username, string status)
        {
            string logEntry = $"{DateTime.Now}: {username} - {status}";
            File.AppendAllText(LogFilePath, logEntry + Environment.NewLine);
        }

        public static string ToString(this User user)
        {
            return $"User: {user.Name}, Email: {user.Email}, Role: {user.Role}, Expires: {user.Expires}";
        }

        public static void ValidateCredentials(this UserData userData, string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                LogLoginAttempt(name, "FAILED: The name field cannot be empty.");
                throw new ArgumentException("The name field cannot be empty");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                LogLoginAttempt(name, "FAILED: The password field cannot be empty.");
                throw new ArgumentException("The password field cannot be empty");
            }

            bool isValid = userData.ValidateUser(name, password);

            if (!isValid)
            {
                LogLoginAttempt(name, "FAILED: Invalid credentials.");
                throw new UnauthorizedAccessException("Invalid credentials!");
            }

            Console.WriteLine("Credentials validated successfully.");
        }

        public static User GetUser(this UserData userData, string name, string password)    
        {
            User user = userData.GetUser(name, password);

            if (user != null)
                LogLoginAttempt(name, "SUCCESS: User logged in.");

            return user;
        }
    }
}
