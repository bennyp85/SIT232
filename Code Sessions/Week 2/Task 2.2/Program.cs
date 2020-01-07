using System;

namespace Task_2._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int number = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= number ; i++)
            {
                if (number % i == 0)
                    if (i < number/i)
                        Console.WriteLine("{0} * {1}", i, number/i);
            }
        }
    }
}