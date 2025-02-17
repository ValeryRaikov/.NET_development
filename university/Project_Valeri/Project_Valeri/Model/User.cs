using Project_Valeri.Others;

namespace Project_Valeri.Model
{
    internal class User
    {
        private string _name;
        private string _password;
        private UserRolesEnum _role;

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public UserRolesEnum Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public User(string name, string password, UserRolesEnum role)
        {
            Name = name;
            Password = password;
            Role = role;
        }
    }
}
