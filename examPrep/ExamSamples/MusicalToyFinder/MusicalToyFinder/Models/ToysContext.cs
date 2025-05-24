using Microsoft.EntityFrameworkCore;

public class ToysContext : DbContext
{
    public DbSet<MusicalToy> MusicalToys { get; set; }
    public DbSet<ToyMelody> ToyMelodies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseInMemoryDatabase("ToysDB");
    }
}