using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;

namespace Assignment_2
{
    public class Type2Acc : Account
    {
        public Type2Acc(Customer owner, DateTime openDate, [Optional]decimal balance) : base(owner, openDate, balance)
        { }

        public Type2Acc(Customer owner, decimal balance) : base(owner, balance)
        { }

        public Type2Acc(StreamReader streamReader, List<Customer> customers) : base(streamReader, customers)
        { }

        static decimal _AnnualInterestRate = 3.0M;
        public static decimal AnnualInterestRate
        {
            get { return _AnnualInterestRate; }
        }

        static decimal _DepositIntRate = 4.0M;
        public static decimal DepositIntRate
        {
            get { return _DepositIntRate; }
        }

        private decimal _MonthlyDeposit;
        public decimal MonthlyDeposit
        {
            get { return _MonthlyDeposit; }
            set { _MonthlyDeposit = value; }
        }

        //Transfer()
        //overrides Transfer() in Account class
        //amount > 0 & not exceed from account balance
        //only transfer to Type1 Acc
        public override void Transfer(Account toAccId, decimal amount)
        {
            if (amount > 0 & this.Balance > amount & toAccId.GetType() == typeof(Type1Acc) & ActiveAcc == true)
            {
                this.Balance -= amount; 
                toAccId.Balance += amount;
            }
        }

        //CalclulateInterest()
        //overrides CalculateInteresest in Account class
        public override decimal CalculateInterest()
        {
            DateTime firstDateOfTheMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime firstDate;

            if (DateTime.Compare(OpenDate, firstDateOfTheMonth) < 0)
                firstDate = firstDateOfTheMonth;
            else
                firstDate = OpenDate;

            TimeSpan diff = DateTime.Now.Subtract(firstDate);
            int days = diff.Days;
            decimal interest = ((AnnualInterestRate / 100) * Balance) * (days) / 365 + ((DepositIntRate / 100) * MonthlyDeposit) * (days) / 365;
            return interest;
        }


        //UpdateBalance()
        //calls update_balance() in Account class
        // -> set monthly deposit = 0
        public new void UpdateBalance()
        {

            UpdateBalance();
            MonthlyDeposit = 0;
        }

    }
}
