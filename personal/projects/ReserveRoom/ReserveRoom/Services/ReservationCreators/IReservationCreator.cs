using System.Threading.Tasks;
using ReserveRoom.Models;

namespace ReserveRoom.Services.ReservationCreators
{
    public interface IReservationCreator
    {
        Task CreateReservation(Reservation reservation);
    }
}
