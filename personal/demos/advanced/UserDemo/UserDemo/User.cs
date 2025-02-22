using System;

namespace UserDemo
{
    internal class User
    {
        private static int _usersCount = 0;

        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set 
            {
                if (value == null || value.Length < 8 || !value.Contains("@"))
                {
                    Console.WriteLine("Invalid Username.");
                    return;
                }

                _username = value;
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (value == null || value.Length < 8)
                {
                    Console.WriteLine("Invalid Password.");
                    return;
                }

                _password = value;
            }
        }

        public User(string username, string password)
        {
            _usersCount++;
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return $"User: {Username}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            User other = (User)obj;

            return Username == other.Username && Password == other.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Username, Password);
        }
    }
}
