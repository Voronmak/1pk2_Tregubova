namespace Task_10_08
{
    internal class Program
    { /* Создайте метод, 
       * который на вход принимает одномерный массив
       * и число для поиска, 
       * верните индекс искомого элемента в массиве.
       * Если элемента нет – верните индекс = -1 
       */
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.Write("Введите число для поиска: ");
            int numberToFind = Convert.ToInt32(Console.ReadLine());

            int index = FindIndex(array, numberToFind);

            if (index != -1)
            {
                Console.WriteLine($"Элемент {numberToFind} найден на индексе: {index}");
            }
            else
            {
                Console.WriteLine($"Элемент {numberToFind} не найден в массиве.");
            }
        }

        /// <summary>
        /// Находит индекс указанного элемента в одномерном массиве.
        /// Если элемент не найден, возвращает -1.
        /// </summary>
        /// <param name="array">Одномерный массив для поиска элемента.</param>
        /// <param name="value">Значение для поиска в массиве.</param>
        /// <returns>Индекс найденного элемента или -1, если элемент не найден.</returns>
 
        static int FindIndex(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i; // элемент найден
                }
            }
            return -1; // элемент не найден
        }
    }
}
