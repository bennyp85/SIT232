using System;
using System.Collections.Generic;

namespace Task_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Expert> ExpertList = new List<Expert>();
            Console.WriteLine("Enter # of Experts: ");
            int numOfExperts = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < numOfExperts; i++)
            {
                Console.WriteLine("Enter Tech Field: ");
                string techField = Console.ReadLine();
                Console.WriteLine("Enter Pub Field: ");
                string pubField = Console.ReadLine();
                ExpertList.Add(new Expert(techField, pubField, null));
            }

            Console.WriteLine();
            Console.WriteLine("Experts have the following technical expertise:");
            // Print list of Expert fields
            foreach (var VARIABLE in ExpertList)
            {
                Console.WriteLine(VARIABLE.TechField);
            }

            Console.WriteLine();
            Console.WriteLine("Experts have the following publishing expertise:");
            
            foreach (var VARIABLE in ExpertList)
            {
                Console.WriteLine(VARIABLE.PubField);
            }
            
        }
    }
}