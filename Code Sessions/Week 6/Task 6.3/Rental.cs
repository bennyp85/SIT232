namespace Task_6._3
{
    public abstract class Rental
    {
        private Person _Renter;
        public Person Renter { get; }

        public Rental(Person person)
        {
            if (person != null)
            {
                _Renter = person;
                _Renter.RentCar(this);
            }
        }
        
        public abstract double GetPrice();
    }
}