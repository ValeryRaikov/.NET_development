using System.Threading.Tasks;
using ReserveRoom.Models;

namespace ReserveRoom.Services.ReservationConflictValidators
{
    public interface IReservationConflictValidator
    {
        Task<Reservation> GetConflictingReservation(Reservation reservation);
    }
}
