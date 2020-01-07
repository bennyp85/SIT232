using System;

namespace Task_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IShape[] someShapes = new IShape[3];

            someShapes[0] = new Circle(5.0);
            someShapes[1] = new Rectangle(5.0, 6.0);
            someShapes[2] = new Triangle(5.0, 5.0, 6.0);

            foreach (IShape s in someShapes)
                Console.WriteLine("{0,-16} area is {1:f3}", s, s.GetArea());
            
            foreach (IShape s in someShapes)
                Console.WriteLine("{0,-16} perimeter is {1:f3}", s, s.GetPerimeter());
        }
    }
}