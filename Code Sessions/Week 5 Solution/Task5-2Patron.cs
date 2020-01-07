/*************************************************************
** File: Patron.cs
** Author/s: Justin Rough
** Description:
**     The Patron class that represents the patron/customer of
** a library that is permitted to borrow two books and two
** periodicals, but only up to a total of three items.
*************************************************************/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LibraryBorrowings
{
    class Patron
    {
        private int MAX_BOOKS = 2;
        private int MAX_PERIODICALS = 2;
        private int MAX_BORROWINGS = 3;

        List<Book> _BorrowedBooks = new List<Book>();
        List<Periodical> _BorrowedPeriodicals = new List<Periodical>();

        public ReadOnlyCollection<Book> Books
        {
            get { return _BorrowedBooks.AsReadOnly(); }
        }

        public ReadOnlyCollection<Periodical> Periodicals
        {
            get { return _BorrowedPeriodicals.AsReadOnly(); }
        }

        private int _BorrowedCount
        {
            get { return _BorrowedBooks.Count + _BorrowedPeriodicals.Count; }
        }

        //A Patron can borrow up to two of each type, up to a maximum of three items.
        public bool BorrowBook(Book book)
        {
            bool result = true;

            if (_BorrowedCount < MAX_BORROWINGS && _BorrowedBooks.Count < MAX_BOOKS)
                _BorrowedBooks.Add(book);
            else
                result = false;

            return result;
        }

        public bool BorrowPeriodical(Periodical periodical)
        {
            bool result = true;

            if (_BorrowedCount < MAX_BORROWINGS && _BorrowedPeriodicals.Count < MAX_PERIODICALS)
                _BorrowedPeriodicals.Add(periodical);
            else
                result = false;

            return result;
        }
    }
}
