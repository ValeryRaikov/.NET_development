using System.Linq;

namespace WpfExample.Models
{
    internal class User
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string ValidateUsername()
        {
            if (string.IsNullOrWhiteSpace(_username))
                return "Username cannot be empty.";

            if (_username.Length < 8 || !_username.Contains("_"))
                return "Username must be at least 8 characters long and contain '_'.";

            return null;
        }

        public string ValidatePassword()
        {
            if (string.IsNullOrWhiteSpace(_password))
                return "Password cannot be empty.";

            if (_password.Length < 8 ||
                !_password.Any(char.IsUpper) ||
                !_password.Any(char.IsLower) ||
                !_password.Any(char.IsDigit) ||
                !_password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return "Password must be at least 8 characters long, contain uppercase, lowercase, a number, and a special character.";
            }

            return null;
        }

        public bool ValidateCredentials(string inputUsername, string inputPassword)
        {
            return Username == inputUsername && Password == inputPassword;
        }
    }
}
