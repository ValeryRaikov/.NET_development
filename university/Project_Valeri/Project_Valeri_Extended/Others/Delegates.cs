using System;
using Microsoft.Extensions.Logging;
using Project_Valeri_Extended.Helpers;

namespace Project_Valeri_Extended.Others
{
    public static class Delegates
    {
        public static readonly ILogger logger = LoggerHelper.GetLogger("Hello");

        public static void Log(string error)
        {
            logger.LogError(error);
        }

        public static void Log2(string error)
        {
            Console.WriteLine("- DELEGATES -");
            Console.WriteLine($"{error}");
            Console.WriteLine("- DELEGATES -");
        }
    }
}
