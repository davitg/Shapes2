using System;

namespace Shapes
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(_radius, 2);
            }
        }
    }
}
