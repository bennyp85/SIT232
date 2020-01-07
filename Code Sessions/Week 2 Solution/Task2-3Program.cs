using System;

namespace TelephoneContact
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input data
            Console.Write("Please enter the family name: ");
            string family = Console.ReadLine();
            Console.Write("Please enter the given name: ");
            string given = Console.ReadLine();
            Console.Write("Please enter the telephone number: ");
            string telephone = Console.ReadLine();
            // constructur Person testing object
            Person demoPerson = new Person(family, given, telephone);
            // using properties to display the object details
            Console.WriteLine("     Family Name: {0}", demoPerson.FamilyName);
            Console.WriteLine("      Given Name: {0}", demoPerson.GivenName);
            Console.WriteLine("Telephone Number: {0}", demoPerson.TelephoneNumber);
        }
    }
}
