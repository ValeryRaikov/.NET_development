using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using ReserveRoom.Models;
using ReserveRoom.ViewModels;

namespace ReserveRoom.Commands
{
    public class LoadReservationCommand : AsyncCommandBase
    {
        private readonly ReservationListingViewModel _viewModel;
        private readonly Hotel _hotel;

        public LoadReservationCommand(ReservationListingViewModel viewModel, Hotel hotel)
        {
            _viewModel = viewModel;
            _hotel = hotel;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                IEnumerable<Reservation> reservations = await _hotel.GetAllReservations();

                _viewModel.UpdateReservations(reservations);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load reservations.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
