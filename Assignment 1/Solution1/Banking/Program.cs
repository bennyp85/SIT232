using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customers
            Customer c1 = new Customer("Arley", "Praise", "12 Hay Rd", new DateTime(1990, 10, 2), "0412232116", "arleyp@gmail.com");
            Customer c2 = new Customer("Joseph", "Abot", "4/1 Mandy Pl", new DateTime(1970, 5, 11), "0413221624");
            Customer c3 = new Customer("Rose", "Magaret", "30 Buxton St", new DateTime(1980, 7, 6), email: "rmt@yahoo.com");

            // Accounts
            Account a1 = new Type1Account(c1, new DateTime(2018, 2, 1), 100);
            Account a2 = new Type2Account(c1, new DateTime(2018, 2, 15), 5000);
            Account a3 = new Type1Account(c2, new DateTime(2018, 3, 20));
            Account a4 = new Type2Account(c3, new DateTime(2018, 3, 4), 2000);
            Account a5 = new Type2Account(c3, 3000);

            // Transactions
            Console.Write("Deposit $-200 to c1 -- ");
            ((Type1Account)a1).Deposit(-200);
            Console.WriteLine();

            Console.Write("Transfer $6000 from a2 to a1 -- ");
            ((Type2Account)a2).Transfer(a1, 6000);
            Console.WriteLine();

            Console.Write("Transfer $2000 from a2 to a1 -- ");
            ((Type2Account)a2).Transfer(a1, 2000);
            Console.WriteLine();

            Console.Write("Transfer $1000 from a1 to a2 -- ");
            ((Type1Account)a1).Transfer(a2, 1000);
            Console.WriteLine();

            Console.Write("Set the monthly deposit of a2 to $200 -- ");
            ((Type2Account)a2).MonthlyDeposit = 200;
            Console.WriteLine();

            Console.Write("Deposit $5000 to a3 -- ");
            ((Type1Account)a3).Deposit(5000);
            Console.WriteLine();

            Console.Write("Withdraw $6000 from a3 -- ");
            ((Type1Account)a3).Withdraw(6000);
            Console.WriteLine();

            Console.Write("Transfer $1000 from a3 to a1 -- ");
            ((Type1Account)a3).Transfer(a1, 1000);
            Console.WriteLine();

            Console.Write("Transfer $500 from a3 to a2 -- ");
            ((Type1Account)a3).Transfer(a2, 500);
            Console.WriteLine();

            Console.Write("Set the monthly deposit of a4 to $1000 -- ");
            ((Type2Account)a4).MonthlyDeposit = 1000;
            Console.WriteLine();

            Console.Write("Transfer $100 from a4 to a1 -- ");
            ((Type2Account)a4).Transfer(a1, 100);
            Console.WriteLine();

            Console.Write("Set the monthly deposit of a5 to $1500 -- ");
            ((Type2Account)a5).MonthlyDeposit = 1500;
            Console.WriteLine();

            Console.Write("Transfer $500 from a5 to a4 -- ");
            ((Type2Account)a5).Transfer(a4, 500);
            Console.WriteLine();

            // Calculate interest
            Console.WriteLine("\nCalculate interest");
            Console.WriteLine(String.Format("Interest of a1: {0:,0.0}", a1.CalculateInterest()));
            Console.WriteLine(String.Format("Interest of a2: {0:,0.0}", a2.CalculateInterest()));
            Console.WriteLine(String.Format("Interest of a3: {0:,0.0}", a3.CalculateInterest()));
            Console.WriteLine(String.Format("Interest of a4: {0:,0.0}", a4.CalculateInterest()));
            Console.WriteLine(String.Format("Interest of a5: {0:,0.0}", a5.CalculateInterest()));

            // Update balance
            Console.WriteLine("\nUpdating balance");
            a1.UpdateBalance();
            a2.UpdateBalance();
            a3.UpdateBalance();
            a4.UpdateBalance();
            a5.UpdateBalance();

            // Close some accounts
            a3.Close();
            a5.Close();

            // Display accounts' information
            Console.WriteLine("\nAccounts' information");
            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2.ToString());
            Console.WriteLine(a3.ToString());
            Console.WriteLine(a4.ToString());
            Console.WriteLine(a5.ToString());

            // Display customers' information
            Console.WriteLine("\nCustomers' information");
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());

            Console.ReadLine();
        }
    }
}
