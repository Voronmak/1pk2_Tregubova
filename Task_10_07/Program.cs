namespace Task_10_07
{
    internal class Program
    {
        /* Создайте метод с помощью которого можно сгенерировать
         * и вернуть символьный двумерный массив
         * (состоящий из символов русского алфавита) и выведите на
         * консоль данный массив с помощью другого метода
         * (который принимает данный массив в качестве параметра)
         */

        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            char[,] charArray = GenerateCharArray(n);

            PrintCharArray(charArray);
        }

        /// <summary>
        /// Генерирует символьный двумерный массив размерности n*n
        /// с случайными символами русского алфавита.
        /// </summary>
        /// <param name="n">Размерность массива.</param>
        /// <returns>Двумерный массив символов размерности n*n.</returns>

        static char[,] GenerateCharArray(int n)
        {
            char[,] array = new char[n, n];
            Random random = new Random();

            char[] russianAlphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя".ToCharArray(); // Массив символов русского алфавита

            // Заполняем массив случайными символами русского алфавита
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = russianAlphabet[random.Next(russianAlphabet.Length)];
                }
            }

            return array;
        }

        /// <summary>
        /// Выводит символьный двумерный массив на консоль.
        /// </summary>
        /// <param name="array">Двумерный массив символов для вывода.</param>

        static void PrintCharArray(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
