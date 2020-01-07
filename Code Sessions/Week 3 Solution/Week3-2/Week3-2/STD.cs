using System;
using System.Collections.Generic;


namespace Week3_2
{
    class STD
    {
        private List<double> _Number = new List<double>();

        public STD()
        {
            string input;
            do
            {
                Console.Write("Please enter a numeric value or END to finish: ");
                input = Console.ReadLine();
                double num;
                if (input.ToUpper() != "END")
                    if (double.TryParse(input, out num)) _Number.Add(num);
            } while (input.ToUpper() != "END");
        }

        private double Calculate()
        {
            double avg = 0;
            foreach (double d in _Number) avg += d;
            avg /= _Number.Count;
            double sum = 0;
            foreach (double d in _Number) sum += Math.Pow(d - avg, 2);
            return Math.Sqrt(sum / (_Number.Count - 1));
        }
        public override string ToString()
        {
            return string.Format("The standard deviation of the entered numbers is {0}", Calculate());
        }

    }
}
