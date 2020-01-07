/*************************************************************
** File: StudentValidator.cs
** Author/s: Justin Rough
** Description:
**     This program demonstrates validity checking for a
** student number (eight or nine digits long), birth year
** (17-100 years old), birth month (1-12), and birth day (must
** be valid for month specified).
*************************************************************/
using System;

namespace StudentValidator
{
    class StudentValidator
    {
        #region Helper Methods
        private static bool AllDigits(string input)
        {
            bool result = true;

            foreach (char c in input)
            {
                if (char.IsDigit(c) == false)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static bool InRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }
        #endregion

        private static bool ValidStudentID(string input)
        {
            bool result = true;

            if (input.Length < 8 || input.Length > 9 || AllDigits(input) == false)
                result = false;

            return result;
        }

        private static bool ValidBirthYear(string input)
        {
            bool result = true;

            int minYear = DateTime.Now.Year - 100;
            int maxYear = DateTime.Now.Year - 17;
            if (AllDigits(input) == false || InRange(Convert.ToInt32(input), minYear, maxYear) == false)
                result = false;

            return result;
        }

        private static bool ValidBirthMonth(string input)
        {
            bool result = true;

            if (AllDigits(input) == false || InRange(Convert.ToInt32(input), 1, 12) == false)
                result = false;

            return result;
        }

        private static bool ValidBirthDay(string input, string month)
        {
            bool result = true;
            byte[] daysInMonth = new byte[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int monthNum = Convert.ToInt32(month);

            if (AllDigits(input) == false || InRange(Convert.ToInt32(input), 1, daysInMonth[monthNum - 1]) == false)
                result = false;

            return result;

        }

        static void Main(string[] args)
        {
            string studentID;
            do
            {
               sole.Write("Please enter the student ID: ");
               studentID = Console.ReadLine();
               if (ValidStudentID(studentID) == false)
		     {
                           Console.WriteLine("You have entered an invalid student ID, please try again.");
			     studentID = "";
			}
            }while(studentID == "" );

            string birthYear;
 		 do
            {
            Console.Write("Please enter the birth year: ");
            birthYear = Console.ReadLine();
            if (ValidBirthYear(birthYear) == false)
            {
                Console.WriteLine("You have entered an invalid birth year, please try again.");
                birthYear = ""
            }
		 }while(birthYear == "" );


            string birthMonth;
 		 do
            {
               Console.Write("Please enter the birth month: ");
               birthMonth = Console.ReadLine();
               if (ValidBirthMonth(birthMonth) == false)
            {
                Console.WriteLine("You have entered an invalid birth month, please try again.");
                birthMonth = ""
            }
	       }while(birthMonth == "" );
            string birthDay;
            do {
            Console.Write("Please enter the birth day: ");
            birthDay = Console.ReadLine();
            if (ValidBirthDay(birthDay, birthMonth) == false)
            {
                Console.WriteLine("You have entered an invalid birth day, please try again.");
                birthDay = "";
            }
		 }while(birthDay == "");

            Console.WriteLine("Validated data:");
            Console.WriteLine("\tStudent ID: {0}", studentID);
            Console.WriteLine("\tBirth date: {0}/{1}/{2}", birthDay, birthMonth, birthYear);
        }
    }
}