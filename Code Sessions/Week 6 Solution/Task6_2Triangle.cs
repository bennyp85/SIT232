﻿/*************************************************************
** File: Triangle.cs
** Author/s: Justin Rough
** Description:
**     The class for representing a triangle, which derives
** from the Shape base class.
*************************************************************/
using System;

namespace Shapes
{
  class Triangle : IShape
  {
    private double _SideA;
    private double _SideB;
    private double _SideC;

    public double SideA
    {
      get { return _SideA; }
      set { _SideA = value; }
    }

    public double SideB
    {
      get { return _SideB; }
      set { _SideB = value; }
    }

    public double SideC
    {
      get { return _SideC; }
      set { _SideC = value; }
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
      _SideA = sideA;
      _SideB = sideB;
      _SideC = sideC;
    }

    public double GetArea()
    {
      // Calculated according to Heron's formula (http://en.wikipedia.org/wiki/Triangle)
      double s = 0.5 * (_SideA + _SideB + _SideC);
      return Math.Sqrt(s * (s - _SideA) * (s - _SideB) * (s - _SideC));
    }

    public double GetPerimeter()
    {
      return _SideA + _SideB + _SideC;
    }
  }
}
