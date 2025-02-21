using System;
using DataLayer.Database;
using DataLayer.Model;

namespace DataLayer.Loggers
{
    public static class DatabaseLogger
    {
        public static void Log(DatabaseContext context, string message)
        {
            var logEntry = new LogEntry
            {
                Message = message,
                Timestamp = DateTime.Now
            };

            context.Logs.Add(logEntry);
            context.SaveChanges();
        }
    }
}
