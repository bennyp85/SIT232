/*************************************************************
** File: Book.cs
** Author/s: Justin Rough
** Description:
**     A class representing an order of zero or more books.
** Contains an attribute for a Customer and uses the generic
** List<> class to store the books in the order.  The list of
** books is exposed publicly as a ReadOnlyCollection<> to
** ensure encapsulation is maintained, with an Add() method
** provided to allow Book objects to be added to the list in
** a controlled manner.  Also includes three custom
** constructors: a custom constructor, a parameter-less
** constructor using object-initialisers and a copy
** constructor providing deep copy functionality.
*************************************************************/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BookOrder
{
    class Order
    {
        private const string DEFAULT_CUSTOMER = "UNKNOWN";
        // attributes
        private string _Customer;
        private List<Book> _Books;
        // properties
        public string Customer
        {
            get { return _Customer; }
        }

        public ReadOnlyCollection<Book> Books
        {
            get { return _Books.AsReadOnly(); }
        }
        // constructors
        public Order()
        {
           _Customer = DEFAULT_CUSTOMER;
           _Books = new List<Book>();
        }

        public Order(string customer)
        {
            _Customer = customer;
            _Books = new List<Book>();
        }

        public Order(Order src)
        {
            _Customer = src.Customer;
            //_Books = new List<Book>(src._Books);
            _Books = new List<Book>();
            foreach (BookOrder b in src.Books) _Books.Add(new Book(b));
        }
        // service methods
        public void Add(Book book)
        {
            _Books.Add(new Book(book));
        }

        public override string ToString()
        {
            return string.Format("Order for {0} containing {1} books", _Customer, _Books.Count);
        }
    }
}
