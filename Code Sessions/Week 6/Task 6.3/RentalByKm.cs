namespace Task_6._3
{
    public class RentalByKm : Rental
    {
        public RentalByKm(Person renter, int kms) : base(renter)
        {
            _Kms = kms;
        }

        private string _Person;
        public string Person
        {
            get => _Person;
            set => _Person = value;
        }

        private int _Kms;
        public int Kms
        {
            get => _Kms;
            set => _Kms = value;
        }


        public override double GetPrice()
        {
            return 30 + 0.50 * _Kms;
        }

        public override string ToString() => $"Rental for {_Kms}km - {GetPrice()}";
    }
}