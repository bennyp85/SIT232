using System;
using System.Globalization;
using System.Collections.Generic;


namespace Assignment_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer("Arley", "Praise", "12 Hay Rd", new DateTime(1990, 10, 2), "0412232116", "arleyp@gmail.com");
            Customer c2 = new Customer("Joseph", "Abot", "4/1 Mandy Pl", new DateTime(1970, 05, 11), "0413221624");
            Customer c3 = new Customer("Rose", "Margaret", "30 Buxton St", new DateTime(1980, 07, 06), email : "rmt@yahoo.com");



            Account a1 = new Type1Acc(c1, new DateTime(2018, 02, 01), 100);
            Account a2 = new Type2Acc(c1, new DateTime(2018, 02, 15), 5000);
            Account a3 = new Type1Acc(c2, new DateTime(2018, 03, 20));
            Account a4 = new Type2Acc(c3, new DateTime(2018, 03, 04), 2000);
            Account a5 = new Type2Acc(c3, DateTime.Now, 3000);

            ((Type1Acc) a1).Deposit(200M);
            a2.Transfer(a1, 6000M);
            a2.Transfer(a1, 2000M);
            a1.Transfer(a2, 1000M);
            ((Type2Acc) a2).MonthlyDeposit = 200M;
            ((Type1Acc) a3).Deposit(5000M);
            ((Type1Acc) a3).Withdraw(6000M);
            a3.Transfer(a1, 1000M);
            a3.Transfer(a2, 500M);
            ((Type2Acc) a4).MonthlyDeposit = 1000M;
            a4.Transfer(a1, 100M);
            ((Type2Acc) a5).MonthlyDeposit = 1500M;
            a5.Transfer(a4, 500M);

            Console.WriteLine("Calculate Interest");
            Console.WriteLine("Interest for a1: {0:C}", a1.CalculateInterest());
            Console.WriteLine("Interest for a2: {0:C}", a2.CalculateInterest());
            Console.WriteLine("Interest for a3: {0:C}", a3.CalculateInterest());
            Console.WriteLine("Interest for a4: {0:C}", a4.CalculateInterest());
            Console.WriteLine("Interest for a5: {0:C}", a5.CalculateInterest());

            Console.WriteLine();

            Console.WriteLine("Updating Balance . . .");

            Console.WriteLine();

            a1.UpdateBalance();
            a2.UpdateBalance();
            a3.UpdateBalance();
            a4.UpdateBalance();
            a5.UpdateBalance();

            a3.close();
            a5.close();

            Console.WriteLine("Account Info");
            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2.ToString());
            Console.WriteLine(a3.ToString());
            Console.WriteLine(a4.ToString());
            Console.WriteLine(a5.ToString());

            Console.WriteLine();

            Console.WriteLine("Cusomer Info");
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());


        }
    }
}
