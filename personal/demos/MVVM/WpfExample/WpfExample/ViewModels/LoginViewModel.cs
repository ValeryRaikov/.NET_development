using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfExample.Commands;
using WpfExample.Models;

namespace WpfExample.ViewModels
{
    internal class LoginViewModel : ViewModelBase
    {
        private User _user;
        private string _errorMessage;

        public CommandBase LoginCommand { get; }
        public CommandBase RegisterCommand { get; }

        private readonly List<User> _registeredUsers = new List<User>
        {
            new User("valid_user", "Secure123!"),
            new User("test_user", "Pass@word1"),
            new User("admin_account", "Admin!2024")
        };

        public string Username
        {
            get => _user.Username;
            set
            {
                _user.Username = value;
                OnPropertyChanged("Username");
            }
        }

        public string Password
        {
            get => _user.Password;
            set
            {
                _user.Password = value;
                OnPropertyChanged("Password");
            }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                OnPropertyChanged("ErrorMessage");
            }
        }

        public LoginViewModel()
        {
            _user = new User("", "");
            LoginCommand = new CommandBase(LoggedIn);
            RegisterCommand = new CommandBase(Register);
        }

        private void LoggedIn(object param)
        {
            try
            {
                string usernameError = _user.ValidateUsername();
                if (usernameError != null)
                {
                    ErrorMessage = usernameError;
                    return;
                }

                string passwordError = _user.ValidatePassword();
                if (passwordError != null)
                {
                    ErrorMessage = passwordError;
                    return;
                }

                var matchedUser = _registeredUsers.FirstOrDefault(u => u.ValidateCredentials(Username, Password));

                if (matchedUser == null)
                {
                    ErrorMessage = "Invalid username or password.";
                    return;
                }

                MessageBox.Show($"Logged in successfully as {matchedUser.Username}");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        private void Register(object param)
        {
            try
            {
                string usernameError = _user.ValidateUsername();
                if (usernameError != null)
                {
                    ErrorMessage = usernameError;
                    return;
                }

                string passwordError = _user.ValidatePassword();
                if (passwordError != null)
                {
                    ErrorMessage = passwordError;
                    return;
                }

                var matchedUser = _registeredUsers.FirstOrDefault(u => u.ValidateCredentials(Username, Password));

                if (matchedUser != null)
                {
                    ErrorMessage = "User with these credentials already exist.";
                    return;
                }

                _registeredUsers.Add((User)param);

                MessageBox.Show($"Registered successfully!");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
