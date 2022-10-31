using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    internal class SquareCircle:ICalculationArea
    {
        public double Calculation(List<double> param)
        {
            var r = param[0];
            var result = Math.PI*Math.Pow(r, 2);
            return result;
        }
    }
}
