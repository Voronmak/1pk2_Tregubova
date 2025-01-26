using System;

namespace Task_03_09
{
    internal class Program
    { 
       /* Вклад в банке составляет x рублей.
       * Ежегодно он увеличивается на p процентов, 
       * после чего дробная часть копеек отбрасывается.
       * Каждый год сумма вклада становится больше.
       * Определите, через сколько лет вклад составит
       * не менее y рублей.
       */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада (x):");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите процент (p):");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите целевую сумму (y):");
            double y = Convert.ToDouble(Console.ReadLine());

            int years = 0;

            while (x < y)
            {
                x = Math.Floor(x * (1 + p / 100));
                years++;
            }

            Console.WriteLine($"Вклад достигнет суммы не менее {y} рублей через {years} лет.");
        }
    }
}
