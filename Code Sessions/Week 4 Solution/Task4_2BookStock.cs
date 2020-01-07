/*************************************************************
** File: Program.cs
** Author/s: Justin Rough
** Description:
**     A class for storing the basic information for a stock
** item that is a book.  Contains quantity, description, and
** (sales) price for the book, and a custom constructor to
** initialise them.
*************************************************************/
using System;

namespace ReportWriting
{
    class BookStock
    {
        // attributes
        int _Quantity;
        string _Description;
        decimal _Price;

        // Properties
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        // custom constructor
        public BookStock(int quantity, string description, decimal price)
        {
            _Quantity = quantity;
            _Description = description;
            _Price = price;
        }
    }
}
