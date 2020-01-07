/*************************************************************
** File: StringChars.cs
** Author/s: Justin Rough
** Description:
**     Demonstrates how to extract and display each character
** in a string.  Also demonstrates how to select and use the
** relevant 'st', 'nd', or 'rd' suffix.
*************************************************************/
using System;

namespace StringChars
{
    class StringChars
    {
        static string GetSuffix(int value)
        {
            string result = "th";

            if (value % 100 < 11 || value % 100 > 19)
            {
                switch (value % 10)
                {
                    case 1:     result = "st";      break;
                    case 2:     result = "nd";      break;
                    case 3:     result = "rd";      break;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter some text: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("The {0}{1} character is '{2}'", i + 1, GetSuffix(i + 1), input[i]);
            }
        }
    }
}
