namespace Task_14_03
{
    internal class MathOperations
    {
        /* Реализуйте статический метод Factorial, 
         * который принимает целое число и возвращает его факториал.
         * Сделайте так, чтобы метод работал только для неотрицательных чисел.
         */

        public static long Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Факториал не определен для отрицательных чисел.");
            }
            if (number == 0)
            {
                return 1; // Факториал 0 равен 1
            }

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите неотрицательное целое число: ");
                int input = Convert.ToInt32(Console.ReadLine());
                long factorialResult = Factorial(input);
                Console.WriteLine($"Факториал {input} равен {factorialResult}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Пожалуйста, введите корректное целое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введите меньшее число, так как оно слишком велико.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
