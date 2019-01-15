using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;

namespace Assignment_2
{
    public class Customer
    {
        // Need to add List to object
        public Customer(string firstName, string lastName, string address, DateTime dob, string phoneNumber = "", string email = "")
        {
            _NCustomers++;
            _ID = _NCustomers;
            _FirstName = firstName;
            _LastName = lastName;
            _Address = address;
            _DOB = dob;
            _PhoneNumber = phoneNumber;
            _Email = email;
            _AccID = GenerateID();
            _Account = new List<Account>();
        }

        public Customer(StreamReader sr)
        {
            _ID = Convert.ToUInt64(sr.ReadLine());
            _NCustomers = Math.Max(_NCustomers, _ID);
            _FirstName = sr.ReadLine();
            _LastName = sr.ReadLine();
            _Address = sr.ReadLine();
            _DOB = Convert.ToDateTime(sr.ReadLine());
            _PhoneNumber = sr.ReadLine();
            _Email = sr.ReadLine();
            _Account = new List<Account>();
        }


        private static ulong _NCustomers = 0;

        private ulong _ID;
        public ulong ID
        {
            get { return _ID; }
        }

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
            set
            {
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
            _AccID = GenerateID();
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

            if (_Account != null) 
            foreach (Account i in _Account)
            {
                balance += i.Balance;
            }

            return balance;
        }
    
        // ToString Method
        public override string ToString()
        {
            return string.Format("ID: {0, -10} \t Name: {1, -10} {2, -10} \t Address: {3, -20} \t DOB: {4, -12} \t Phone Number: {5, -10} \t Email: {6, -15} \t Balance: {7:C}", ID, FirstName, LastName, Address, DOB, PhoneNumber, Email, SumBalance());
        }

        public void ToStream(StreamWriter sw)
        {
            sw.WriteLine(_ID);
            sw.WriteLine(_FirstName);
            sw.WriteLine(_LastName);
            sw.WriteLine(_Address);
            sw.WriteLine(_DOB);
            sw.WriteLine(_PhoneNumber);
            sw.WriteLine(_Email);
        }

    }
}
