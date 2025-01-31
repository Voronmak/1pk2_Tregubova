namespace Task_05_07
{
    internal class Program
    { /* У пользователя в консоли запрашивается число n,
       * генерируется квадратный массив целых числе [n*n]. 
       * Заполнение случайными числами в диапазоне 10 до 99 включительно.
       * Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом)
       * Осуществить умножение матрицы на ее минимальный элемент,
       * при выводе цветом выделить пять максимальных значений в массиве
       */
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя число n
            Console.Write("Введите размерность n для квадратного массива (n*n): ");
            int n;

            // Проверяем корректность ввода
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Пожалуйста, введите положительное целое число.");
            }

            // Создаем и заполняем массив случайными числами
            int[,] matrix = new int[n, n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(10, 100); // Генерация случайных чисел от 10 до 99
                }
            }

            // Находим минимальный элемент
            int minElement = FindMinElement(matrix);
            Console.WriteLine($"Минимальный элемент в матрице: {minElement}");

            // Умножаем массив на минимальный элемент
            int[,] multipliedMatrix = MultiplyByMinElement(matrix, minElement);

            // Выводим результирующий массив и выделяем пять максимальных значений
            PrintMatrixWithHighlights(multipliedMatrix);
        }

        static int FindMinElement(int[,] matrix)
        {
            int min = matrix[0, 0];
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }

            return min;
        }

        static int[,] MultiplyByMinElement(int[,] matrix, int minElement)
        {
            int size = matrix.GetLength(0);
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = matrix[i, j] * minElement;
                }
            }

            return result;
        }

        static void PrintMatrixWithHighlights(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            int maxCount = 5; // Количество максимальных значений
            int[] maxElements = new int[maxCount];

            // Поиск пяти максимальных значений
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < maxCount; k++)
                    {
                        if (matrix[i, j] > maxElements[k])
                        {
                            // Сдвигаем элементы вправо
                            for (int l = maxCount - 1; l > k; l--)
                            {
                                maxElements[l] = maxElements[l - 1];
                            }
                            maxElements[k] = matrix[i, j];
                            break;
                        }
                    }
                }
            }

            // Вывод матрицы с выделением
            Console.WriteLine("Результирующая матрица (максимальные значения выделены):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    bool isMax = false;
                    for (int k = 0; k < maxCount; k++)
                    {
                        if (matrix[i, j] == maxElements[k])
                        {
                            isMax = true;
                            break;
                        }
                    }

                    // Выделяем максимальные значения цветом 
                    if (isMax)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed; // Меняем цвет на темно-красный
                    }

                    Console.Write(matrix[i, j] + "\t"); // Печатаем элемент матрицы
                    Console.ResetColor(); // Сбрасываем цвет
                }
                Console.WriteLine();
            }
        }
    }
}
