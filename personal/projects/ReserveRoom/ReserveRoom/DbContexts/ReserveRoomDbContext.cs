using Microsoft.EntityFrameworkCore;
using ReserveRoom.DTOs;

namespace ReserveRoom.DbContexts
{
    public class ReserveRoomDbContext : DbContext
    {
        public ReserveRoomDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ReservationDTO> Reservations { get; set; }
    }
}
