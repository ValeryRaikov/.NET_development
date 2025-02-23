using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ReserveRoom.Commands;
using ReserveRoom.Models;
using ReserveRoom.Services;
using ReserveRoom.Stores;

namespace ReserveRoom.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly Hotel _hotel;
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(Hotel hotel, NavigationService makeReservationNavigationService)
        {
            _hotel = hotel;
            _reservations = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateCommand(makeReservationNavigationService);

            /*
            _reservations.Add(
                new ReservationViewModel(new Reservation(new RoomID(1, 2), "Valery", DateTime.Now, DateTime.Now.AddDays(2)))
            );
            _reservations.Add(
                new ReservationViewModel(new Reservation(new RoomID(2, 3), "Meggie", DateTime.Now, DateTime.Now.AddDays(5)))
            );
            _reservations.Add(
                 new ReservationViewModel(new Reservation(new RoomID(1, 4), "Ivaylo", DateTime.Now, DateTime.Now.AddDays(3)))
            );
            */

            UpdateReservations();
        }

        private void UpdateReservations()
        {
            _reservations.Clear();

            foreach (Reservation reservation in _hotel.GetAllReservations())
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation);
                _reservations.Add(reservationViewModel);
            }
        }
    }
}
