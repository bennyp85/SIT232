using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Type2Account : Account
    {
        /**************** Attributes ****************/
        private static double _BasicInterestRate = 3.0;
        public static double BasicInterestRate
        {
            get { return _BasicInterestRate; }
        }

        private static double _DepositInterestRate = 4.0;
        public static double DepositInterestRate
        {
            get { return _DepositInterestRate; }
        }

        private double _MonthlyDeposit = 0;
        public double MonthlyDeposit
        {
            get { return _MonthlyDeposit; }
            set {
                if (value < 0)
                    throw new Exception("Monthly deposit cannot be negative!");
                _MonthlyDeposit = value;
            }
        }

        /**************** Methods ****************/
        // Constructor 1
        public Type2Account(Customer owner, DateTime openedDate, double initBalance = 0) : base(owner, openedDate, initBalance)
        {
        }

        // Constructor 2
        public Type2Account(Customer owner, double initBalance = 0) : base(owner, initBalance)
        {
        }

        public override double CalculateInterest()
        {
            if (IsValidForCalculatingInterest())
            {
                // reference date
                DateTime refDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                TimeSpan span;

                if (DateTime.Compare(OpenedDate, refDate) < 0)
                    span = DateTime.Now.Subtract(refDate);
                else
                    span = DateTime.Now.Subtract(OpenedDate);

                return _BasicInterestRate / 365 / 100 * span.Days * Balance + _DepositInterestRate / 365 / 100 * span.Days * _MonthlyDeposit;
            }
            else
                return -1;
        }

        protected override bool IsValidForTransferring(Account destinationAccount, double amount)
        {
            if (base.IsValidForTransferring(destinationAccount, amount)) // This calls IsValidForTransferring in Account class
            {
                if (destinationAccount.Owner != this.Owner)
                {
                    Console.WriteLine("Cannot transfer to another account of a different customer!");
                    return false;
                }
                if (destinationAccount.GetType() != typeof(Type1Account))
                {
                    Console.WriteLine("Cannot transfer to a Type 2 Account!");
                    return false;
                }
                return true;
            }
            else
                return false;
        }

        public override void UpdateBalance()
        {
            base.UpdateBalance(); // this calls the UpdateBalance in Account class
            _MonthlyDeposit = 0;
        }
    }
}
