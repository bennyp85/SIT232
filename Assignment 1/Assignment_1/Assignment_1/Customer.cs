using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace Assignment_1
{
    public class Customer
    {
        // Need to add List to object
        public Customer(string firstName, string lastName, string address, DateTime dob, string phoneNumber = "" , string email = "")
        {
            _FirstName = firstName;
            _LastName = lastName;
            _Address = address;
            DOB = dob;
            PhoneNumber = phoneNumber;
            _Email = email;
            _Account = new List<Account>();
        }

        // Required
        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        // Required
        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        // Required
        private string _Address;
        public string Address 
        {
            get { return _Address; }
            set { _Address = value; }
        }

        // Required
        // DOB must be > 16
        private DateTime _DOB;
        public DateTime DOB
        {
            get { return _DOB; }
            set { 
                if (DateTime.Now.Year - _DOB.Year >= 16) 
                _DOB = value; 
                }
        }

        // Not Required but must be 10 digits
        private string _PhoneNumber;
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set
            {
                string tmpPhoneNumber = value;

                if (tmpPhoneNumber.Length == 10)
                    _PhoneNumber = tmpPhoneNumber;
            }
        }

        // Not Required
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        // Copy constructor
        public Customer(Customer copyCustomer)
        {
            _FirstName = copyCustomer.FirstName;
            _LastName = copyCustomer.LastName;
            _Address = copyCustomer.Address;
            _DOB = copyCustomer.DOB;
            _PhoneNumber = copyCustomer.PhoneNumber;
            _Email = copyCustomer.Email;
            _Account = new List<Account>(copyCustomer.Accounts);
        }


        //List of accounts
        public List<Account> _Account;

        public ReadOnlyCollection<Account> Accounts
        {
            get { return _Account.AsReadOnly(); }    
        }

        public void AddAccount(Account anAccount)
        {
            _Account.Add(anAccount);
        }

        // sum Balance
        // must return list of Accounts owned by Customer
        // Sum balance of all accounts
        public decimal SumBalance()
        {
            decimal balance = 0;

            foreach (Account i in _Account)
            {
                balance += i.Balance;
            }

            return balance;
        }

		// ToString Method
		public override string ToString()
		{
            //decimal totalBalance = SumBalance();
            return string.Format("Name: {0, -10} {1, -10} \t Address: {2, -20} \t DOB: {3, -12} \t Phone Number: {4, -10} \t Email: {5, -15} \t Balance: {6:C}", FirstName, LastName, Address, DOB.ToShortDateString(), PhoneNumber, Email, SumBalance());
		}

	}
}
