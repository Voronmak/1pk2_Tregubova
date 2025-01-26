namespace Task_04_08
{
    internal class Program
    {
        /*Дан массив, содержащий последовательность 50 случайных чисел.
         * Найти количество пар элементов, 
         * значения которых равны.
         */ 
        static void Main(string[] args)
        {
            int[] numbers = new int[50];
            Random random = new Random();
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(0, 100);
            }
            Console.WriteLine("Массив:");
            Console.WriteLine(string.Join(", ", numbers));

            int pairCount = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1]) // Проверим, равны ли элементы
                {
                    pairCount++;
                }
            }


            Console.WriteLine($"Количество пар: {pairCount}");
        }
    }
}
