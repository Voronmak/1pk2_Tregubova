using System.Drawing;

namespace Task_20_06
{
    internal class Program
    {
        /* Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
         * • Red
         * • Yellow
         * • Green
         * Реализуйте автоматическое переключение цветов (каждые 3 секунды). 
         * При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep). 
         * Добавьте возможность ручного переключения (например, по нажатию клавиши).
        */
        static void Main(string[] args)
        {
            Color currentLight = Color.Red;

            while (true)
            {
                Console.Clear();
                SetConsoleColor(currentLight);
                Console.WriteLine($"Светофор: {currentLight}");
                Console.ResetColor();


                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                else
                {
                    Thread.Sleep(3000);
                }


                currentLight = GetNextColor(currentLight);
            }
        }

        static void SetConsoleColor(Color light)
        {
            Console.ForegroundColor = light switch
            {
                Color.Red => ConsoleColor.Red,
                Color.Yellow => ConsoleColor.Yellow,
                _ => ConsoleColor.Green
            };
        }

        static Color GetNextColor(Color current)
        {
            return current switch
            {
                Color.Red => Color.Yellow,
                Color.Yellow => Color.Green,
                _ => Color.Red
            };
        }
    }
}
