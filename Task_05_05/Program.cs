namespace Task_05_05
{
    internal class Program
    { /* У пользователя в консоли запрашивается числа n и m,
       * генерируется прямоугольный массив целых числе [n*m].
       * Заполнение случайными числами в диапазоне от -99 до 99 включительно.
       * Осуществите без создания нового массива
       * преобразование текущего по следующему правилу: 
       * • Если элемент меньше нуля, то отбрасываем знак
       * и выделяем при выводе зеленым цветом 
       * • Если элемент равен нулю, 
       * то перезаписываем единицу и выделяем при выводе красным цветом
       */

        static void Main(string[] args)
        {
            Console.Write("Введите количество строк (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Создаем двумерный массив
            int[,] array = new int[m, n];
            Random random = new Random();

            // Заполняем массив случайными числами от -99 до 99
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(-99, 100); // 100 не включительно
                }
            }

            // Преобразуем массив согласно двум правилам
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] < 0)
                    {
                        array[i, j] = -array[i, j];
                        Console.ForegroundColor = ConsoleColor.Green; // Задаем зеленый цвет
                    }
                    else if (array[i, j] == 0)
                    {
                        array[i, j] = 1;
                        Console.ForegroundColor = ConsoleColor.Red; // Задаем красный цвет
                    }
                    Console.Write(array[i, j] + " ");
                    Console.ResetColor(); // Сбрасываем цвет
                }
                Console.WriteLine();
            }
        }
    }
}
