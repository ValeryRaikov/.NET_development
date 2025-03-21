using SQLite;

namespace MauiToDoApp
{
    public static class Constants
    {
        public const string DB_NAME = "todo_db.db3";

        public const SQLiteOpenFlags FLAGS = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;
        
        public static string DATABASE_PATH
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DB_NAME);
            }
        }
    }
}
