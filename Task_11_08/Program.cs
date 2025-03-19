namespace Task_11_08
{
    internal class Program
    {
        /* Использование params и out:
         * Напишите метод, который принимает переменное количество
         * чисел и возвращает их сумму и максимальное значение
         * через выходные параметры (out).
         */

        static void Main(string[] args)
        {
            int sum;
            int max;

            CalculateSumAndMax(out sum, out max, 5, 2, 1, 4, 6);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Максимальное значение: {max}");
        }

        static void CalculateSumAndMax(out int sum, out int max, params int[] numbers)
        {
            sum = 0;
            max = int.MinValue;

            foreach (int number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }
        }
    }
}
