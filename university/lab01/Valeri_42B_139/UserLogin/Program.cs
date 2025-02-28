using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            LoginValidation lv1 = new LoginValidation(username, password);

            User testUser = new User("TestName", "TestPass", "121222139", UserRoles.STUDENT);

            if (lv1.ValidateUserInput(ref testUser))
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
