/*************************************************************
** File: Program.cs
** Author/s: Justin Rough
** Description:
**     This program requires students to solve a relatively
** simple problem on their own using inheritance.  A Patron of
** a library is permitted to borrow a total of three items
** from a library, with a maximum of two Book items and two
** Periodical items each.  The Main method below tries to add
** three of each before displaying the outcome.
*************************************************************/
using System;

namespace LibraryBorrowings
{
    class Program
    {
        static void Main(string[] args)
        {
            Patron patron = new Patron();

            patron.BorrowBook(new Book("Book title 1", "Publisher 1", "Author 1", "001.111 AUT.1"));
            patron.BorrowBook(new Book("Book title 2", "Publisher 2", "Author 2", "001.222 AUT.2"));
            patron.BorrowBook(new Book("Book title 3", "Publisher 3", "Author 3", "001.333 AUT.3"));
            patron.BorrowPeriodical(new Periodical("Periodical title 1", "Publisher 1", "Edition 1", "001.111 PER.1"));
            patron.BorrowPeriodical(new Periodical("Periodical title 2", "Publisher 2", "Edition 2", "001.222 PER.1"));
            patron.BorrowPeriodical(new Periodical("Periodical title 3", "Publisher 3", "Edition 3", "001.333 PER.1"));

            foreach (Book b in patron.Books)
                Console.WriteLine(b);

            foreach (Periodical p in patron.Periodicals)
                Console.WriteLine(p);
        }
    }
}
