using System;

namespace Task_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jane = new Person("Bloggs", "Jane"); 
            Person joe = new Person("Bloggs", "Joe"); 
            Person peter = new Person("Piper", "Peter"); 
            Person penny = new Person("Piper", "Penny");
            
            new RentalByDay(jane, 5); 
            new RentalByDay(jane, 2); 
            jane.PrintRentals();
            
            new RentalByDay(joe, 8); 
            new RentalByKm(joe, 15); 
            joe.PrintRentals();
            
            new RentalByDay(peter, 1); 
            new RentalByKm(peter, 85); 
            peter.PrintRentals();
            
            new RentalByDay(penny, 5); 
            new RentalByKm(penny, 42); 
            penny.PrintRentals();
            
            Console.WriteLine("Quote for {0}", new RentalByDay(null, 10)); 
            Console.WriteLine("Quote for {0}", new RentalByKm(null, 10));        }
    }
}