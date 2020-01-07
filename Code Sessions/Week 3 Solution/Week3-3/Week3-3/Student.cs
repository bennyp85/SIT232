using System;

namespace Week3_3
{
    class Student
    {
        private string _ID;
        private DateTime _DOB;

        public Student()
        {
           /* do
            {
                _ID = Utilities.GetString("Please enter the student ID: ");
                if (_ID.Length < 8 || _ID.Length > 9 || Utilities.Digits(_ID) == false)
                {
                    Console.WriteLine("You have entered an invalid student ID, please try again. ");
                    _ID = "";
                }
            } while (_ID == "");*/

            do _ID = Utilities.GetString("Please enter the student ID: ");
            while(_ID.Length < 8 || _ID.Length > 9 || Utilities.Digits(_ID) == false);

            int y;
            do Console.Write("\nPlease enter the birth year: ");
            while (int.TryParse(Console.ReadLine(), out y) == false || y < DateTime.Now.Year - 100 || y > DateTime.Now.Year - 17);

            int m;
            do Console.Write("\nPlease enter the birth month: ");
            while (int.TryParse(Console.ReadLine(), out m) == false || m < 1 || m > 12);

            int d;
            do Console.Write("\nPlease enter the birth day: ");
            while (int.TryParse(Console.ReadLine(), out d) == false || (Utilities.DOM(y, m, d)) == false);
            _DOB = new DateTime(y, m, d);
        }

        public override string ToString()
        {
            return string.Format("\nValidated data:\n\tStudent ID: {0}\n\tBirth date: {1:d2}/{2:d2}/{3:d4}\n", _ID, _DOB.Day, _DOB.Month, _DOB.Year);
        }
    }
}
