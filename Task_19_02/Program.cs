namespace Task_19_02
{
    /* 2. Напишите программу, которая запрашивает у пользователя произвольный текст,
     * содержащий предложения (есть знаки препинания). 
     * программу после анализа выводит текст, разделенный на части:
     * a)	По пробелам (отдельные слова построчно)
     * b)	По предложениям (отдельные предложения построчно)
     * (используйте метод Split())
     */

    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите текст (с предложениями и знаками препинания):"); // запрашиваем произовльный текст у пользователя
            string inputText = Console.ReadLine();

            // a) Разделение по пробелам (отдельные слова построчно)
            Console.WriteLine("\nСлова, разделенные по пробелам:");
            string[] words = inputText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // b) Разделение по предложениям (отдельные предложения построчно)
            Console.WriteLine("\nПредложения, разделенные знаками препинания:");
            char[] sentenceDelimiters = { '.', ',', '!', '?', ':', ';' };
            string[] sentences = inputText.Split(sentenceDelimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}
