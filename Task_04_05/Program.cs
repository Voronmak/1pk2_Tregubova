namespace Task_04_05
{
    internal class Program
    {
        /*В массиве хранятся сведения о количестве осадков за месяц(30 дней). 
         * Необходимо определить общее количество осадков,
         * выпавших за каждую декаду месяца,
         * вывести день с самыми сильными осадками
         * за месяц и отдельно вывести дни без осадков.
         * Массив с осадками заполнятся с помощью рандома в диапазоне
         * от 0 – нет осадков, до 300 мм выпавших осадков.
         */

        static void Main(string[] args) 
        {
            int[] precipitation = new int[30];
            Random random = new Random();


            for (int i = 0; i < precipitation.Length; i++)
            {
                precipitation[i] = random.Next(0, 301);
            }


            Console.WriteLine("Осадки за месяц:");
            for (int i = 0; i < precipitation.Length; i++)
            {
                Console.WriteLine($"День {i + 1}: {precipitation[i]} мм");
            }


            int[] decadeSums = new int[3];
            for (int i = 0; i < precipitation.Length; i++)
            {
                if (i < 10)
                    decadeSums[0] += precipitation[i];
                else if (i < 20)
                    decadeSums[1] += precipitation[i];
                else
                    decadeSums[2] += precipitation[i];
            }


            Console.WriteLine("\nСумма осадков за декады месяца:");
            Console.WriteLine($"1-10 дни: {decadeSums[0]} мм");
            Console.WriteLine($"11-20 дни: {decadeSums[1]} мм");
            Console.WriteLine($"21-30 дни: {decadeSums[2]} мм");


            int maxPrecipitation = precipitation[0];
            int maxDay = 1;
            for (int i = 1; i < precipitation.Length; i++)
            {
                if (precipitation[i] > maxPrecipitation)
                {
                    maxPrecipitation = precipitation[i];
                    maxDay = i + 1;
                }
            }
        }
    }
}
