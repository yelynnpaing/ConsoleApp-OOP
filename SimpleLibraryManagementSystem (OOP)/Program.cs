using SimpleLibraryManagementSystem__OOP_;

class Program
{
    static void Main()
    {
        Library library = new Library();

        Console.WriteLine("Call book.AddBook()");
        library.AddBook(new Book { BookId = 1, BookTitle = "Learning C#", Author = "Doe Jhone", IsAvailable = true });
        library.AddBook(new Book { BookId = 2, BookTitle = "Learning .Net", Author = "Doe Jhone", IsAvailable = true });
        library.AddBook(new Book { BookId = 3, BookTitle = "Learning .NetMVC", Author = "Doe Jhone", IsAvailable = true });

        Console.WriteLine("- - - - - - -  - - - - - - - ");
        Console.WriteLine("Call book.BookList()");
        library.BookList();

        Console.WriteLine("- - - - - - -  - - - - - - - ");
        Console.WriteLine("Call book.BorrowBok()");
        library.BorrowBook(1);

        Console.WriteLine("- - - - - - -  - - - - - - - ");
        Console.WriteLine("Call book.BookList()");
        library.BookList();

        Console.WriteLine("- - - - - - -  - - - - - - - ");
        Console.WriteLine("Call book.ReturnBok()");
        library.ReturnBook(1);

        Console.WriteLine("- - - - - - -  - - - - - - - ");
        Console.WriteLine("Call book.BookList()");
        library.BookList();

        Console.ReadKey();
    }
}