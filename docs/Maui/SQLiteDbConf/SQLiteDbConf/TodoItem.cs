using SQLite;

namespace SQLiteDbConf
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public bool Done { get; set; }

        public override string ToString() => $"{Name} (Done: {Done})";
    }
}