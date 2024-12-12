using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Book:Item,IBorrowable
    {
        
        public string Auther { get; set; }
        public string ISBN { get; set; }

        public bool IsBorrowed { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Tittle : {Title}   Author : {Auther}   ISBN : {ISBN}");

        }
        public void Borrow()
        {
            if (IsBorrowed)
            {
                Console.WriteLine("The bood is already borrowed");
            }
            else
            {
                Console.WriteLine("The book has been borrowed");
            }

        }

        public void Return()
        {

            if (IsBorrowed)
            {
                Console.WriteLine("The book has been returned");
            }
            else
            {
                Console.WriteLine("The book was not borrowed");
            }

        }

    }
}
