/*************************************************************
** File: RecursiveSum.cs
** Author/s: Justin Rough
** Description:
**     This program demonstrates the use of recursion to
** calculate the sum of all integers up to some maximum.
*************************************************************/
using System;

namespace SumUpTo
{
    class RecursiveSum
    {
        static uint SumUpTo(uint value)
        {
            uint result;

            if (value == 0) result = 0;    // base case
            else   // general case
                result = value + SumUpTo(value - 1);    
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter an integer value to sum up to: ");
            uint value = Convert.ToUInt32(Console.ReadLine());
            uint result = SumUpTo(value);
            Console.WriteLine("The sum of all numbers up to and including {0} is {1}", value, result);
        }
    }
}
