using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_3
{
  class RentalByDay : Rental
  {
    private const decimal _DEFAULT_COST = 100m;
    private int _Days;
    public int Days { get { return _Days; } }

    public RentalByDay(Person renter, int days): base(renter)
    {
      _Days = days;
    }

    public override decimal CaculateCost()
    {
      return _Days * _DEFAULT_COST;
    }

    public override string ToString()
    {
      return string.Format("Rental for {0} days - {1:c}", _Days, CaculateCost());
    }
  }
}
