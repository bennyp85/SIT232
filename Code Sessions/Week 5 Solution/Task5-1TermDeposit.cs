/*************************************************************
** File: TermDeposit.cs
** Author/s: Justin Rough
** Description:
**     The TermDeposit class that inherits from the Account
** class for demonstrating inheritance.
*************************************************************/
using System;

namespace BankAccounts
{
    class TermDeposit : Account
    {
        public TermDeposit(decimal balance, int term)
            : base(balance)
        {
            _Term = term;
        }

        private int _Term;
        public int Term
        {
            get { return _Term; }
            set { _Term = value; }
        }

        public decimal CalculateInterest(decimal rate)
        {
            decimal interest = ((rate / 100) * Balance) * ((decimal)_Term / 365);
            return Math.Round(interest, 2, MidpointRounding.AwayFromZero);
        }

        public override string ToString()
        {
            return string.Format("{0}, deposited for {1} days", base.ToString(), _Term);
        }
    }
}
