using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class LoginValidation
    {
        private string _username;
        private string _password;
        private string _errorMessage;

        public static UserRoles CurrentUserRole { get; private set; }

        public LoginValidation(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public bool ValidateUserInput(ref User user)
        {
            bool emptyUsername;
            bool shortUsername;
            bool longUsername;
            emptyUsername = _username.Equals(String.Empty);
            shortUsername = _username.Length < 5;
            longUsername = _username.Length > 15;
            if (emptyUsername)
            {
                _errorMessage = "No username provided.";
                return false;
            }
            if (shortUsername)
            {
                _errorMessage = "Username is too short.";
                return false;
            }
            if (longUsername)
            {
                _errorMessage = "Username is too long.";
                return false;
            }

            bool emptyPassword;
            bool shortPassword;
            bool containsSpecialChar;
            emptyPassword = _password.Equals(String.Empty);
            shortPassword = _password.Length < 8;
            containsSpecialChar = _password.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '?' }) >= 0;
            if (emptyPassword)
            {
                _errorMessage = "No password provided.";
                return false;
            }
            if (shortPassword)
            {
                _errorMessage = "Password is too short.";
                return false;
            }
            if (!containsSpecialChar)
            {
                _errorMessage = "Password must contain at least one special character.";
                return false;
            }

            if (_username == UserData.TestUser.Username && _password == UserData.TestUser.Password)
            {
                user = new User(
                    UserData.TestUser.Username,
                    UserData.TestUser.Password,
                    UserData.TestUser.FacultyNumber,
                    UserData.TestUser.UserRole
                );

                CurrentUserRole = user.UserRole;

                return true;
            }

            _errorMessage = "Invalid username or password.";
            CurrentUserRole = UserRoles.ANONYMOUS;

            return false;
        } 
    }
}
