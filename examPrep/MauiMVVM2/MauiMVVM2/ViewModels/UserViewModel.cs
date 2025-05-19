using MauiMVVM2.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MauiMVVM2.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private string _username;
        private readonly Page _page;
        private User _selectedUser;
        private bool _hasPrefixBeenAdded = false;

        public ObservableCollection<User> Users { get; } = new ObservableCollection<User>();

        public string Username
        {
            get => _username;
            set
            {
                if (!_hasPrefixBeenAdded && !string.IsNullOrWhiteSpace(value))
                {
                    _username = "@" + value.Trim().ToLower();
                    _hasPrefixBeenAdded = true;
                }
                else if (_hasPrefixBeenAdded)
                {
                    _username = value;
                }
                OnPropertyChanged(nameof(Username));
            }
        }

        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                if (_selectedUser != null)
                {
                    Username = _selectedUser.Name.Replace("@", "");
                    _hasPrefixBeenAdded = true;
                }
                OnPropertyChanged(nameof(SelectedUser));
                OnPropertyChanged(nameof(IsUserSelected));
            }
        }

        public bool IsUserSelected => SelectedUser != null;

        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand ClearAllCommand { get; }

        public ICommand NavigateToProductsCommand = 
            new Command(async () => await Shell.Current.GoToAsync("//ProductsPage"));

        public UserViewModel(Page page)
        {
            _page = page;
            AddCommand = new Command(AddUser);
            UpdateCommand = new Command(UpdateUser, () => IsUserSelected);
            DeleteCommand = new Command(DeleteUser, () => IsUserSelected);
            ClearAllCommand = new Command(ClearAll);
        }

        private void AddUser()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                _page.DisplayAlert("Error", "Please enter a username", "OK");
                return;
            }

            var email = $"{Username.Replace("@", "")}@gmail.com";
            Users.Add(new User(Username, email));

            _username = string.Empty;
            _hasPrefixBeenAdded = false;
            OnPropertyChanged(nameof(Username));
        }

        private void UpdateUser()
        {
            if (SelectedUser == null) 
                return;

            var email = $"{Username.Replace("@", "")}@gmail.com";
            SelectedUser.Name = Username;
            SelectedUser.Email = email;

            var tempList = Users.ToList();
            Users.Clear();

            foreach (var user in tempList) 
                Users.Add(user);

            ResetForm();
        }

        private void DeleteUser()
        {
            if (SelectedUser != null)
            {
                Users.Remove(SelectedUser);
                ResetForm();
            }
        }

        private void ClearAll()
        {
            Users.Clear();
            ResetForm();
        }

        private void ResetForm()
        {
            Username = string.Empty;
            SelectedUser = null;
            _hasPrefixBeenAdded = false;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
