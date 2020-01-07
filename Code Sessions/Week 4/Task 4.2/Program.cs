using System;
using System.Collections;
using System.Linq;

namespace Task_4._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            object[] a = new object[3];
            BookStock bookStock1 = new BookStock(2, "The Book1", 25);
            BookStock bookStock2 = new BookStock(5, "The Book2", 10);
            BookStock bookStock3 = new BookStock(3, "The Book3", 44);
            a[0] = bookStock1;
            a[1] = bookStock2;
            a[2] = bookStock3;
            ProduceReport(a);



        }

        static void ProduceReport(object[] a)
        {
            Console.WriteLine("Qty | Description                  | Cost");
            Console.WriteLine("=========================================");
            foreach (var VARIABLE in a)
            {
                Console.WriteLine(VARIABLE.ToString());    
            }
            
        }

        
    }

    class BookStock
    {

        private int _quantity;
        private string _description;
        private int _price;
        
        public BookStock(int quantity, string description, int price)
        {
            _quantity = quantity;
            _description = description;
            _price = price;
        }
        
        public override string ToString() => $" {_quantity}  | {_description}                    | {_price}";
        
    }
}