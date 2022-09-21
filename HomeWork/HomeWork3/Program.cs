using System;

namespace HomeWork3
{
    /*
     * Напишите простой конвертер валют
     * (без возможности динамического выбора валюты пользователем)
     * Валюты задана хардкодом и не изменяются. Тип валют на выбор программиста
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal RubToUsd = 0.016662m;
            decimal RubToEur = 0.016653m;
            decimal RUB;
            Console.WriteLine("Введите сумму в рублях: ");

            RUB = decimal.Parse(Console.ReadLine());

            Console.WriteLine(RUB + " RUB в USD = " + Math.Round(RUB * RubToUsd, 2));
            Console.WriteLine(RUB + " RUB в EUR = " + Math.Round(RUB * RubToEur, 2));
        }
    }
}
