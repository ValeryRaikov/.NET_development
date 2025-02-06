using System;

// Partial classes
public partial class Book
{
    public String Title { get; set; }
    public String Author { get; set; }
    public int Year { get; set; }
}

public partial class Book
{
    public Book(String title, String author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
    }
}

namespace partialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Les Intouchables", "Romain Garry", 1994);

            b1.ShowInfo();
        }
    }
}
