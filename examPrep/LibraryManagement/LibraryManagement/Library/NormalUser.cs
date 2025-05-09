namespace LibraryManagement.Library
{
    public class NormalUser : User
    {
        public NormalUser(string name) : base(name) {}
        
        public NormalUser(string name, string email, string phoneNumber)
            : base(name, email, phoneNumber) {}

        public override void Menu()
        {
            Console.WriteLine("1. View Books\n2. Search Book\n3. Place Order\n4. Borrow Book\n5. Calculate Fine\n" +
                "6. Return Book\n7. Exit");
        }
    }
}
