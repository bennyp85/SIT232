/*************************************************************
** File: EvenNumbers.cs
** Author/s: Justin Rough
** Description:
**     A simple program that demonstrates how to use the break
** and continue statements in a loop to control its execution.
*************************************************************/
using System;

namespace EvenNumbers
{
    class EvenNumbers
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i > 10)
                    break;
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}