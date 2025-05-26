using FootballApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballApp.Context
{
    public class MatchContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }

        public MatchContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=matches.db");
        }
    }
}
