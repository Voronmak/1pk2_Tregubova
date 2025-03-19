namespace Task_11_04
{
    internal class Program
    {
        /* Массив параметров (params): 
         * Напишите метод, который принимает массив чисел
         * и возвращает их среднее значение. 
         * Используйте ключевое слово params 
         */

        static void Main(string[] args)
        {

            double average = CalculateAverage(1, 2, 3, 4, 5);
            Console.WriteLine($"Среднее значение: {average}");

            double[] numbers = { 10, 20, 30, 40, 50 };
            average = CalculateAverage(numbers);
            Console.WriteLine($"Среднее значение с массива: {average}");
        }

        /// <summary>
        /// Вычисляет среднее значение переданных чисел.
        /// </summary>
        /// <param name="numbers">Массив чисел, для которых будет рассчитано среднее значение.</param>
        /// <returns>Среднее значение чисел.</returns>
        
        static double CalculateAverage(params double[] numbers)
        {
            if (numbers.Length == 0)
                return 0; 

            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number; // Суммируем все числа
            }

            return sum / numbers.Length; // Возвращаем среднее значение
        }
    }
}
