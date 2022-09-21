using System;

namespace HomeWork2
{
    /*
     * Введите три числа и выведите на экран значения суммы и произведения этих чисел
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;
            Console.WriteLine("Введите первое число: ");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            secondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            thirdValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdValue;

            double multResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("Сумма трёх чисел = " + sumResult);
            Console.WriteLine("Произведение трёх чисел = " + multResult);
        }
    }
}
