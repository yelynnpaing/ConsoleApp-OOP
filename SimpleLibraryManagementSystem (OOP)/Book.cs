using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagementSystem__OOP_
{
    internal class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{BookId} - {BookTitle} was authored by {Author} : IsAvailable {IsAvailable}");
        }
    }
}
