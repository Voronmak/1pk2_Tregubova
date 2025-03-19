namespace Task_11_05
{
    internal class Program
    {
        /* Комбинирование ref и out: Напишите метод,
         * который принимает два числа по ссылке (ref)
         * и возвращает их сумму и произведение
         * через выходные параметры (out).
         */

        static void Main(string[] args)
        {
            int number1 = 2;
            int number2 = 4;

            // Вызов метода с использованием ref и out
            int sum;
            int product;
            CalculateSumAndProduct(ref number1, ref number2, out sum, out product);

            // Вывод результатов
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
        }

        /// <summary>
        /// Вычисляет сумму и произведение двух чисел.
        /// </summary>
        /// <param name="num1">Первое число, передается по ссылке.</param>
        /// <param name="num2">Второе число, передается по ссылке.</param>
        /// <param name="sum">Выходной параметр для суммы.</param>
        /// <param name="product">Выходной параметр для произведения.</param>
        
        static void CalculateSumAndProduct(ref int num1, ref int num2, out int sum, out int product)
        {
            sum = num1 + num2;        // Рассчитываем сумму
            product = num1 * num2;    // Рассчитываем произведение
        }
    }
}
