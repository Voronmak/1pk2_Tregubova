namespace Task_24_06
{
    internal class Program
    {
        /* Напишите метод, который принимает путь к файлу
         * и возвращает количество строк в нем. 
         * ИспользуйтеStreamReader. 
        */

        static void Main(string[] args)
        {
            string filePath = "text.txt";
            int lines = CountLinesInFile(filePath);
            Console.WriteLine($"Количество строк в файле: {lines}");
        }

        // Метод, который принимает путь к файлу и возвращает количество строк
        public static int CountLinesInFile(string filePath)
        {
            int lineCount = 0; 

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null) 
                {
                    lineCount++; // Увеличиваем счетчик строк
                }
            }

            return lineCount; // Возвращаем количество строк
        }
    }
}
