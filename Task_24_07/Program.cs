namespace Task_24_07
{
    internal class Program
    {
        /* Реализуйте функцию, которая ищет заданное слово в текстовом файле
         * и возвращает все строки, содержащие это слово (регистронезависимо).
        */

        static void Main(string[] args)
        {
            string filePath = "text.txt";

            Console.Write("Введите слово для поиска: ");
            string wordToFind = Console.ReadLine();

            string[] linesContainingWord = FindLinesContainingWord(filePath, wordToFind);

            Console.WriteLine("Строки, содержащие слово:");
            foreach (string line in linesContainingWord)
            {
                Console.WriteLine(line);
            }
        }

        public static string[] FindLinesContainingWord(string filePath, string word)
        {
            // Используем массив для хранения строк, содержащих слово
            var matchingLines = new System.Collections.Generic.List<string>();

            // Читаем файл построчно
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Если строка содержит слово (регистронезависимо), добавляем её в список
                    if (line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matchingLines.Add(line);
                    }
                }
            }

            // Возвращаем найденные строки в виде массива
            return matchingLines.ToArray();
        }
    }
}
