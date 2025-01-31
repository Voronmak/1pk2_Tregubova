namespace Task_05_09
{
    internal class Program
    { /* Дан квадратный массив размерность n*n. 
       * Произведите анализ данной матрицы
       * и выясните является ли данная матрица Z-матрицей 
       * (это матрица, где все недиагональные элементы меньше нуля) 
       * Если данное условие выполняется то вывести данную матрицу
       * с цветовой индикацией главной диагонали. 
       * Если не выполняется, то вывести сообщение 
       * что данная матрица не является Z-матрицей
       */

        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random rand = new Random();

            // Заполняем матрицу случайными числами от -10 до 10
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(-10, 11);
                }
            }

            // Проверяем на Z-матрицу
            bool isZMatrix = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] >= 0)
                    {
                        isZMatrix = false;
                        break;
                    }
                }
                if (!isZMatrix)
                    break;
            }

            // Выводим результаты
            if (isZMatrix)
            {
                Console.WriteLine("Данная матрица является Z-матрицей:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        // Создаем цветовую индикацию диагонали
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // Главная диагональ
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White; // Остальные элементы
                        }
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Данная матрица не является Z-матрицей.");
            }
        }
    }
}
