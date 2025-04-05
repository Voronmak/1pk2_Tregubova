namespace Task_19_01
{
    /* 1. Напишите программу, в которой пользователь вводит произвольный текст в консоли,
     * после чего программа запрашивает подстроку для поиска. 
     * Если подстрока найдена - то программа запрашивает текст для того чтобы заменить на него эту подстроку 
     * (столько раз, сколько раз подстрока встречена в тексте)
     * Пример:
     * Введите строку: "Привет, мир!"
     * Введите подстроку для поиска: "мир"
     * Введите подстроку для замены: "друг"
     * Результат: "Привет, друг!"
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: "); // Запрашиваем у пользователя ввод текста
            string inputText = Console.ReadLine();

            Console.Write("Введите подстроку для поиска: "); // Запрашиваем подстроку у пользователя для поиска
            string searchString = Console.ReadLine();

            // Проверяем, найдена ли подстрока
            if (inputText.Contains(searchString))
            {
                Console.Write("Введите подстроку для замены: "); // Запрашиваем подстроку для замены
                string replaceString = Console.ReadLine();

                string resultText = inputText.Replace(searchString, replaceString); // Заменяем найденную подстроку на новую

                Console.WriteLine("Результат: " + resultText); 
            }
            else
            {
                Console.WriteLine("Подстрока не найдена.");
            }
        }
    }
}
