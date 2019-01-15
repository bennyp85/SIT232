using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Type1Account : Account
    {
        /**************** Attributes ****************/
        private static double _InterestRate = 2.0;
        public static double InterestRate
        {
            get { return _InterestRate; }
        }

        /**************** Methods ****************/
        // Constructor 1
        public Type1Account(Customer owner, DateTime openedDate, double initBalance = 0) : base(owner, openedDate, initBalance)
        {
        }

        // Constructor 2
        public Type1Account(Customer owner, double initBalance = 0) : base(owner, initBalance)
        {
        }

        public void Deposit(double amount)
        {
            if (IsValidForDeposit(amount))
                Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (IsValidForWithdrawal(amount))
                Balance -= amount;
        }

        public override double CalculateInterest()
        {
            if (IsValidForCalculatingInterest())
            {
                // reference date - the 1st day of the current month.
                DateTime refDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                TimeSpan span;

                if (DateTime.Compare(OpenedDate, refDate) < 0) // if opened date is before refDate
                    span = DateTime.Now.Subtract(refDate);
                else
                    span = DateTime.Now.Subtract(OpenedDate);

                return _InterestRate / 365 / 100 * span.Days * Balance;
            }
            else
                return -1;
        }

        // Auxiliary methods
        private bool IsValidForDeposit(double amount)
        {
            if (!Active)
            {
                Console.WriteLine("This account has been closed!");
                return false;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Deposit must be greater than 0!");
                return false;
            }
            return true;
        }

        private bool IsValidForWithdrawal(double amount)
        {
            if (!Active)
            {
                Console.WriteLine("This account has been closed!");
                return false;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawn amount must be greater than 0!");
                return false;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Withdrawn amount exceeds balance!");
                return false;
            }
            return true;
        }
    }
}
