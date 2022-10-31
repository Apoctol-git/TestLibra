using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    internal class SquareTriangle:ICalculationArea
    {
        public double Calculation(List<double> param)
        {
            var a = param[0];
            var b = param[1];
            var c = param[2];
            var p = (a + b + c) / 2;
            var s = p*(p - a) * (p - b) * (p - c);
            var res = Math.Sqrt(s);
            return res;
        }
        /// <summary>
        /// Метод проверки на прямоугольность треугольника по теореме пифагора. Нигде не используется. Просто есть.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public bool IsRightAngle(List<double> param)
        {
            var max = param.Max();
            double powKat = 0;
            foreach (var i in param)
            {
                if (i!=max)
                {
                    powKat += Math.Pow(i, 2);
                }
            }
            return Math.Pow(max, 2) == powKat; 
        }
    }
}
