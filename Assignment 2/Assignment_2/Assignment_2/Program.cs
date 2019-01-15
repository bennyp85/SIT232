using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;


namespace Assignment_2
{
    class Program
    {
        
        static void WriteCustomers(string customerFileName, List<Customer> customers)
        {
            FileStream fs = File.Open(customerFileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(customers.Count);
            foreach (Customer c in customers)
                c.ToStream(sw);
            sw.Close();
        }

        static void WriteAccounts(string accountFileName, List<Account> accounts)
        {
            FileStream fs = File.Open(accountFileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(accounts.Count);
            foreach (Account a in accounts)
                a.ToStream(sw);
            sw.Close();
        }

        static void WriteData(string customerFileName, string accountFileName, List<Customer> customers, List<Account> accounts)
        {
            WriteCustomers(customerFileName, customers);
            WriteAccounts(accountFileName, accounts);
        }

        static void LoadData(string customerFileName, string accountFileName, List<Customer> customers, List<Account> accounts)
        {
            LoadCustomers(customerFileName, customers);
            LoadAccounts(accountFileName, customers, accounts);
        }


        static void LoadCustomers(string customerFileName, List<Customer> customers)
        {
            FileStream fs = File.Open(customerFileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int nCustomers = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < nCustomers; i++)
            {
                Customer c = new Customer(sr);
                customers.Add(c);
            }
            sr.Close();
            //fs.Close();
        }

        static void LoadAccounts(string accountFileName, List<Customer> customers, List<Account> accounts)
        {
            FileStream fs = File.Open(accountFileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int nAccounts = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < nAccounts; i++)
            {
                int accountType = Convert.ToInt32(sr.ReadLine());

                Account a = null;
                if (accountType == 1)
                    a = new Type1Acc(sr, customers);
                else
                    a = new Type2Acc(sr, customers);
                
                accounts.Add(a);
            }
            sr.Close();
            //fs.Close();
        }

        public static void Main(string[] args)
        {

            string customerFileName = "customers.txt";
            string accountFileName = "accounts.txt";

            List<Customer> customers = new List<Customer>();
            List<Account> accounts = new List<Account>();

            LoadData(customerFileName, accountFileName, customers, accounts);

            Menus menus = new Menus(customers, accounts);
            menus.MainMenu();

            WriteData(customerFileName, accountFileName, customers, accounts);

            Console.ReadLine();
        }
    }
}
