using System;
using ReserveRoom.Models;
using ReserveRoom.Services;
using ReserveRoom.Stores;
using ReserveRoom.ViewModels;

namespace ReserveRoom.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationService _navigationService;

        public NavigateCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
