/*************************************************************
** File: Program.cs
** Author/s: Justin Rough
** Description:
**     A simple program demonstrating how to invoke different
** overloaded constructors in an Account class and display the
** resulting balance.
*************************************************************/
using System;

namespace CustomConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Account plessAccount = new Account();
            Console.WriteLine("Account created with parameter-less constructor has balance {0:c}", plessAccount.Balance);

            Account customAccount = new Account(500.00M);
            Console.WriteLine("Account created with custom constructor has balance {0:c}", customAccount.Balance);

            Account copiedAccount = new Account(customAccount);
            Console.WriteLine("Account created with copy constructor (from custom) has balance {0:c}", copiedAccount.Balance);
        }
    }
}
