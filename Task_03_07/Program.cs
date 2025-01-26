namespace Task_03_07
{
    internal class Program
    {
       /* Написать программу, 
       * которая выводит таблицу скорости (через каждые 0,5с)
       * свободно падающего тела v = g t ,
       * где 2 g = 9,8 м/с2 – ускорение свободного падения.
       */
        static void Main(string[] args)
        {
            const double g = 9.8; //Ускорение свободного падения в м/с²
            const double timeInterval = 0.5; //Интервал времени в секундах
            double time = 0; //Начальное время

            Console.WriteLine("Таблица скорости свободно падающего тела:");
            Console.WriteLine("Время (с) | Скорость (м/с)");

            for (int i = 0; i <= 10; i++) //Выводим до 5 секунд (10 раз по 0,5с)
            {
                double velocity = g * time; //Расчет скорости
                Console.WriteLine($"{time:F1}     | {velocity:F1}"); //Вывод времени и скорости
                time += timeInterval; //Увеличиваем время
                Thread.Sleep(500); //Пауза на 0,5 секунды
            }
        }
    }
}
