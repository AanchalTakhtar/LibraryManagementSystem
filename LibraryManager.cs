using System;

public sealed class LibraryManager
{
    private static readonly Lazy<LibraryManager> instance = new Lazy<LibraryManager>(() => new LibraryManager());
    private Library library = new Library();

    private LibraryManager() { }

    public static LibraryManager Instance => instance.Value;

    public void AddBook(string type, string title, string author, string isbn, bool available, int fileSize)
    {
        var book = BookFactory.CreateBook(type, title, author, isbn, available, fileSize);
        library.AddBook(book);
    }

    public void RemoveBook(string isbn)
    {
        library.RemoveBook(isbn);
    }

    public void SearchBookByTitle(string title)
    {
        var book = library.SearchBookByTitle(title);
        if (book != null)
        {
            Console.WriteLine("Found: " + book);
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void ListAllBooks()
    {
        foreach (var book in library.ListAllBooks())
        {
            Console.WriteLine(book);
        }
    }
}
