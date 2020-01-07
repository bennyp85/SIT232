using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Task_6._3
{
    public class Person
    {
        private Rental[] _Rentals;
        private int total_rentals;

        public Person(string lastName, string firstName)
        {
            _LastName = lastName;
            _FirstName = firstName;
            _Rentals = new Rental[5];
            total_rentals = 0;
        }

        private string _LastName;
        public string LastName
        {
            get => _LastName;
            set => _LastName = value;
        }

        private string _FirstName;
        public string FirstName
        {
            get => _FirstName;
            set => _FirstName = value;
        }

        public void RentCar(Rental rental)
        {
            _Rentals[total_rentals++] = rental;
        }


        public void PrintRentals()
        {
            Console.WriteLine("{0}, {1}", _LastName, _FirstName);
            for(int i = 0; i < total_rentals; i++) Console.WriteLine("\t{0}", _Rentals[i]);
            Console.WriteLine();
        }
    }
}