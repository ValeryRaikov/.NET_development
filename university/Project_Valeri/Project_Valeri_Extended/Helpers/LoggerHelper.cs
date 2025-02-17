using Microsoft.Extensions.Logging;
using Project_Valeri_Extended.Loggers;

namespace Project_Valeri_Extended.Helpers
{
    internal static class LoggerHelper
    {
        public static ILogger GetLogger(string categoryName)
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new LoggerProvider());

            return loggerFactory.CreateLogger(categoryName);
        }
    }
}
