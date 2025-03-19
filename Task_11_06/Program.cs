namespace Task_11_06
{
    internal class Program
    {
        /* Передача массива по значению: 
         * Напишите метод, который принимает массив целых чисел
         * и изменяет его элементы, увеличивая каждый на 1.
         * Проверьте, изменился ли оригинальный массив вне метода.
         */

        static void Main(string[] args)
        {
            // Создаем массив целых чисел
            int[] originalArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Оригинальный массив до изменения:");
            Console.WriteLine(string.Join(", ", originalArray));

            // Вызываем метод для изменения массива
            IncreaseArrayElements(originalArray);

            Console.WriteLine("Оригинальный массив после изменения:");
            Console.WriteLine(string.Join(", ", originalArray));
        }

        /// <summary>
        /// Увеличивает каждый элемент массива целых чисел на 1.
        /// </summary>
        /// <param name="numbers">Массив целых чисел.</param>
        
        static void IncreaseArrayElements(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += 1; // Увеличиваем каждый элемент на 1
            }
        }
    }
}
