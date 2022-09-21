using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    /*
    * Среднее арифметическое двух чисел
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            Console.WriteLine("Введите первое число: ");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            secondValue = double.Parse(Console.ReadLine());
            double result = (firstValue + secondValue) / 2;
            Console.WriteLine("Среднее арифметическое двух чисел = " + result);
        }
    }
}
