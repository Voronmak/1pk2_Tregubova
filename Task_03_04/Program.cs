namespace Task_03_04
{
    internal class Program
    { /* Пользователь вводить в консоли произвольный текст.
       * После каждого ввода консоль очищается. 
       * Когда пользователь вводить слово «exit» или пустую строку – 
       * ввод останавливается и 
       * выводиться количество строк 
       * введенных пользователем.
      */
        static void Main(string[] args)
        {
            int lineCount = 0;
            string input;

            while (true)
            {
                Console.Clear(); //Очищаем консоль
                Console.WriteLine("Введите текст (нажмите Enter для выхода):");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input) || input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break; //Выход из цикла, если введено "exit" или пустая строка
                }

                lineCount++; //Увеличиваем счётчик строк
            }

            Console.Clear(); //Очищаем консоль перед выводом результата
            Console.WriteLine($"Количество введённых строк: {lineCount}");
        }
    }
}