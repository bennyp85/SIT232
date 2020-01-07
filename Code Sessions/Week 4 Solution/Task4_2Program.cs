/*************************************************************
** File: Program.cs
** Author/s: Justin Rough
** Description:
**     This program demonstrates how to prepare a formatted
** report for a text-based device, in this case the console.
** Three book objects are created which are then passed in an
** array to the ProduceReport method which formats them
** appropriately.
*************************************************************/
using System;

namespace ReportWriting
{
    class Program
    {
        static void ProduceReport(BookStock[] bookList)
        {
            Console.WriteLine("+-----+-----------------------------------------------+------------+");
            Console.WriteLine("| Qty | Description                                   |    Cost    |");
            Console.WriteLine("+-----+-----------------------------------------------+------------+");

            string qty, desc, price;
            foreach (BookStock bs in bookList)
            {
                qty = bs.Quantity.ToString();
                desc = bs.Description;
                price = bs.Price.ToString("c"); // equivalent to: price = string.Format("{0:c}", bs.Price);

                if (qty.Length > 3)
                    qty = new string('*', 3);
                if (desc.Length > 45)
                    desc = desc.Substring(0, 43) + ">>";
                if (price.Length > 10)
                    price = new string('*', 10);

                Console.WriteLine("| {0,3} | {1,-45} | {2,10:c} |", qty, desc, price);
            }

            Console.WriteLine("+-----+-----------------------------------------------+------------+");
        }

        static void Main(string[] args)
        {
            BookStock[] books = new BookStock[3];
            books[0] = new BookStock(5, "Visual C#: How to Program", 134.95M);
            books[1] = new BookStock(50, "Database Systems", 119.95M);
            books[2] = new BookStock(500, "HTML & XHTML: The Complete Reference", 72.00M);

            ProduceReport(books);
        }
    }
}
