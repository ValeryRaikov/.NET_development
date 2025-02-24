using System.Collections.Generic;
using System.Threading.Tasks;
using ReserveRoom.Exceptions;
using ReserveRoom.Services.ReservationCreators;
using ReserveRoom.Services.ReservationProviders;

namespace ReserveRoom.Models
{
    class ReservationBook
    {
        private readonly IReservationProvider _reservationProvider;
        private readonly IReservationCreator _reservationCreator;

        public ReservationBook(IReservationProvider reservationProvider, IReservationCreator reservationCreator)
        {
            _reservationProvider = reservationProvider;
            _reservationCreator = reservationCreator;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservations()
        {
            return await _reservationProvider.GetAllReservations();
        }

        public async Task AddReservation(Reservation reservation)
        {
            // foreach (var existingReservation in _reservations)
            // {
            //     if (existingReservation.Conflicts(reservation))
            //         throw new ReservationConflictException(existingReservation, reservation);
            // }
            // TODO -> Database Query

            await _reservationCreator.CreateReservation(reservation);
        }
    }
}
