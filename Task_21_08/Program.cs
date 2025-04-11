namespace Task_21_08
{
    internal class Program
    {
        /*  напишите метод, который на вход получается массив параметров (строк)
         *  и возвращает только уникальные строки 
        */

        static void Main(string[] args)
        {
            string[] inputArray = { "хлеб", "молоко", "масло", "хлеб", "сахар", "молоко", "сыр" };

            string[] uniqueStrings = GetUniqueStrings(inputArray); // Вызов метода для получения уникальных строк

            Console.WriteLine("Уникальные строки:"); // Выводим уникальные строки на экран
            foreach (string str in uniqueStrings)
            {
                Console.WriteLine(str);
            }
        }

        // Метод для получения уникальных строк
        public static string[] GetUniqueStrings(string[] input)
        {
            HashSet<string> uniqueSet = new HashSet<string>();

            foreach (string str in input)
            {
                uniqueSet.Add(str);
            }

            return new List<string>(uniqueSet).ToArray();
        }
    }
}