using System.Collections.Generic;
using System.Threading.Tasks;
using ReserveRoom.Models;

namespace ReserveRoom.Services.ReservationProviders
{
    public interface IReservationProvider
    {
        Task<IEnumerable<Reservation>> GetAllReservations();
    }
}
