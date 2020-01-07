using System;

namespace Task_2._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your taxable income: ");

            int income = Convert.ToInt32(Console.ReadLine());
            double taxPayable = 0;

            if (income <= 6000)
                Console.WriteLine("You pay no tax");
            if (income > 6000 && income <= 37000)
                taxPayable = (income - 6000) * .15;
            if (income > 37000 && income <= 80000)
                taxPayable = 4650 + (income - 37000) * .30;
            if (income > 80000 && income <= 180000)
                taxPayable = 17550 + (income - 80000) * .37;
            if (income > 180000)
                taxPayable = 54550 + (income - 180000) * .45;
            Console.WriteLine("You pay " + taxPayable + " tax");
        }
    }
}