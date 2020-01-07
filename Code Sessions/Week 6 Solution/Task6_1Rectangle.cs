/*************************************************************
** File: Rectangle.cs
** Author/s: Justin Rough
** Description:
**     The class for representing a rectangle, which derives
** from the Shape base class.
*************************************************************/
using System;

namespace Shapes
{
  class Rectangle : Shape
  {
    private double _Height;
    private double _Length;

    public double Height
    {
      get { return _Height; }
      set { _Height = value; }
    }

    public double Length
    {
      get { return _Length; }
      set { _Length = value; }
    }

    public Rectangle(double length, double height)
    {
      _Length = length;
      _Height = height;
    }


    public override double GetArea()
    {
      return _Height * _Length;
    }

    public override double GetPerimeter()
    {
      return 2 * (_Height + _Length);
    }
  }
}
