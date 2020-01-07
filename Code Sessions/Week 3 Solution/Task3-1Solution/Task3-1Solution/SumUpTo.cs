using System;
namespace Task3_1Solution
{
    class SumUpTo
    {  
        // attribute
        private uint _Number;

        public SumUpTo()
        {
            do Console.Write("Please enter an integer value to sum up to: ");
            while (uint.TryParse(Console.ReadLine(), out _Number) == false);       
        }

        public SumUpTo(uint number)
        {
            _Number = number;
        }

        private uint Sum(uint number)
        {         
            uint result;

            if (number == 0) result = 0;    // base case
            else   // general case
                result = number + Sum(number - 1);    
            return result;    
         }

        private string Display()
        {
            string temp = "Sum Up To " + _Number.ToString() + "\n";
            for (uint i = _Number; i > 0; i--)
                temp += string.Format("{0} + ", i);
            temp += string.Format("0\nThe sum of all numbers up to and including {0} is {1}\n", _Number, Sum(_Number));
            return temp;
        }

        public override string ToString()
        {
            return Display();
        }
    }
}
