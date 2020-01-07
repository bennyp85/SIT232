using System;


namespace Week3_3
{
    class Utilities
    {
        public static string GetString(string msg)
        {
            string data = "";
            do
            {
                Console.Write(msg);
                data = Console.ReadLine();
            } while (data == "" || data[0] == ' ');
            return data;    
        }

        public static bool Digits(string data)
        {
            bool result = true;
            foreach (char c in data) if (!Char.IsDigit(c)) { result = false; break; }
            return result;
        }

        public static bool DOM(int y, int m, int d)
        {
            bool result = true;
            try
            {
                DateTime temp = new DateTime(y, m, d);
            }
            catch(Exception e)
            {
                Console.WriteLine("You have entered an invalid birth day {0}, please try again.", e.Message);
                result = false;
            }
            return result;
        }
    }
}
