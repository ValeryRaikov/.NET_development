namespace LibraryManagement.Library
{
    public class Admin: User
    {
        public Admin(string name) : base(name) 
        {
            Operations = new IOOperation[]
            {
                new ViewBooks(),
                new AddBook(),
                new DeleteBook(),
                new SearchBook(),
                new DeleteAllData(),
                new ViewOrders(),
                new Exit(),
            };
        }

        public Admin(string name, string email, string phoneNumber)
            : base(name, email, phoneNumber) 
        {
            Operations = new IOOperation[]
            {
                new ViewBooks(),
                new AddBook(),
                new DeleteBook(),
                new SearchBook(),
                new DeleteAllData(),
                new ViewOrders(),
                new Exit(),
            };
        }

        public override void Menu(Services service, User user)
        {
            Console.WriteLine("1. View Books\n2. Add Book\n3. Delete Book\n4. Search Book\n5. Delete all data\n" +
                "6. View Orders\n7. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            Operations[choice - 1].Oper(service, user);
        }
    }
}
