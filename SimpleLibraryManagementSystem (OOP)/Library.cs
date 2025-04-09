using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagementSystem__OOP_
{
    internal class Library : LibraryService
    {
        private List<Book> books = new List<Book> ();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"BookId {book.BookId} - Title {book.BookTitle} was added");
        }

        public void BookList()
        {
            Console.WriteLine("Available book list - ");
           foreach(var book in books.Where(b => b.IsAvailable == true))
           {
                Console.WriteLine($"BookId {book.BookId} - Title {book.BookTitle}");
           }            
        }

        public void BorrowBook(int bookId)
        {
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            if(book != null && book.IsAvailable == true)
            {
                book.IsAvailable = false;
                Console.WriteLine($"BookId {book.BookId} - Title {book.BookTitle} was borrowed.");
                book.DisplayInfo();
            }
            else
            {
                Console.WriteLine($"BookId {book.BookId} - Title {book.BookTitle} is not available.");
            }
        }

        public void ReturnBook(int bookId)
        {
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            if(book != null && !book.IsAvailable)
            {
                book.IsAvailable = true;
                Console.WriteLine($"BookId {bookId} - Title {book.BookTitle} was returned.");
            }
            else
            {
                Console.WriteLine($"BookId {bookId} - Title {book.BookTitle} not found.");
            }
        }
    }
}
