using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagementSystem__OOP_
{
    internal interface LibraryService
    {
        void AddBook(Book book);
        void BorrowBook(int bookId);
        void ReturnBook(int bookId);
        void BookList();
    }
}
