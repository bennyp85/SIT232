using System;

namespace Task_3._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number to sum: ");
            uint number = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine(SumUpTo(number));
        }

        static uint SumUpTo(uint number)
        {
            uint result;

            if (number == 0) result = 0;
            else
            {
                result = number += SumUpTo(number - 1);
            }
            
            return result;
        }

    }

}