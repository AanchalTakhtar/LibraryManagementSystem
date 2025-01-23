# Library Management System

## Introduction
This project is a simple Library Management System implemented in C#. It demonstrates the use of Object-Oriented Programming (OOP) concepts, SOLID principles, and basic design patterns. The system allows users to add, remove, search, and list books and eBooks.

## How to Run the Program

### Prerequisites
- .NET SDK installed on your machine. You can download it from [here](https://dotnet.microsoft.com/download).

### Steps to Run
1. Clone or download this repository to your local machine.
2. Open the project folder in Visual Studio Code.
3. Open the integrated terminal in Visual Studio Code by clicking `Terminal` > `New Terminal` or pressing ``Ctrl+` ``.
4. Navigate to the project directory if you're not already there:
   ```sh
   cd path\to\LibraryManagementSystem
### Run the program using the following command:
dotnet run
### Key Features and Enhancements
Part 1: Basic Library Management System
1. Book Class:
   - Represents a book with attributes:
     - title (String)
     - author (String)
     - isbn (String)
     - available (boolean)
   - Provides getter and setter methods.
   - Overrides the ToString method to return book details.

2. Library Class:
   - Manages a collection of books.
   - Methods:
     - AddBook(Book book) - Add a book to the library.
     - RemoveBook(string isbn) - Remove a book by ISBN.
     - SearchBookByTitle(string title) - Search for a book by title.
     - ListAllBooks() - List all books in the library.

Part 2: Enhancing with OOP Principles and Inheritance
1. EBook Subclass:
   - Extends the Book class to represent electronic books (eBooks).
   - Additional attribute:
     - fileSize (int) - File size in MB.
   - Overrides the ToString method to include file size information.
2. LibraryManager Class:
   - Manages library operations.
   - Provides a text-based menu for user interaction.
   - Designed to follow the Single Responsibility Principle (SRP).
   - 
Part 3: Applying SOLID Principles and Design Patterns
1. Singleton Pattern:
   - Ensures only one instance of the LibraryManager class exists in the application.
2. Factory Pattern:
   - Uses the BookFactory class to create instances of Book or EBook based on input parameters.


