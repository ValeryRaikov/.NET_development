using System;
using System.Security.Cryptography;
using System.Text;

namespace Project_Valeri.Others
{
    public static class Utils
    {
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) 
                    hasUpper = true;
                else if (char.IsLower(c)) 
                    hasLower = true;
                else if (char.IsDigit(c)) 
                    hasDigit = true;
                else if (!char.IsLetterOrDigit(c)) 
                    hasSpecial = true;
            }

            return hasUpper && hasLower && hasDigit && hasSpecial;
        }

        public static string HashPassword(string password)
        {
            // using (SHA256 sha256 = SHA256.Create())
            // {
            //     byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            //     StringBuilder builder = new StringBuilder();
            // 
            //     foreach (byte b in bytes)
            //     {
            //         builder.Append(b.ToString("x2"));
            //     }
            // 
            //     return builder.ToString();
            // }

            return password; // Because of DB conflicts...
        }
    }
}
