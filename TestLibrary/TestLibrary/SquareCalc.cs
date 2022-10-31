using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    // По поводу вычисления площади фигуры без знания её структуры - не нашёл материалов совсем. Да и из курса математики не помню такого способа. 
    public class SquareCalc
    {
        private Dictionary<string,ICalculationArea> _totalCalc; // свойство для хранения операций над фигурами

        public SquareCalc()
        {
            _totalCalc = new Dictionary<string,ICalculationArea>();
            AddNewCalculation("Circle", new SquareCircle());
            AddNewCalculation("Triangle", new SquareTriangle());
        }
        /// <summary>
        /// Метод для добавления кастомного метода расчёта. 
        /// </summary>
        /// <param name="name">Имя фигуры расчёта. Ключ для дальнейшего выбора расчёта</param>
        /// <param name="calculation">Класс реализующий логику расчёта</param>
        /// <returns>Возвращает строку со статусом добавления.</returns> 
        public string AddNewCalculation(string name, ICalculationArea calculation)
        {
            if (!_totalCalc.ContainsKey(name))
            {
                if (calculation!=null)
                {
                    _totalCalc.Add(name, calculation);
                    return "Adding success";
                }
                else
                {
                    return "Class is empty";
                }
               
            }
            else
            {
                return "Key already exist";
            }
            
        }
        /// <summary>
        /// Базовый метод совершения расчётов. Расчёт для нужной фигуры вызывается черз String, для большей гибкости добавления. 
        /// Базово существует два класса Circle и Triangle. Так же существует интерфейс для добавления новых рассчётных классов.
        /// </summary>
        /// <param name="name">Название класса калькуляции</param>
        /// <param name="param">Набор существующих данных. Реализован в виде массива для обобщения</param>
        /// <returns>Возвращает площадь фигуры числом double. В случае если метода расчёта нет - возвраащает "-1"</returns>
        public double Calculate(string name, List<double> param)
        {
            var tryget = _totalCalc.TryGetValue(name, out var calc);
            if (tryget)
            {
                var result = calc.Calculation(param);
                return result;
            }
            else
            {
                return -1;
            }

        }
    }
}
