namespace Task_11_07
{
    internal class Program
    {
        /* Передача массива по ссылке(ref): 
         * Напишите метод, который принимает массив целых чисел 
         * по ссылке и изменяет его элементы,
         * увеличивая каждый на 1. 
         * Проверьте, изменился ли оригинальный массив вне метода.
         */

        static void Main(string[] args)
        {
            // Создаем массив целых чисел
            int[] originalArray = { 5, 8, 3, 4, 2 };

            Console.WriteLine("Оригинальный массив до изменения:");
            Console.WriteLine(string.Join(", ", originalArray));

            // Вызываем метод для изменения массива
            IncreaseArrayElements(ref originalArray);

            Console.WriteLine("Оригинальный массив после изменения:");
            Console.WriteLine(string.Join(", ", originalArray));
        }

        /// <summary>
        /// Увеличивает каждый элемент массива целых чисел на 1.
        /// </summary>
        /// <param name="numbers">Массив целых чисел, переданный по ссылке.</param>
        
        static void IncreaseArrayElements(ref int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += 1; // Увеличиваем каждый элемент на 1
            }
        }
    }
}
