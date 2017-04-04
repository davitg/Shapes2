using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class VolumeCalculator : AreaCalculator
    {
        public VolumeCalculator(List<IShape> shapes) : base(shapes)
        {
        }

        public override double Sum()
        {
            throw new NotImplementedException();
        }
    }
}
