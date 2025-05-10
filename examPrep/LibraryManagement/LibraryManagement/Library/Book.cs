namespace LibraryManagement.Library
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _publisher;
        private string _address;
        private string _status;
        private int _quantity;
        private double _price;
        private int _borrowedCopies;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int BorrowedCopies 
        { 
            get { return _borrowedCopies; } 
            set { _borrowedCopies = value; }
        }   

        public Book() {}

        public Book(string title, string author, string publisher, string address, string status, int quantity, 
            double price, int borrowedCopies)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Address = address;
            Status = status;
            Quantity = quantity;
            Price = price;
            BorrowedCopies = borrowedCopies;
        }

        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nPublisher: {Publisher}\nAddress: {Address}\nQuantity: {Quantity}\n" +
                $"Price: {Price}\nBorrowed Coppies: {BorrowedCopies}";
        }
    }
}
