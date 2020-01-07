/*************************************************************
** File: Grader.cs
** Author/s: Justin Rough
** Description:
**     A simple program demonstrating how to use switch
**     statements to check multiple possible results for an
**     expression and perform different statements.
*************************************************************/
using System;

namespace Grader
{
    class Grader
    {
        static void Main(string[] args)
        {
            Console.Write("What grade did you achieve? ");
            string grade = Console.ReadLine();

            switch (grade.ToUpper())
            {
                case "HD":
                    Console.WriteLine("You got >= 80 marks, great!");
                    break;
                case "D":
                    Console.WriteLine("You got >= 70 marks, well done!");
                    break;
                case "C":
                    Console.WriteLine("You got >= 60 marks, good!");
                    break;
                case "P":
                    Console.WriteLine("You got >= 50 marks, not bad!");
                    break;
                case "N":
                    Console.WriteLine("You didn't pass, try again!");
                    break;
                default:
                    Console.WriteLine("Sorry, I don't know that grade.");
                    break;
            }
        }
    }
}