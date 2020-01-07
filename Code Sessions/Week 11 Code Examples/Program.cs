/*************************************************************
** File: Program.cs
** Author/s: Justin Rough
** Description:
**     This program demonstrates how to use a binary file
** with random access, both to write a number of records to
** the file, then to read back random records from that file.
*************************************************************/
using System;
using System.IO;

namespace RandomAccessFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream testFile = new FileStream(@"students.dat", FileMode.Create, FileAccess.ReadWrite);

            // Student names taken from Top 100 singles on Australian charts for 2000
            // Source: http://www.aria.com.au/pages/aria-charts-end-of-year-charts-top-100-singles-2000.htm
            Student.ToStream(testFile, new Student(1001, "Anastacia",       1991,  1,  1));
            Student.ToStream(testFile, new Student(1002, "Wheatus",         1992,  2,  2));
            Student.ToStream(testFile, new Student(1003, "Bomfunk MCs",     1993,  3,  3));
            Student.ToStream(testFile, new Student(1004, "Madonna",         1994,  4,  4));
            Student.ToStream(testFile, new Student(1005, "Destiny's Child", 1995,  5,  5));
            Student.ToStream(testFile, new Student(1006, "Bardot",          1996,  6,  6));
            Student.ToStream(testFile, new Student(1007, "*N Sync",         1997,  7,  7));
            Student.ToStream(testFile, new Student(1008, "Madison Avenue",  1998,  8,  8));
            Student.ToStream(testFile, new Student(1009, "Spiller",         1999,  9,  9));
            Student.ToStream(testFile, new Student(1010, "Mary Mary",       2000, 10, 10));
            Student.ToStream(testFile, new Student(1011, "Mandy Moore",     2001, 11, 11));
            Student.ToStream(testFile, new Student(1012, "Chris Franklin",  2002, 12, 12));

            Random rnd = new Random();
            Student s;
            Console.Write("Press ENTER or type anything and ENTER to quit: ");
            string input = Console.ReadLine();
            while (input == "")
            {
                int which = rnd.Next(0, 12); // random number from 0-11
                testFile.Seek(which * Student.RecordLength, SeekOrigin.Begin);
                Student.FromStream(testFile, out s);
                Console.WriteLine("{0,2}: {1}", which, s);
                Console.Write("Press ENTER or type anything and ENTER to quit: ");
                input = Console.ReadLine();
            }

            testFile.Close();
        }
    }
}
