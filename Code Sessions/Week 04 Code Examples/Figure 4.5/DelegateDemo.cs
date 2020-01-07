/*************************************************************
** File: DelegateDemo.cs
** Author/s: Justin Rough
** Description:
**     A simple program demonstrating how to create a delegate
** type, create a delegate variable, assign a method reference
** to the delegate variable and invoke the method referenced
** by the delegate.
*************************************************************/
using System;

namespace DelegateDemo
{
    class DelegateDemo
    {
        private delegate string ValueTester(int value);

        static string IsZero(int value)
        {
            if (value == 0)
                return string.Format("{0} is zero", value);
            else
                return string.Format("{0} is NOT zero", value);
        }

        static void Main(string[] args)
        {
            ValueTester delegateVariable = IsZero;

            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(delegateVariable(number));
        }
    }
}
