

namespace Task6_3
{
  abstract class Rental
  {
    private Person _Renter;
    public Person Renter {  get { return _Renter; } }

    public Rental(Person renter)
    {
      if (renter != null)
      {
        _Renter = renter;
        _Renter.AddRental(this);
      }
    }

    public abstract decimal CaculateCost();
  }
}
