using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_3
{
  class RentalByKm : Rental
  {
    private const decimal _DEFAULT_COST = 0.5m, _INITIAL_COST = 30, _PERCENT = 10;
    private int _KM;
    public int KM { get { return _KM; } }

    public RentalByKm(Person renter, int km) : base(renter)
    {
      _KM = km;
    }

    public override string ToString()
    {
      return string.Format("Rental for {0}km - {1:c}", _KM, CaculateCost());
    }

    public override decimal CaculateCost()
    { 
      return  (_INITIAL_COST + (_DEFAULT_COST * _KM)) * (1 + (_PERCENT /100)) ;
    }
  }
}
