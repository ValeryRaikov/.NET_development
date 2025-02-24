using System.Windows;
using Microsoft.EntityFrameworkCore;
using ReserveRoom.DbContexts;
using ReserveRoom.Exceptions;
using ReserveRoom.Models;
using ReserveRoom.Services;
using ReserveRoom.Services.ReservationConflictValidators;
using ReserveRoom.Services.ReservationCreators;
using ReserveRoom.Services.ReservationProviders;
using ReserveRoom.Stores;
using ReserveRoom.ViewModels;

namespace ReserveRoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Data Source=reserveroom.db";

        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;
        private readonly ReserveRoomDbContextFactory _reserveRoomDbContextFactory;

        public App()
        {
            _reserveRoomDbContextFactory = new ReserveRoomDbContextFactory(CONNECTION_STRING);

            IReservationProvider reservationProvider = new DatabaseReservationProvider(_reserveRoomDbContextFactory);
            IReservationCreator reservationCreator = new DatabaseReservationCreator(_reserveRoomDbContextFactory);
            IReservationConflictValidator reservationConflictValidator = new DatabaseReservationConflictValidator(_reserveRoomDbContextFactory);
            _hotel = new Hotel("Intercontinental", new ReservationBook(reservationProvider, reservationCreator, reservationConflictValidator));
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            using (ReserveRoomDbContext dbContext = _reserveRoomDbContextFactory.CreateDbContext())
            {
                dbContext.Database.Migrate();
            }

            _navigationStore.CurrentViewModel = CreateReservationViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotel, new NavigationService(_navigationStore, CreateReservationViewModel));
        }

        private ReservationListingViewModel CreateReservationViewModel()
        {
            return ReservationListingViewModel.LoadViewModel(_hotel, new NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }
}
