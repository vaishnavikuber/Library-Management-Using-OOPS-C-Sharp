using System;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Library Management System");
            Library library = new Library();

            Book book1 = new Book { Title= "Drama" ,Auther= "Sudha Rani", ISBN="343nr"};
            Book book2 = new Book { Title = "Comedy", Auther = "R K Narayan", ISBN = "983ko" };
            Book book3 = new Book { Title = "Adventure", Auther = "Raj Anand", ISBN = "831nd" };

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.WriteLine("Displaying all Library Books:");
            library.DisplayBooks();

            Console.WriteLine("\nBorrow a Book: 'Drama' :");
            book1.Borrow();

            Console.WriteLine("\nDisplaying all Library Books Again:");
            library.DisplayBooks();

            Console.WriteLine("\nBorrow a Book: 'Drama' Again : ");
            book1.Borrow();

            Console.WriteLine("\nReturning 'Drama' Book");
            book1.Return();

            Console.WriteLine("\nDisplaying all Library Books Again:");
            library.DisplayBooks();

        }
    }
}
