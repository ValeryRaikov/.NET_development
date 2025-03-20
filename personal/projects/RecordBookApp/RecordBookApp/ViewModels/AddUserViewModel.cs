using RecordBookApp.Commands;
using RecordBookApp.Models;
using System.Windows;
using System.Windows.Input;

namespace RecordBookApp.ViewModels
{
    public class AddUserViewModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public ICommand AddUserCommand { get; set; }

        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }

        private void AddUser(object obj)
        {
            if (Name == null || Email == null)
            {
                MessageBox.Show("Name and Email cannot be empty!");
                return;
            }

            UserManager.AddUser(new User(Name, Email));
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }
    }
}
