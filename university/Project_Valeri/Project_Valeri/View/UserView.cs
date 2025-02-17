using System;
using Project_Valeri.ViewModel;

namespace Project_Valeri.View
{
    internal class UserView
    {
        private UserViewModel _viewModel;

        public UserViewModel ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; }
        }

        public UserView(UserViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        public void Display()
        {
            Console.WriteLine("Welcome:");
            Console.WriteLine($"User: {ViewModel.Name}");
            Console.WriteLine($"Role: {ViewModel.Role}");
        }
    }
}
