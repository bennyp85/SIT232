/*************************************************************
** File: Book.cs
** Author/s: Justin Rough
** Description:
**     A class representing a book that may be linked in an
** order.  Contains attributes for authors, title, publisher,
** and year, plus a custom constructor and overridden
** ToString() method.
*************************************************************/
using System;

namespace BookOrder
{
    class Book
    {   // attributes
        private string _Authors;
        private string _Title;
        private string _Publisher;
        private int _Year;        
        
        // properties
        public string Authors
        {
            get { return _Authors; }
        }

        public string Title
        {
            get { return _Title; }
        }

        public string Publisher
        {
            get { return _Publisher; }
        }

        public int Year
        {
            get { return _Year; }
        }
        // Constructors
        public Book(string authors, string title, string publisher, int year)
        {
            _Authors = authors;
            _Title = title;
            _Publisher = publisher;
            _Year = year;
        }

        public Book(Book b)
        {
            _Authors = b.Authors;
            _Title = b.Title;
            _Publisher = b.Publisher;
            _Year = b.Year;
        }
        // service method
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}.", _Authors, _Title, _Publisher, _Year);
        }
    }
}
