using System;

public class Program
{
    public static void Main()
    {
        LibraryManager libraryManager = LibraryManager.Instance;
        DisplayMenu(libraryManager);
    }

    public static void DisplayMenu(LibraryManager libraryManager)
    {
        while (true)
        {
            Console.WriteLine("\nLibrary Manager");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Search Book by Title");
            Console.WriteLine("4. List All Books");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter book type (book/ebook): ");
                    string type = Console.ReadLine();
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    Console.Write("Is available (true/false): ");
                    bool available = bool.Parse(Console.ReadLine());
                    Console.Write("Enter file size (0 if not an eBook): ");
                    int fileSize = int.Parse(Console.ReadLine());

                    libraryManager.AddBook(type, title, author, isbn, available, fileSize);
                    break;

                case "2":
                    Console.Write("Enter ISBN: ");
                    isbn = Console.ReadLine();
                    libraryManager.RemoveBook(isbn);
                    break;

                case "3":
                    Console.Write("Enter title: ");
                    title = Console.ReadLine();
                    libraryManager.SearchBookByTitle(title);
                    break;

                case "4":
                    libraryManager.ListAllBooks();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
