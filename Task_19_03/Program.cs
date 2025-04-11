namespace Task_19_03
{
    internal class Program
    {
        /* 3. Напишите консольное приложение, в котором осуществляется построчный пользовательский ввод 
         * (ввод каждой строки подтверждается нажатием на enter).
         * количество введенных строк произвольно, ввод завершается при вводе пустой строки. 
         * После окончания ввода произведите объединение всех ранеее введенных строк в одну
         * с использованием разделителя «-»
         * Например:
         * Введите строку 1: "Hello"
         * Введите строку 2: "world"
         * Введите строку 3: "C#"
         * Результат: "Hello-world-C#"
         */

        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            string input;
            int lineNumber = 1;

            // Построчный ввод
            while (true)
            {
                Console.Write($"Введите строку {lineNumber}: ");
                input = Console.ReadLine();

                // Проверяем на пустую строку для завершения ввода
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                lines.Add(input);
                lineNumber++;
            }

            string result = string.Join("-", lines);  // Объединяем все введенные строки, используя разделитель "-"

            Console.WriteLine($"Результат: \"{result}\"");
        }
    }
}
