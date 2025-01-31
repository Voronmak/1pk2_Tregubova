namespace Task_05_04
{
    internal class Program
    { /* Дан квадратный массив размерность n*n.
       * Произведите анализ данной матрицы
       * и выясните является ли данная матрица диагональной
       * (все элементы вне главной диагонали равны нулю)
       * Если матрица является диагональной, то вывести ее повторно
       * с цветовым выделением главной диагонали.
       * Если нет, то вывеси сообщение
       * что матрица не является диагональной. 
       */
        static void Main(string[] args)
        {
            // Задаем размер массива
            Console.Write("Введите размерность матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            // Создаем и заполняем матрицу
            int[,] matrix = new int[n, n];
            Console.WriteLine("Введите элементы матрицы:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Проверяем, будет ли матрица диагональной
            bool isDiagonal = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] != 0)
                    {
                        isDiagonal = false;
                        break;
                    }
                }
                if (!isDiagonal) break;
            }

            // Выводим результат
            if (isDiagonal)
            {
                Console.WriteLine("Матрица является диагональной:");
                PrintMatrixWithHighlight(matrix);
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной.");
            }
        }

        static void PrintMatrixWithHighlight(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        // Выделяем цветом
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(matrix[i, j] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
