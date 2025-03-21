﻿using SQLite;

namespace MauiToDoApp.Models
{
    public class ToDoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public bool Done { get; set; }
    }
}
