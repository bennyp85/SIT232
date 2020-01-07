using System;

namespace Task_5._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Book book1 = new Book("John R Author", "A Book", "Book Publisher", 123);
            Periodical periodical1 = new Periodical("A Magazine", "Magazine Publisher", "Edition 1", 321);
            Patron patron = new Patron("Ben");
            patron.BorrowBook(book1);
            patron.BorrowPeriodical(periodical1);
            DisplayLoans(patron);
            
        }

        public static void DisplayLoans(Patron patron)
        {
            Console.WriteLine("Borrower: " + patron.ToString());
            foreach (var VARIABLE in patron.Items)
            {
                Console.WriteLine(VARIABLE.ToString());
            }
        }
        
        
    }
}