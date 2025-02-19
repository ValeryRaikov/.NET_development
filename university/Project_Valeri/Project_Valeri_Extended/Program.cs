using System;
using Project_Valeri.Model;
using Project_Valeri.Others;
using Project_Valeri.ViewModel;
using Project_Valeri.View;
using Project_Valeri_Extended.Others;
using Project_Valeri_Extended.Helpers;
using Microsoft.Extensions.Logging;
using Project_Valeri_Extended.Data;

namespace Project_Valeri_Extended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                var user = new User("John Smith", "JohnSmith@123", UserRolesEnum.STUDENT, "jsmith@gmail.com");

                var viewModel = new UserViewModel(user);

                var view = new UserView(viewModel);

                view.Display();
                // view.DisplayError();

                // Test Custom Loggers
                var logger = LoggerHelper.GetLogger("AppLogger");

                logger.LogInformation("First log");
                logger.LogWarning("Warning log");
                logger.LogError("Error log");

                var fileLogger = LoggerHelper.GetLogger("FileLogger");
                fileLogger.LogInformation("Logging to file!");
            } 
            catch (Exception e)
            {
                var log = new ActionOnError(Delegates.Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
            */

            UserData userData = new UserData();

            User studentUser = new User("Mihail", "%Misho%123", UserRolesEnum.STUDENT, "misho_1@abv.bg");
            userData.AddUser(studentUser);

            User studentUser2 = new User("Viktoria", "vikiVIKI@123", UserRolesEnum.STUDENT, "viktoria20@yahoo.bg");
            userData.AddUser(studentUser2);

            User teacherUser = new User("Teacher", "Teacher&1234", UserRolesEnum.PROFESSOR, "teacher@example.com");
            userData.AddUser(teacherUser);

            User adminUser = new User("Admin", "AdMiN#777", UserRolesEnum.ADMIN, "admin@example.com");
            userData.AddUser(adminUser);

            try
            {
                Console.Write("Enter username: ");
                string name = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                userData.ValidateCredentials(name, password);

                User foundUser = userData.GetUser(name, password);

                if (foundUser == null)
                {
                    throw new Exception("User not found!");
                }

                Console.WriteLine(UserHelper.ToString(foundUser));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution complete.");
            }
        }
    }
}
