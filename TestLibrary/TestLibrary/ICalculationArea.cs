using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    /// <summary>
    /// Интерфейс для создания кастомного метода расчёта для кастомной фигуры
    /// </summary>
    public interface ICalculationArea
    {
        /// <summary>
        /// Основной метод расчёта. 
        /// </summary>
        /// <param name="param">Массив известных параметров</param>
        /// <returns>Возвращает площадь типом double</returns>
        public double Calculation(List<double> param);
    }
}
