using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class SumCalculatorOutputter
    {
        private readonly AreaCalculator _calculator;

        public SumCalculatorOutputter(AreaCalculator calculator)
        {
            calculator = _calculator;
        }

        public override string ToString()
        {
            return _calculator.Sum().ToString();
        }

        public string ToHTML()
        {
            return $"<h1>Sum of the areas of provided shapes: {_calculator.Sum()}</h1>";
        }

    }
}
