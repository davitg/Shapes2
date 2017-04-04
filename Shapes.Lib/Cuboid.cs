using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cuboid : IShape, ISolidShape, IManageShape
    {
        private double _a;
        private double _b;
        private double _c;

        public Cuboid(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public double Area
        {
            get
            {
                return 2 * (_a * _b + _a * _c + _b * _c);
            }
        }

        public double Volume
        {
            get
            {
                return _a * _b * _c;
            }
        }

        public double Calculate()
        {
            //??
            return Area + Volume;
        }
    }
}
