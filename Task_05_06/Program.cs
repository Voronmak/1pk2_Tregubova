namespace Task_05_06
{
    internal class Program
    { /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
• 1 столбец содержит нули
• 2 столбце содержит числа кратные 2
• 3 столбец содержит числа кратные 3
• 4 столбец содержит числа кратные 4
• 5 столбец содержит числа кратные 5
Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив 
        */
        static void Main(string[] args)
        {
            // Задаем размер массива
            int rows = 10;
            int columns = 5;

            int[,] matrix1 = new int[rows, columns];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        matrix1[i, j] = 0;
                    }
                    else
                    {
                        matrix1[i, j] = rnd.Next(1, 100) * (j + 1);
                    }
                }
            }

            
            Console.WriteLine("Первоначальный массив :"); // Выводим первоначальный массив
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] tmat = new int[columns, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tmat[j, i] = matrix1[i, j];
                }
            }

            Console.WriteLine("\nПеревернутый  массив:"); // Выводим перевернутый массив
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(tmat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
