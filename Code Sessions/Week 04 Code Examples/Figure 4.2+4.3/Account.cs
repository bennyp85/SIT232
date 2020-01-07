/*************************************************************
** File: Account.cs
** Author/s: Justin Rough
** Description:
**     A simple Account class containing three constructors of
** different types - a parameter-less constructor, a custom
** constructor, and a copy constructor.
*************************************************************/
using System;

namespace CustomConstructorDemo
{
    class Account
    {
        const decimal DEFAULT_BALANCE = 0.00M;

        public Account() : this(DEFAULT_BALANCE)
        {
        }

        //public Account()    // superceded parameter-less constructor
        //{
        //    _Balance = DEFAULT_BALANCE;
        //}

        public Account(decimal openingBalance)
        {
            _Balance = openingBalance;
        }

        public Account(Account source) : this(source._Balance)
        {
        }

        private decimal _Balance;
        public decimal Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }

    }
}
