namespace Task_10_06
{
    internal class Program
    { 
        /* Создать Метод ArrayGeneration не возвращающий значения,
       принимает целое число n,
       выводит наконсольсгенерированный массив размерности n*n. */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ArrayGeneration(n);
        }

        /// <summary>
        /// Генерирует и выводит массив размерности n*n.
        /// </summary>
        /// <param name="n">Размерность массива.</param>
 
        static void ArrayGeneration(int n)
        {
            int[,] array = new int[n, n]; // Создаем двумерный массив размером n*n

            Random random = new Random(); // Заполняем массив случайными числами

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(1, 101); // Случайные числа от 1 до 100
                }
            }

            // Выводим массив в консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t"); // Выводим элемент массива с табуляцией
                }
                Console.WriteLine();
            }
        }
    }
}