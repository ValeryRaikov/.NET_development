namespace LibraryManagement.Library
{
    public class Admin: User
    {
        public Admin(string name) : base(name) {}

        public Admin(string name, string email, string phoneNumber)
            : base(name, email, phoneNumber) {}

        public override void Menu()
        {
            Console.WriteLine("1. View Book\n2. Add Book\n3. Delete Book\n4. Search Book\n5. Delete all data\n" +
                "6. View Orders\n7. Exit");
        }
    }
}
