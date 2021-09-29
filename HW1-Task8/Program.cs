using System;
using System.Collections.Generic;

namespace HW1_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new double[] { 2, -4.5, 222, 656.9, -888.9, 0, 54.6, 34.2, 7777, 90.9, -0.8 };
            (double max, double min, double average, double mediane) tupple = Method(array);
            Console.WriteLine($"Максимальный положительный элемент {tupple.max}");
            Console.WriteLine($"Минимальный положительный элемент {tupple.min}");
            Console.WriteLine($"Среднее арифметическое положительных элементов {tupple.average}");
            Console.WriteLine($"Средний положительный элемент {tupple.mediane}");
        }

        public static (double, double, double, double) Method(double[] array)
        {
            var numberList = new List<double>();
            foreach(var number in array)
            {
                if(number > 0)
                {
                    numberList.Add(number);
                }
            }
            numberList.Sort();
            var max = numberList[numberList.Count - 1];
            var min = numberList[1];
            double sum = 0;
            foreach(var number in numberList)
            {
                sum += number;
            }
            var average = Math.Round(sum / numberList.Count, 3);
            var mediane = numberList[numberList.Count / 2];
            return (max, min, average, mediane);
        }
    }
}
