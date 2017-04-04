using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class AreaCalculator
    {
        private readonly List<IShape> _shapes;

        public AreaCalculator(List<IShape> shapes)
        {
            _shapes = shapes;
        }

        public virtual double Sum()
        {
            double sum = 0;

            foreach (var item in _shapes)
            {
                var shape = item as IShape;

                if (shape != null)
                    sum += shape.Area;
                else
                    throw new Exception("Invalid Shape Exception");

            }

            return sum;
        }

    }
}
