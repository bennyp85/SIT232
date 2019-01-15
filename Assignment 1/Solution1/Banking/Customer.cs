using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Customer
    {
        /**************** Attributes ****************/
        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private DateTime _DOB;
        public DateTime DOB
        {
            get { return _DOB; }
            set {
                if (IsDOBValid((DateTime) value)) 
                    _DOB = value;
                }
        }

        private string _Contact;
        public string Contact
        {
            get { return _Contact; }
            set {
                if (IsContactValid((string) value))
                    _Contact = value;
                }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private List<Account> _Accounts;

        /**************** Methods ****************/
        // Constructor 1
        public Customer(string firstName, string lastName, string address, DateTime dob, string contact = "", string email = "")
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            DOB = dob;
            Contact = contact;
            Email = email;
            _Accounts = new List<Account>();
        }

        // Copy constructor
        public Customer(Customer c) : this(c.FirstName, c.LastName, c.Address, c.DOB, c.Contact, c.Email)
        {
            _Accounts = new List<Account>(c._Accounts);
        }

        public void AddAccount(Account account)
        {
            _Accounts.Add(account);
        }

        public double SumBalance()
        {
            double sumBalance = 0;
            for (int i = 0; i < _Accounts.Count; i++)
                sumBalance += _Accounts[i].Balance;
            return sumBalance;
        }

        public override string ToString()
        {
            double totalBalance = SumBalance();
            return string.Format("Name: {0,-7} {1,-10} Addres: {2,-14} DOB: {3,-12} Contact: {4,-12} Email: {5,-18} Total balance: {6,-10:0,0.0}", _FirstName, _LastName, _Address, _DOB.ToShortDateString(), _Contact, _Email, totalBalance);
        }

        // Auxiliary methods
        private bool IsDOBValid(DateTime dob)
        {
            if (DateTime.Now.Year - dob.Year < 16)
            {
                Console.WriteLine("Invalid Date of birth");
                return false;
            }
            return true;
        }

        private bool IsContactValid(string contact)
        { 
            // This method is not complete and you need to complete it
            return true;
        }
    }
}
