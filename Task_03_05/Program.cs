namespace Task_03_05
{
    internal class Program
    {
        /* Написать программу, 
         * которая выводит на экран таблицу соответствия температуры
         * в градусах Цельсия и Фаренгейта(F = C * 1,8 + 32). 
         * Диапазон изменения температуры в градусах Цельсия
         * и шаг должны вводиться во время работы программы  
        */
        static void Main(string[] args)
        {
            //Ввод диапазона и шага
            Console.Write("Введите начальную температуру (°C): ");
            double startC = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечную температуру (°C): ");
            double endC = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите шаг (°C): ");
            double step = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nТаблица соответствия температуры:");
            Console.WriteLine("Цельсий (°C) | Фаренгейт (°F)");
            Console.WriteLine("-----------------------------");

            //Вывод таблицы
            for (double c = startC; c <= endC; c += step)
            {
                double f = c * 1.8 + 32; //Преобразование в Фаренгейт
                Console.WriteLine($"{c,12:F1} | {f,14:F1}");
            }
        }
    }
}
    
