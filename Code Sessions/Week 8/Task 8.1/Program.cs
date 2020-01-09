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
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Tech Field: ");
                string techField = Console.ReadLine();
                Console.WriteLine("Enter Pub Field: ");
                string pubField = Console.ReadLine();
                ExpertList.Add(new Expert(name, techField, pubField, null));
            }
            
            Console.WriteLine("\nExperts have the following technical expertise:");

            foreach (var VARIABLE in ExpertList)
            {
                Console.WriteLine(VARIABLE.TechField);
            }
            
            Console.WriteLine("\nExperts have the following publishing expertise:");
            
            foreach (var VARIABLE in ExpertList)
            {
                Console.WriteLine(VARIABLE.PubField);
            }
            
            Console.WriteLine("\nEnter name of project: ");
            string nameOfProject = Console.ReadLine();
            
            Console.WriteLine("Which Technical field do you need an expert in?");
            string techFieldNeeded = Console.ReadLine();
            Console.WriteLine("Which publishing field do you need an expert in?");
            string pubFieldNeeded = Console.ReadLine();

            foreach (var VARIABLE in ExpertList)
            {
                if (techFieldNeeded == VARIABLE.TechField && pubFieldNeeded == VARIABLE.PubField)
                {
                    Console.WriteLine("\n{0} is your expert", VARIABLE.Name);
                    VARIABLE.Project = nameOfProject;

                }
            }

            foreach (var VARIABLE in ExpertList)
            {
                if (VARIABLE.Project != null)
                {
                    Console.WriteLine("\n{0} has been assigned to {1}", VARIABLE.Name, VARIABLE.Project);
                }
            }
        }
    }
}