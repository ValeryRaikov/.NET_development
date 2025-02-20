using System;
using System.IO;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Project_Valeri.Others;

namespace DataLayer.Database
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source = {databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

            var user1 = new DatabaseUser()
            {
                Id = 1,
                Name = "Valery",
                Password = Utils.HashPassword("Valercho%123"),
                Role = UserRolesEnum.STUDENT,
                Email = "valeryraikov@gmail.com",
                Expires = DateTime.Now.AddYears(10),
            };

            var user2 = new DatabaseUser()
            {
                Id = 2,
                Name = "Miroslav",
                Password = Utils.HashPassword("25MiRkO_@"),
                Role = UserRolesEnum.ANONYMOUS,
                Email = "miroslav@gmail.com",
                Expires = DateTime.Now.AddYears(7),
            };

            var user3 = new DatabaseUser()
            {
                Id = 3,
                Name = "Ivana",
                Password = Utils.HashPassword("IvankA$777"),
                Role = UserRolesEnum.PROFESSOR,
                Email = "ivanaM@abv.bg",
                Expires = DateTime.Now.AddYears(4),
            };

            var user4 = new DatabaseUser()
            {
                Id = 4,
                Name = "Elena",
                Password = Utils.HashPassword("?Elenovo?123"),
                Role = UserRolesEnum.INSPECTOR,
                Email = "elena@example.com",
                Expires = DateTime.Now.AddYears(8),
            };

            modelBuilder.Entity<DatabaseUser>().HasData(user1, user2, user3, user4);
        }
    }
}
