lusing System;

namespace Task6_3
{
  class Person
  {
    private string _LastName;
    private string _FirstName; 
    private Rental[] _Rentals;
    private int total_rentals;

    public string LastName { get { return _LastName;  } }
    public string FirstName { get { return _FirstName; } }
    
    // no properties for _Rentals and _total_rental as manipulate internal by AddRental and retrieve by PrintRentals

    public Person(string lastName, string firstName)
    {
      _LastName = lastName;
      _FirstName = firstName;
      _Rentals = new Rental[5];
      total_rentals = 0;
    }

    public void AddRental(Rental rental)
    {
      if(total_rentals < 5 && rental != null)
         _Rentals[total_rentals++] = rental;
      // else ignore - Not process the record
    }

    public void PrintRentals()
    {
      Console.WriteLine("{0}, {1}", _LastName, _FirstName);
      for(int i = 0; i < total_rentals; i++) Console.WriteLine("\t{0}", _Rentals[i]);
      Console.WriteLine();
    }
  }
}
