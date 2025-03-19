namespace Task_11_02
{
    internal class Program
    {
        /* Передача по ссылке (ref): Напишите метод,
         * который принимает два целых числа по ссылке 
         * и меняет их местами. 
         * Проверьте, изменились ли значения переменных вне метода 
         */

        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"До вызова метода: a = {a}, b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"После вызова метода: a = {a}, b = {b}");
        }

        /// <summary>
        /// Меняет местами два целых числа, переданных по ссылке.
        /// </summary>
        /// <param name="x">Первое целое число.</param>
        /// <param name="y">Второе целое число.</param>
        
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"Внутри метода: x = {x}, y = {y}");
        }
    }
}