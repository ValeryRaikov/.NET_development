namespace LibraryManagement.Library
{
    public abstract class User
    {
        private string _name;
        private string _email;
        private string _phoneNumber;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public User() {}

        public User(string name)
        {
            Name = name;
        }

        public User(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        abstract public void Menu();
    }
}
