using System;

namespace Task_2._4
{
    internal class LibraryBook
    {
        public LibraryBook(string author, string title, string callNo)
        {
            _Author = author;
            _Title = title;
            _CallNo = callNo;
        }

        public string _CallNo { get; set; }

        public string _Title { get; set; }

        public string _Author { get; set; }

        public static void Main(string[] args)
        {
            Console.WriteLine("Author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Call Number: ");
            string callNo = Console.ReadLine();

            LibraryBook libraryBook = new LibraryBook(author, title, callNo);

            Console.WriteLine("Author: {0}", libraryBook._Author);
            Console.WriteLine("Title: {0}", libraryBook._Title);
            Console.WriteLine("Call Number: {0}", libraryBook._CallNo);
        }
    }
}