namespace Task_04_09
{
    internal class Program
    {
       /* В массиве найти элементы,
        * которые в нем встречаются только один раз, 
        * и вывести их на экран.
        * То есть найти и вывести уникальные элементы массива.
        * (LINQ использовать нельзя)
        */
       
        static void Main(string[] args) 
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(0, 10);
            }

            Console.WriteLine("Уникальные элементы:");

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
