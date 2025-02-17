using System;
using Project_Valeri.Others;

namespace Project_Valeri.Model
{
    internal class User
    {
        private string _name;
        private string _password;
        private UserRolesEnum _role;
        private string _email;

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (Utils.IsValidPassword(value))
                {
                    _password = Utils.HashPassword(value);
                }
                else
                {
                    throw new ArgumentException("Invalid Password!");
                }
            }
        }
        public UserRolesEnum Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public User(string name, string password, UserRolesEnum role, string email)
        {
            Name = name;
            Password = password;
            Role = role;
            Email = email;
        }
    }
}
