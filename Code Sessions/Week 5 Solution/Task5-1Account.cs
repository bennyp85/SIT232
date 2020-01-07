/*************************************************************
** File: Account.cs
** Author/s: Justin Rough
** Description:
**     The Account base class used to demonstrate inheritance.
*************************************************************/
using System;

namespace BankAccounts
{
    class Account
    {
        protected Account(decimal balance)
        {
            _Balance = balance;
        }

        private decimal _Balance;
        public decimal Balance
        {
            get { return _Balance; }
        }

        protected void IncreaseBalance(decimal value)
        {
            _Balance += value;
        }

        protected void DecreaseBalance(decimal value)
        {
            _Balance -= value;
        }

        public override string ToString()
        {
            return string.Format("Balance: {0:c}", _Balance);
        }
    }
}
