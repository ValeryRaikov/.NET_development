using MyLibraryApp.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyLibraryApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Book? _selectedBook;

        public ObservableCollection<Book> Books { get; set; } = new();

        public Book? SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                OnPropertyChanged(nameof(Book));
            }
        }

        public ICommand AddBookCommand { get; }
        public ICommand DeleteBookCommand { get; }

        public Book NewBook { get; set; } = new();

        public MainViewModel()
        {
            AddBookCommand = new BaseCommand(AddBook);
            DeleteBookCommand = new BaseCommand(DeleteBook, () => SelectedBook != null);
            LoadBooks();
        }

        private void LoadBooks()
        {
            using var db = new LibraryContext();
            db.Database.EnsureCreated();
            Books.Clear();

            foreach (var book in db.Books)
                Books.Add(book);
        }

        private void AddBook()
        {
            using var db = new LibraryContext();
            db.Books.Add(NewBook);
            db.SaveChanges();
            Books.Add(NewBook);
            NewBook = new Book();
            OnPropertyChanged(nameof(NewBook));
        }

        private void DeleteBook()
        {
            if (SelectedBook == null) 
                return;

            using var db = new LibraryContext();
            db.Books.Remove(SelectedBook);
            db.SaveChanges();
            Books.Remove(SelectedBook);
        }
    }
}
