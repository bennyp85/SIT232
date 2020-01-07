using System;
using System.Collections.Generic;


namespace Task3_1Solution
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter an integer value to sum up to: ");
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(new SumUpTo(num));

            Console.WriteLine(new SumUpTo());
        }
    }
}
