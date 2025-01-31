namespace Task_05_03
{
    internal class Program
    { /* Даны два массива, заполненные символами английского алфавита размером 3*3.
       * Проверить, являются ли матрицы равными,
       * если да, то вывести сообщение о том, что они равны,
       * если нет, то вывести повторно матрицы с цветовой индикацией
       * только тех элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.
       * Пример:
f h h f c h
w g k m g z
a f j a o d
=>
f h h f c h
w g k m g z
a f j a o d 
       */
        static void Main(string[] args)
        {
            char[,] matrix1 = {
            { 'c', 'k', 'l' },
            { 'v', 'o', 'k' },
            { 'a', 'r', 'h' }
         };

            char[,] matrix2 = {
            { 'c', 'k', 'p' },
            { 't', 'o', 'e' },
            { 'a', 'q', 'd' }
        };

            // Проверяем матрицы на равенство
            bool Equal = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] == matrix2[i, j])
                    {
                        Equal = false;
                        break;
                    }
                }
                if (!Equal) break;
            }

            if (Equal)
            {
                Console.WriteLine("Матрицы равны.");
            }
            else
            {
                Console.WriteLine("Матрицы не равны.");


                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix1[i, j] == matrix2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ResetColor(); // Сбрасываем цвет
                        }
                        Console.Write(matrix1[i, j] + " ");
                    }
                    Console.Write("    ");
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix1[i, j] == matrix2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ResetColor();
                        }
                        Console.Write(matrix2[i, j] + " ");
                    }
                    Console.ResetColor();
                    Console.WriteLine();

                }
            }
        }
    }
}
