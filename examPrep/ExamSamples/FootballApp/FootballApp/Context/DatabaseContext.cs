using FootballApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballApp.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }

        public DbSet<User> Users { get; set; }

        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=matches.db");
        }
    }
}
