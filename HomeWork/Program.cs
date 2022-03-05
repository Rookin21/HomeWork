using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");

            float minTemp = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру за сутки");

            float maxTemp = Convert.ToInt64(Console.ReadLine());

            float averageTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine($"Среднесуточная температура за сутки равна: {averageTemp}");

            Console.Read();
        }
    }
}
