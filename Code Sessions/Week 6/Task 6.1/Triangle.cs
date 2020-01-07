﻿/*************************************************************
** File: Triangle.cs
** Author/s: Justin Rough
** Description:
**     The class for representing a triangle, which derives
** from the Shape base class.
*************************************************************/

using System;

namespace Task_6._1
{
    class Triangle : IShape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            _SideA = sideA;
            _SideB = sideB;
            _SideC = sideC;
        }

        private double _SideA;
        public double SideA
        {
            get { return _SideA; }
            set { _SideA = value; }
        }

        private double _SideB;
        public double SideB
        {
            get { return _SideB; }
            set { _SideB = value; }
        }

        private double _SideC;
        public double SideC
        {
            get { return _SideC; }
            set { _SideC = value; }
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
