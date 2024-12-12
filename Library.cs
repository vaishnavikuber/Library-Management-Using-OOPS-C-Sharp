using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Library : IBorrowable
    {
        public List<Book> BookList = new List<Book>();

        public void AddBook(Book book)
        {
            BookList.Add(book);
            Console.WriteLine($"The book '{book.Title}' is added to the library ");
        }

        public void DisplayBooks()
        {
            if (BookList.Count == 0)
            {
                Console.WriteLine("No books in Library");
            }
            else
            {
                foreach(Book book in BookList)
                {
                    book.DisplayInfo();
                }
            }
        }

        public void Borrow()
        {
            Console.WriteLine("Borrowing from Library directly is not allowed");
        }

        public void Return()
        {
            Console.WriteLine("Returning from Library directly is not allowed");
        }
    }
}
