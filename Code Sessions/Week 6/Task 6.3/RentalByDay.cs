namespace Task_6._3
{
    public class RentalByDay : Rental
    {
        public RentalByDay(Person renter, int days) : base(renter)
        {
            _Days = days;
        }

        private int _Days;

        public int Days
        {
            get => _Days;
            set => _Days = value;
        }

        public override double GetPrice()
        {
            return 100 * _Days;
        }

        public override string ToString() => $"Rental for {_Days} days - {GetPrice()}";
    }
}