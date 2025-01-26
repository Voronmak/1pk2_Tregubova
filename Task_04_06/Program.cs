namespace Task_04_06
{
    internal class Program
    {
        /* Заполнить массив случайными положительными и отрицательными числами
         * таким образом, чтобы все числа по модулю были разными.
         * Это значит, что в массиве не может быть ни только двух равных чисел,
         * но не может быть двух равных по модулю.
         * В полученном массиве найти наибольшее по модулю число.
         */
        static void Main(string[] args) 
        {
            int size = 10;
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                int number;
                bool isUnique;
                do

                {
                    number = random.Next(-100, 101);
                    isUnique = true;


                    for (int j = 0; j < i; j++)
                    {
                        if (Math.Abs(array[j]) == Math.Abs(number))
                        {
                            isUnique = false;
                            break;
                        }
                    }
                } while (!isUnique);

                array[i] = number;
            }

           
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();


            int maxAbs = array[0];
            for (int i = 1; i < size; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(maxAbs))
                {
                    maxAbs = array[i];
                }
            }

            Console.WriteLine($"Наибольшее по модулю число: {maxAbs}");
        }
    }
}
