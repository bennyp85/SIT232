using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    abstract class Account
    {
        /**************** Attributes ****************/
        // _Count holds the current number of accounts in the system
        private static ulong _Count = 0;

        private ulong _ID;
        public ulong ID
        {
            get { return _ID; }
        }

        protected Customer _Owner;
        public string Owner
        {
            get { return _Owner.ToString(); }
        }

        protected DateTime _OpenedDate;
        public DateTime OpenedDate
        {
            get { return _OpenedDate; }
        }

        protected DateTime _ClosedDate;
        public DateTime ClosedDate
        {
            get { if (_Active)
                    Console.WriteLine("This account is still active");
                    return _ClosedDate;
                }
        }

        protected bool _Active;
        public bool Active
        {
            get { return _Active; }
        }

        protected double _Balance = 0;
        public double Balance
        {
            get { return _Balance; }
            set { if (IsBalanceValid((double) value))  
                  _Balance = value;
                }
        }

        /**************** Methods ****************/
        // Constructor 1
        public Account(Customer owner, DateTime openedDate, double initBalance = 0)
        {
            if (IsOpenedDateValid(openedDate))
            {
                _ID = GenerateID();
                _Owner = owner;
                _Owner.AddAccount(this);
                _OpenedDate = openedDate;
                _Balance = initBalance;
                _Active = true;
            }
        }
        
        // Constructor 2
        public Account(Customer owner, double initBalance = 0) : this(owner, DateTime.Now, initBalance)
        {
        }

        public void Close()
        {
            _Active = false;
            _ClosedDate = DateTime.Now;
        }

        public override string ToString()
        {
            if (Active)
                return string.Format("ID: {0,-5} Opened Date: {1,-12} Balance: {2,-10:0,0.0} Owner: {3,-7} {4,-10}", _ID, _OpenedDate.ToShortDateString(), _Balance, _Owner.FirstName, _Owner.LastName);
            else
                return string.Format("ID: {0,-5} Opened Date: {1,-12} Balance: {2,-10:0,0.0} Owner: {3,-7} {4,-10} - Closed on {5}", _ID, _OpenedDate.ToShortDateString(), _Balance, _Owner.FirstName, _Owner.LastName, _ClosedDate.ToShortDateString());
        }

        // Abstract Methods
        public abstract double CalculateInterest();

        // Virtual Methods
        public virtual void Transfer(Account toAccount, double amount)
        {
            if (IsValidForTransferring(toAccount, amount))
            {
                Balance -= amount;
                toAccount.Balance += amount;
            }
        }

        public virtual void UpdateBalance()
        {
            double interest = CalculateInterest();
            _Balance += interest;
        }

        // Auxiliary Methods
        // This method is used to generate an ID for a new account
        static ulong GenerateID()
        {
            _Count++;
            return _Count;
        }

        private bool IsBalanceValid(double balance)
        {
            if (balance < 0)
            {
                Console.WriteLine("Balance cannot be negative!");
                return false;
            }
            return true;
        }

        private bool IsOpenedDateValid(DateTime date)
        {
            if (DateTime.Compare(DateTime.Now, date) < 0)
            {
                Console.WriteLine(string.Format("Opened date must be on or before {0}", DateTime.Now.ToShortDateString()));
                return false;
            }
            return true;
        }

        protected bool IsValidForCalculatingInterest()
        {
            if (!Active)
            {
                Console.WriteLine("This account has been closed!");
                return false;
            }
            return true;
        }

        protected virtual bool IsValidForTransferring(Account destinationAccount, double amount)
        {
            if (!this.Active || !destinationAccount.Active)
            {
                Console.WriteLine("Transferring is applied only to active accounts!");
                return false;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Transferred amount must be greater than 0!");
                return false;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Transferred amount cannot exceed the balance of source account");
                return false;
            }
            return true;
        }
    }
}