/*************************************************************
** File: Factors.cs
** Author/s: Justin Rough
** Description:
**     A program demonstrating how to use loops to calculate
**     the factors of a number, i.e., which values evenly
**     divide the number.
*************************************************************/
using System;

namespace Factors
{
    class Factors
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (number / i > i) Console.WriteLine("{0} * {1} = {2}", i, number / i, number);
                    else break;
                }
            }
        }
    }
}
