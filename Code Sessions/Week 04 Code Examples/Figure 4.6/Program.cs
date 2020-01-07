/*************************************************************
** File: Program.cs
** Author/s: Justin Rough
** Description:
**     A simple program demonstrating how to use the ToString
** methods for a simple Person class.
*************************************************************/
using System;

namespace ToStringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bridget = new Person("Bridget", "Jones");
            Person fred = new Person("Fred", "Flintstone");
            Person humphrey = new Person("Humphrey B.", "Bear");

            Console.WriteLine(bridget);
            Console.WriteLine(fred.ToString());
            Console.WriteLine("{0}", humphrey);
        }
    }
}
