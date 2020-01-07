/*************************************************************
** File: Item.cs
** Author/s: Justin Rough
** Description:
**     The base class for items to be borrowed from the
** library.
*************************************************************/
using System;

namespace LibraryBorrowings
{
    class Item
    {
        protected Item(string title, string publisher, string dewyDecimalNumber)
        {
            _Title = title;
            _Publisher = publisher;
            _DewyDecimalNumber = dewyDecimalNumber;
        }

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private string _Publisher;
        public string Publisher
        {
            get { return _Publisher; }
            set { _Publisher = value; }
        }

        private string _DewyDecimalNumber;
        public string DewyDecimalNumber
        {
            get { return _DewyDecimalNumber; }
            set { _DewyDecimalNumber = value; }
        }
    }
}
