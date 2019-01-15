using System;
using System.Runtime.InteropServices;

namespace Assignment_1
{
    public abstract class Account
    {

        // Required
        private static uint _NAccounts = 0;
        private static uint GenerateID()
        {
            _NAccounts++;
            return _NAccounts;
        }

        private uint _AccID;
        public uint AccID
        {
            get { return _AccID; }
        }

        // Required
        // Must be before current day
        private DateTime _OpenDate = DateTime.Now;
        public DateTime OpenDate
        {
            get { return _OpenDate; }
        }

        // Not Required if Account is Open
        private DateTime _CloseDate;
        public DateTime CloseDate
        {
            
            get { return _CloseDate; }
        }

        private bool _ActiveAcc;
        public bool ActiveAcc
        {
            get { return _ActiveAcc; }
        }

        private decimal _Balance;
        public decimal Balance
        {
            get { return _Balance; }
            set{ _Balance = value; }
        }

        private Customer _Owner;
        public Customer Owner
        {
            get { return _Owner; }
        }

        //construtor 1 
        //input: owner, opening date and initial balance
        //validate opening date and balance
        //when account is opened set Active = True
        protected Account( Customer owner, DateTime openDate, [Optional] decimal balance)
        {
            _Owner = owner;
            _OpenDate = openDate;
            _Balance = balance;
            _ActiveAcc = true;
            _AccID = GenerateID();
            _Owner.AddAccount(this);
        }

        //constructor 2
        //input: owner and inital balance
        //opening date set by current date
        //validate balance
        //when account opened set Activee = True
        //invoke constructor 1
        protected Account(Customer owner, [Optional] decimal balance) : this(owner, DateTime.Now, balance)
        {
            
        }
    

        //close()
        //active = False
        //close_date = current date
        public void close()
        {
            _ActiveAcc = false;
            _CloseDate = DateTime.Now;
        }


        //transfer()
        //input: account to transfer to and amount
        // overriden by Type1/2 account
        public abstract void Transfer(Account toAccId, decimal amount);

        //calculate interest()
        // overriden by Type1/2 account
        public abstract decimal CalculateInterest();

        //update_balance()
        //end of month
        //new_balance = old_balance + intereest
        //call -> calculate_interest()
        public virtual void UpdateBalance()
        {
            // calculate the interest
            decimal interest = CalculateInterest();
            Balance += interest;
        }

		//ToString()
		//output: acc_id, open_date, balance, owners name, closed_date(if closed)
		public override string ToString()
		{
            if (ActiveAcc)
                return string.Format("ID: {0} \t Open Date: {1} \t Balance: {2:C} \t Owner: {3} {4}", AccID, OpenDate, Balance, Owner.FirstName, Owner.LastName);
            else
                return string.Format("ID: {0} \t Open Date: {1} \t Balance: {2:C} \t Owner: {3} {4} \t Closing Date: {5}", AccID, OpenDate, Balance, Owner.FirstName, Owner.LastName, CloseDate);

        }
	}

}
    



