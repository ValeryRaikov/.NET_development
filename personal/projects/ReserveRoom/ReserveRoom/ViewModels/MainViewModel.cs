using ReserveRoom.Models;

namespace ReserveRoom.ViewModels
{
    public class MainViewModel : ViewModelBase 
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(Hotel hotel)
        {
            CurrentViewModel = new ReservationListingViewModel();
        }
    }
}
