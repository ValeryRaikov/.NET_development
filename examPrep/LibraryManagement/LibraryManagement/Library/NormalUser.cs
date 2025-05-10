namespace LibraryManagement.Library
{
    public class NormalUser : User
    {
        public NormalUser(string name) : base(name) 
        {
            Operations = new IOOperation[]
            {
                new ViewBooks(),
                new SearchBook(),
                new PlaceOrder(),
                new BorrowBook(),
                new CalculateFine(),
                new ReturnBook(),
                new Exit(),
            };
        }
        
        public NormalUser(string name, string email, string phoneNumber)
            : base(name, email, phoneNumber) 
        {
            Operations = new IOOperation[]
            {
                new ViewBooks(),
                new SearchBook(),
                new PlaceOrder(),
                new BorrowBook(),
                new CalculateFine(),
                new ReturnBook(),
                new Exit(),
            };
        }

        public override void Menu(Services service, User user)
        {
            Console.WriteLine("1. View Books\n2. Search Book\n3. Place Order\n4. Borrow Book\n5. Calculate Fine\n" +
                "6. Return Book\n7. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            Operations[choice - 1].Oper(service, user);
        }

        public override string ToString()
        {
            return $"{Name} - {Email} - {PhoneNumber} -> Normal User\n";
        }
    }
}
