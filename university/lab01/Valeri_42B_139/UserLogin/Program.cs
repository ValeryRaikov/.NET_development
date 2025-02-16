using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginValidation lv1 = new LoginValidation();

            if (lv1.ValidateUserInput())
            {
                Console.WriteLine(UserData.TestUser.Username);
                Console.WriteLine(UserData.TestUser.Password);
                Console.WriteLine(UserData.TestUser.FacultyNumber);
                Console.WriteLine(UserData.TestUser.UserRole);

                Console.WriteLine(LoginValidation.CurrentUserRole);
            }

        }
    }
}
