using RecordBookApp.Commands;
using RecordBookApp.Models;
using RecordBookApp.Views;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace RecordBookApp.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;

            AddUser addUserWin = new AddUser();
            addUserWin.Owner = mainWindow;
            addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWin.Show();
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }
    }
}
