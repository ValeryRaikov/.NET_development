namespace LibraryManagement.Library
{
    public abstract class User
    {
        private string _name;
        private string _email;
        private string _phoneNumber;
        private IOOperation[] _operations;

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

        public IOOperation[] Operations
        {
            get { return _operations; }
            set { _operations = value; }
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

        abstract public void Menu(Services service, User user);
    }
}
