using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;
using System.Text;


namespace Assignment_2
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

        //constuctpr 3
        protected Account(Customer owner, decimal balance, uint accID, DateTime openDate, StreamReader sr, List<Customer> customers)
        {
            _Owner = owner;
            _OpenDate = openDate;
            _Balance = balance;
            _AccID = accID;
            _Owner.AddAccount(this);
            string ownerID = sr.ReadLine();
        }

        public Account(StreamReader sr, List<Customer> customers)
        {
            //sr an Object ??
            _AccID = Convert.ToUInt16(sr.ReadLine());
            uint ownerID = Convert.ToUInt16(sr.ReadLine());
            foreach (Customer c in customers)
            {
                if (c.ID == ownerID)
                {
                    _Owner = c;
                    break;
                }
            }

            string sOpenDate = sr.ReadLine();
            _OpenDate = Convert.ToDateTime(sOpenDate);
            string sCloseDate = sr.ReadLine();
            if (sCloseDate != null)
            {
                //_CloseDate = Convert.ToDateTime(sCloseDate);
                _ActiveAcc = false;
            }
            else
                _ActiveAcc = true;
                _Balance = Convert.ToDecimal(sr.ReadLine());
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

        public void ToStream(StreamWriter sw)
        {
            if (this.GetType() == typeof(Type1Acc))
                sw.WriteLine("1");
            else
                sw.WriteLine("2");
            sw.WriteLine(_AccID);
            sw.WriteLine(_Owner.ID);
            sw.WriteLine(_OpenDate);
            if (_ActiveAcc)
                sw.WriteLine();
            else
                sw.WriteLine(_CloseDate);
            sw.WriteLine(_Balance);
        }
	}

}
    



