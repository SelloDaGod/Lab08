# Lending Library with Backpack - ReadMe
## Overview
Welcome to the Lending Library with Backpack console application! This project is a Text-based User Interface (TUI) that simulates a lending library. It includes classes for managing books in the library and a backpack to hold borrowed books. The application uses Test-Driven Development (TDD) to ensure robustness and correctness.

## Program Specifications
The solution includes the following components:

## Book Class
The Book class holds properties to represent a book, such as Title, Author, and NumberOfPages.

## Library Class
The Library class implements the ILibrary interface, which provides methods to manage books in the library:

Add(string title, string firstName, string lastName, int numberOfPages): Adds a new book to the library.
Borrow(string title): Borrows a book from the library by its title.
Return(Book book): Returns a borrowed book to the library.
Search(string title): Searches for a book in the library by its title.
The library uses a private Dictionary<string, Book> to store books, where the key is the book's title.

## Backpack Class
The Backpack<T> class is a generic class that implements the IBag<T> interface. It can hold any type of item, including borrowed books. The class provides the following methods:

Pack(T item): Adds an item to the backpack.
Unpack(int index): Removes an item from the backpack at the given index.
The backpack uses a private List<T> for storage.

## LinkedList Class
The LinkedList<T> class is a generic class that implements IEnumerable<T>. It represents a linked list data structure and supports various operations, such as adding and removing elements.

## Console User Interface
The console user interface provides the following options to the user:

View all Books: Displays all books available in the library.
Add a Book: Prompts the user to enter book details and adds the book to the library.
Borrow a Book: Allows the user to borrow a book by entering its title.
Return a Book: Shows the numbered book bag and prompts the user to return a book by selecting its index.
View Book Bag: Displays all books currently in the user's backpack.
Exit: Quits the application.
## Usage
Run the application in a compatible C# development environment (e.g., Visual Studio).
The application will start with an empty library and book bag.
Use the options provided in the console to interact with the library and backpack.
For example, you can add books to the library, borrow books, return borrowed books, and view the books in the library and backpack.
## Running Tests
The application uses Test-Driven Development (TDD).
All tests are written using a testing framework like NUnit or MSTest.
The tests cover scenarios for adding books to the library, borrowing and returning books, and managing the backpack.
To run the tests, use the testing framework's "Run Tests" feature.
