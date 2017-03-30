using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();

            arrayList.Add(new Circle(2));
            arrayList.Add(new Circle(5));
            arrayList.Add(new Circle(6));

            AreaCalculator areaCalc = new AreaCalculator(arrayList);


            Console.WriteLine("Sum = " + areaCalc.Sum().ToString());
            Console.ReadLine();
        }
    }
}
