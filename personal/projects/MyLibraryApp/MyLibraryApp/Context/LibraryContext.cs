using Microsoft.EntityFrameworkCore;
using System.IO;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "library.db");
        options.UseSqlite($"Data Source={path}");
    }
}