/*************************************************************
** File: Program.cs
** Author/s: Justin Rough
** Description:
**     This program demonstrates the creation of multiple
** objects that are then linked together to form several
** orders of books.  The Order class includes a parameter-less
** constructor, custom-constructor to initialise the customer
** field, and a copy constructor, each of which is
** demonstrated in this example program.
*************************************************************/
using System;

namespace BookOrder
{
    class Program
    {
        static void DisplayOrder(Order order)
        {
            Console.WriteLine(order);
            foreach (Book b in order.Books)
                Console.WriteLine("-- {0}", b);
        }

        static void Main(string[] args)
        {
            Book deitel = new Book("Deitel, P., and Deitel, H.", "Visual C# 2012: How to Program", "Pearson", 2014);
            Book schildt = new Book("Schildt, H.", "C# 4.0: The Complete Reference", "Osborne Media", 2001);

            Order prescribed = new Order();
            prescribed.Add(deitel);

            Order recommended = new Order("Freddie");
            recommended.Add(schildt);

            Order both = new Order(prescribed);
            both.Add(schildt);

            DisplayOrder(prescribed);
            Console.WriteLine();
            DisplayOrder(recommended);
            Console.WriteLine();
            DisplayOrder(both);
        }
    }
}
