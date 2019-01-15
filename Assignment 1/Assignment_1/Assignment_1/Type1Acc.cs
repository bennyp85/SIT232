using System;
using System.Runtime.InteropServices;

namespace Assignment_1
{
    public class Type1Acc : Account
    {
        //2 constructors like the Account class (constructor1 & constructor2)

        public Type1Acc( Customer owner, DateTime openDate, [Optional]decimal balance) :base(owner, openDate, balance)
            { }

        public Type1Acc(Customer owner, decimal balance) :base(owner, balance)
            { }


        static decimal _AnnualInterestRate = 2.0M;
        public static decimal AnnualInterestRate
        {
            get { return _AnnualInterestRate; }
        }
       

        //deposit()
        //input: amounst
        //add to current balance
        //only active = True accounts and balance > 0
        public void Deposit(decimal amount)
        {
            if (ActiveAcc == true && Balance > 0)
                { Balance += amount; }
        }

        //withdraw()
        //input: amount
        //take away from balance
        //only active = True and amount <= balance
        public bool Withdraw(decimal amount)
        {
            bool result = true;

            if (Balance >= amount)
            {
                Console.WriteLine("{0} Withdrawn", amount);
                Balance -= amount;
            }
            else
                result = false;

            return result;
        }

        //transfer()
        //overrides Transfer() in Account
        //input: to account
        //amount to transfer > 0 
        //from account balance > amount
        public override void Transfer(Account toAccId, decimal amount)
        {
            if (amount > 0 & this.Balance > amount & ActiveAcc == true)
            {
                this.Balance -= amount; 
                toAccId.Balance += amount;
            }
        }

        //calculate_interest()
        //overrides calculate_interest() in Account
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
                
            decimal interest = ((AnnualInterestRate / 100) * Balance) * ( days) / 365;
            return interest;
        }
    }

}
