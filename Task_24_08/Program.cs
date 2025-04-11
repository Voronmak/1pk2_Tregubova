namespace Task_24_08
{
    internal class Program
    {
        /* реализуйте функцию, осуществляющую поиск текста 
         * в файле и его замену на значения, введенные пользователем
         */

        static void Main(string[] args)
        {
            string filePath = "example.txt";

            Console.Write("Введите текст для поиска: ");
            string textToFind = Console.ReadLine();

            Console.Write("Введите текст для замены: ");
            string replacementText = Console.ReadLine();

            ReplaceTextInFile(filePath, textToFind, replacementText);

            Console.WriteLine("Замена выполнена успешно!");
        }

        public static void ReplaceTextInFile(string filePath, string textToFind, string replacementText)
        {
            // Читаем содержимое файла
            string fileContent = File.ReadAllText(filePath);

            // Заменяем текст
            string updatedContent = fileContent.Replace(textToFind, replacementText, StringComparison.OrdinalIgnoreCase);

            // Записываем обновленное содержимое обратно в файл
            File.WriteAllText(filePath, updatedContent);
        }
    }
}
