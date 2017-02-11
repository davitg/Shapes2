using System;

namespace Shapes
{
    public class Square : IShape
    {
        private readonly double _length;

        public Square(double length)
        {
            _length = length;
        }

        public double Area
        {
            get
            {
                return Math.Pow(_length, 2);
            }
        }
    }
}
