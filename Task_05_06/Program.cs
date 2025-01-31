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

            // Создаем массив
            int[,] array = new int[rows, columns];

            // Заполняем массив по 5 правилам
            for (int i = 0; i < rows; i++)
            {
                array[i, 0] = 0;             // 1 столбец содержит нули
                array[i, 1] = (i + 1) * 2;  // 2 столбец содержит числа кратные 2
                array[i, 2] = (i + 1) * 3;  // 3 столбец содержит числа кратные 3
                array[i, 3] = (i + 1) * 4;  // 4 столбец содержит числа кратные 4
                array[i, 4] = (i + 1) * 5;  // 5 столбец содержит числа кратные 5
            }
            // Транспонирование массива
            int[,] transposedArray = TransposeArray(array);

            // Выводим обновленный массив
            Console.WriteLine("Обновленный массив:");
            PrintArray(transposedArray);
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] TransposeArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int[,] transposed = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transposed[j, i] = array[i, j];
                }
            }

            return transposed;
        }
    }
}
