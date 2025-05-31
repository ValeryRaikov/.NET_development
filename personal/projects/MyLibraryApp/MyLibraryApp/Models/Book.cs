public class Book
{
    private int _id;
    private string _title;
    private string _author;
    private string _genre;
    private int _totalPages;
    private int _pagesRead;
    private BookStatus _status;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Title
    {
        get => _title;
        set => _title = value;
    }

    public string Author
    {
        get => _author;
        set => _author = value;
    }

    public string Genre
    {
        get => _genre;
        set => _genre = value;
    }

    public int TotalPages
    {
        get => _totalPages;
        set => _totalPages = value;
    }

    public int PagesRead
    {
        get => _pagesRead;
        set => _pagesRead = value;
    }

    public BookStatus Status
    {
        get => _status;
        set => _status = value;
    }
}