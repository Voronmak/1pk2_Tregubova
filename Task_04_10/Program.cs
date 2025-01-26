namespace Task_04_10
{
    internal class Program
    { 
       /* Заполнить массив из 10 элементов случайными числами в интервале [-10..10]
       * и сделать реверс элементов отдельно для 1-ой и 2-ой половин массива.
       * Реверс реализовать через цикл. 
       * Стандартные методы класса Array использовать нельзя.
       * Например, исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]
       * Результат: [4,0,-10,2,5,-7,9,2,7,-6]
       */
        static void Main(string[] args)
        {
            int[] number = new int[10];
            Random random = new Random();

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(-10, 11);
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]);
                if (i < number.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            int half = number.Length / 2;

            //Реверс первой половины
            for (int i = 0; i < half / 2; i++)
            {
                int temp = number[i];
                number[i] = number[half - 1 - i];
                number[half - 1 - i] = temp;
            }

            //Реверс второй половины
            for (int i = half; i < half + (number.Length - half) / 2; i++)
            {
                int temp = number[i];
                number[i] = number[number.Length - 1 - (i - half)];
                number[number.Length - 1 - (i - half)] = temp;
            }

            Console.WriteLine("Результат:");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]);
                if (i < number.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
