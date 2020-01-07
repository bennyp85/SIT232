/*************************************************************
** File: AgeChecker.cs
** Author/s: Justin Rough
** Description:
**     A simple program demonstrating how to use if
**     statements in the C# programming language.
*************************************************************/
using System;

namespace AgeChecker
{
    class AgeChecker
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age == 18)
                Console.WriteLine("You are exactly 18 years old!");
            if (age != 18)
                Console.WriteLine("You are not 18 years of age.");
            if (age < 18)
                Console.WriteLine("You are not yet 18 years old.");
            if (age > 18)
                Console.WriteLine("You?ve been 18 for at least a year.");
            if (age <= 18)
                Console.WriteLine("You are at most 18 years old.");
            if (age >= 18)
                Console.WriteLine("You are at least 18 years old.");
        }
    }
}