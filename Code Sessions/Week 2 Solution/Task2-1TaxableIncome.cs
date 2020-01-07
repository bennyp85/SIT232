/*************************************************************
** File: TaxableIncome.cs
** Author/s: Justin Rough
** Description:
**     This program exploits if statements to calculate the
**     tax payable for a particular income.
*************************************************************/
using System;

namespace TaxableIncome
{
    class TaxableIncome
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the taxable income (whole dollars only): $");
            int income = Convert.ToInt32(Console.ReadLine());

            decimal tax = 0;
            if (income < 6001) tax = 0;
            else if (income < 37001) tax = (income - 6000) * 0.15;
            else if (income < 80001) tax = (income - 37000) * 0.30 + 4650;
            else if (income < 180001) tax = (income - 80000) * 0.37 + 17550;
            else tax = (income - 180000) * 0.45 + 54550;
            Console.WriteLine("The taxable income for {0:c} is {1:c}", income, tax);
        }
    }
}
