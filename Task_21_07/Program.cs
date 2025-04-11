namespace Task_21_07
{
    internal class Program
    {
        /* Написать метод, который находит первый ключ в словаре,
         * соответствующий заданному значению. 
         * Если значения нет, вернуть null. 
         */

        static void Main(string[] args)
        {
            var myDictionary = new Dictionary<string, int>();
            myDictionary["Хлеб"] = 1;
            myDictionary["Молоко"] = 2;
            myDictionary["Сыр"] = 3;
            myDictionary["Масло"] = 5;
            myDictionary["Сахар"] = 4;

            // Запрашиваем значение у пользователя
            Console.Write("Введите значение: ");
            int valueToFind;

            if (int.TryParse(Console.ReadLine(), out valueToFind))
            {
                // Ищем ключ по значению
                string key = FindKeyByValue(myDictionary, valueToFind);

                // Выводим результат
                if (key != null)
                {
                    Console.WriteLine($"Найден ключ: {key}");
                }
                else
                {
                    Console.WriteLine("Ключ не найден.");
                }
            }
            else
            {
                Console.WriteLine("Введите корректное число.");
            }
        }

        // Метод для поиска ключа по значению
        public static string FindKeyByValue(Dictionary<string, int> dictionary, int value)
        {
            // Перебираем ключи словаря
            foreach (string key in dictionary.Keys)
            {
                if (dictionary[key] == value)
                {
                    return key; 
                }
            }
            return null;
        }
    }
}
