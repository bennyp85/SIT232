/*************************************************************
** File: Book.cs
** Author/s: Justin Rough
** Description:
**     The Book class which derives from Item representing a
** book that can be borrowed from the library.
*************************************************************/
using System;

namespace LibraryBorrowings
{
    class Book : Item
    {
        public Book(string title, string publisher, string author, string dewyDecimalNumber)
            : base(title, publisher, dewyDecimalNumber)
        {
            _Author = author;
        }

        private string _Author;
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, Call No. {3}", _Author, Title, Publisher, DewyDecimalNumber);
        }
    }
}
