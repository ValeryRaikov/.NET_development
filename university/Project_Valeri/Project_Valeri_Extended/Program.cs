using System;
using Project_Valeri.Model;
using Project_Valeri.Others;
using Project_Valeri.ViewModel;
using Project_Valeri.View;
using Project_Valeri_Extended.Others;
using Project_Valeri_Extended.Helpers;
using Microsoft.Extensions.Logging;

namespace Project_Valeri_Extended
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
