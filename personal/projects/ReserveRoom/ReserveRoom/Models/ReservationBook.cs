using System.Collections.Generic;
using System.Linq;
using ReserveRoom.Exceptions;

namespace ReserveRoom.Models
{
    class ReservationBook
    {
        private readonly List<Reservation> _rservations;

        public ReservationBook()
        {
            _rservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _rservations;
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (var existingReservation in _rservations)
            {
                if (existingReservation.Conflicts(reservation))
                    throw new ReservationConflictException(existingReservation, reservation);
            }

            _rservations.Add(reservation);
        }
    }
}
