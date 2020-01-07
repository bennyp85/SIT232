using System;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // collect data from user input
            Console.Write("Please enter the call number: ");
            string callnumber = Console.ReadLine();
            Console.Write("Please enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Please enter the author: ");
            string author = Console.ReadLine();

            // construct the testing object
            LibraryBook aBook = new LibraryBook(callnumber, title, author);
            // display the object details
            Console.WriteLine("Caller Number: {0}", aBook.CallNumber);
            Console.WriteLine("Title        : {0}", aBook.Title);
            Console.WriteLine("Author       : {0}", aBook.Author);
        }
    }
}
