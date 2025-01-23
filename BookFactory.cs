public static class BookFactory
{
    public static Book CreateBook(string type, string title, string author, string isbn, bool available, int fileSize)
    {
        if (type.ToLower() == "ebook")
        {
            return new EBook(title, author, isbn, available, fileSize);
        }
        else
        {
            return new Book(title, author, isbn, available);
        }
    }
}
