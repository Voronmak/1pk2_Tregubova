namespace Task_11_01
{
    internal class Program
    {
        /* Передача по значению: Напишите метод,
         * который принимает два целых числа
         * и меняет их местами.
         * Проверьте, изменились ли значения переменных вне метода
         */

        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"До вызова метода: a = {a}, b = {b}");

            Swap(a, b);

            Console.WriteLine($"После вызова метода: a = {a}, b = {b}");
        }

        /// <summary>
        /// Меняет местами два целых числа.
        /// </summary>
        /// <param name="x">Первое целое число.</param>
        /// <param name="y">Второе целое число.</param>
        
        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"Внутри метода: x = {x}, y = {y}");
        }
    }
}
