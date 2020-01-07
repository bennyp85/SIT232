using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        private double _Radius;

        public double Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }

        public Circle(double radius)
        {
            _Radius = radius;
        }


        public override double GetArea()
        {
            return Math.PI * _Radius * _Radius;
        }

        public override double GetPerimeter()
        {
            return 2.0 * Math.PI * _Radius;
        }
    }
}
