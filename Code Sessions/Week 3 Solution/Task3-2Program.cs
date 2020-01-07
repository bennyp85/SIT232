/*************************************************************
** File: StandardDeviation.cs
** Author/s: Justin Rough
** Description:
**     This program demonstrates the use of the generic List
** class and Math class to calculate the standard deviation
** for a variable number of numerical values.
*************************************************************/
using System;
using System.Collections.Generic;

namespace StandardDeviation
{
    class StandardDeviation
    {
        static double StdDev(List<double> values)
        {
            double sum = 0.0;
            foreach (double val in values) sum += val;
            double mean = sum / values.Count;

            sum = 0.0;
            foreach (double val in values)
			  sum += (val-mean)*(val-mean)
              //  sum += Math.Pow(val - mean, 2.0);

            return Math.Sqrt(sum / (values.Count - 1));
        }

        static void Main(string[] args)
        {
            List<double> data = new List<double>();
            string input;
		 do
		 {
               double value;
            Console.Write("Please enter a numeric value or END to finish: ");

            if (input.ToUpper() != "END" && double.TryParse(input, out value))
			data.Add(value);
		  else
		  {
		      Console.WriteLine("Must enter numeric value!");
			 input = "";
		  }
            }while(input.ToUpper() != "END"); 

            Console.WriteLine("The standard deviation of the entered numbers is {0}", StdDev(data));
        }
    }
}