namespace Task_04_07
{
    internal class Program
    {
        /*В массиве на 30 элементов содержатся данные по росту учеников в классе.
         * Рост мальчиков условно задан отрицательными значениями.
         * Вычислить и вывести количество мальчиков и девочек в классе
         * и средний рост для мальчиков и девочек. 
         * При выводе избавиться от отрицательных значений.
         */ 
        static void Main(string[] args)
        {
            int[] heights = { 157, -172, 155, -180, 165, -175, 167, -169, 170, -160,
                          152, -178, 163, -163, 151, -170, 160, -162, 168, -172,
                          162, -165, 164, -168, 154, -173, 156, -177, 159, -178 };

            int boysCount = 0, girlsCount = 0;
            double boysHeight = 0, girlsHeight = 0;


            foreach (int height in heights)
            {
                if (height < 0) //Мальчики
                {
                    boysCount++;
                    boysHeight += Math.Abs(height);
                }
                else //Девочки
                {
                    girlsCount++;
                    girlsHeight += height;
                }
            }


            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine($"Средний рост мальчиков: {(boysCount > 0 ? boysHeight / boysCount : 0):F2} см");
            Console.WriteLine($"Средний рост девочек: {(girlsCount > 0 ? girlsHeight / girlsCount : 0):F2} см");
        }
    }
}
