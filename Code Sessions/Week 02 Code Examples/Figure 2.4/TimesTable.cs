/*************************************************************
** File: TimesTable.cs
** Author/s: Justin Rough
** Description:
**     A simple program that demonstrates how to use for loops
** to produce a multiplication table for the input 1-12.
*************************************************************/
using System;

namespace TimesTable
{
    class TimesTable
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write("{0,3} ", i * j);
                }
                Console.WriteLine();
            }
        }
    }
}