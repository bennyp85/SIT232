/*************************************************************
** File: SimpleMenu.cs
** Author/s: Justin Rough
** Description:
**     A simple program that demonstrates how to use a while
**     loop to construct a simple menu.
*************************************************************/
using System;

namespace SimpleMenu
{
    class SimpleMenu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Say hello");
            Console.WriteLine("2. Say goodbye");
            Console.WriteLine("0. Exit");
            Console.Write("Selection? ");
            int selection = Convert.ToInt32(Console.ReadLine());
            while (selection != 0)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;
                    case 2:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
                Console.WriteLine("1. Say hello");
                Console.WriteLine("2. Say goodbye");
                Console.WriteLine("0. Exit");
                Console.Write("Selection? ");
                selection = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}