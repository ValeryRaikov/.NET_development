using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ReserveRoom.Exceptions;
using ReserveRoom.Models;

namespace ReserveRoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                Hotel hotel = new Hotel("Intercontinental");

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    "Intercontinental",
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 2)
                ));

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    "Intercontinental",
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 4)
                ));

                IEnumerable<Reservation> reservations = hotel.GetReservationsForUser("Intercontinental");
            }
            catch (ReservationConflictException ex)
            {

            }

            base.OnStartup(e);
        }
    }
}
