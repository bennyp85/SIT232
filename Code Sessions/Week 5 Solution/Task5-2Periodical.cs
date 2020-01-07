/*************************************************************
** File: Periodical.cs
** Author/s: Justin Rough
** Description:
**     The Periodical class which derives from Item 
** representing a book that can be borrowed from the library.
*************************************************************/
using System;

namespace LibraryBorrowings
{
    class Periodical : Item
    {
        public Periodical(string title, string publisher, string edition, string dewyDecimalNumber)
            : base(title, publisher, dewyDecimalNumber)
        {
            _Edition = edition;
        }

        private string _Edition;
        public string Edition
        {
            get { return _Edition; }
            set { _Edition = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) {2}, Call No. {3}", Title, _Edition, Publisher, DewyDecimalNumber);
        }
    }
}
