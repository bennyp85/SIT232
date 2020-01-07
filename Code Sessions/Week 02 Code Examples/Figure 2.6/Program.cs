/*************************************************************
** File: Program.cs
** Author/s: Justin Rough
** Description:
**     A simple program that demonstrates how create an object
** and invoke a method defined by that object's class.
*************************************************************/
using System;

namespace TrivialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TrivialClass trivialObject = new TrivialClass();
            Console.WriteLine(trivialObject.GetMessage());
        }
    }
}
