namespace Task_11_03
{
    internal class Program
    { 
        /* Выходной параметр (out): Напишите метод,
       * который принимает строку и возвращает через
       * выходной параметр количество гласных 
       * и согласных букв в этой строке 
       */

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            int vowelCount, consonantCount;
            CountLetters(input, out vowelCount, out consonantCount);

            Console.WriteLine($"Количество гласных: {vowelCount}");
            Console.WriteLine($"Количество согласных: {consonantCount}");
        }

        /// <summary>
        /// Подсчитывает количество гласных и согласных букв в строке.
        /// </summary>
        /// <param name="input">Входная строка для анализа.</param>
        /// <param name="vowelCount">Количество гласных букв (выходной параметр).</param>
        /// <param name="consonantCount">Количество согласных букв (выходной параметр).</param>
        
        static void CountLetters(string input, out int vowelCount, out int consonantCount)
        {
            vowelCount = 0;
            consonantCount = 0;

            foreach (char c in input.ToLower())
            {
                if (char.IsLetter(c)) // Проверяем, является ли символ буквой
                {
                    if ("aeiou".Contains(c)) // Проверяем, является ли буква гласной
                    {
                        vowelCount++;
                    }
                    else // Если это буква, но не гласная, значит она согласная
                    {
                        consonantCount++;
                    }
                }
            }
        }
    }
}
