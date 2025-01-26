namespace Task_03_06
{
    internal class Program
    {  
       /* Написать программу, 
       * которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4,
       * с шагом h = 0,5. 
       */
        static void Main(string[] args) 
        {
            
                double xStart = -4; //Начальное значение x
                double xEnd = 4;    //Конечное значение x
                double h = 0.5;     //Шаг

                Console.WriteLine("Таблица значений функции y = |x|:");
                Console.WriteLine("   x   |    y   ");
                Console.WriteLine("-------------------");

                for (double x = xStart; x <= xEnd; x += h)
                {
                    double y = Math.Abs(x); //Вычисление значения функции
                    Console.WriteLine($"{x,6:F1} | {y,6:F1}");
                }
           
        }
    }
}