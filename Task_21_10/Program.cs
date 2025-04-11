namespace Task_21_10
{
    internal class Program
    {
        /* Написать метод, который объединяет два словаря.
         * Если ключ присутствует в обоих словарях, суммировать их значения.
        */

        static void Main(string[] args)
        {
            var dict1 = new Dictionary<int, int>
    {
        {1, 1},
        {2, 2}
    };

            var dict2 = new Dictionary<int, int>
    {
        {2, 3},
        {3, 4}
    };

            var merged = MergeDictionaries(dict1, dict2);

            foreach (var item in merged)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }

        public static Dictionary<int, int> MergeDictionaries(Dictionary<int, int> dict1, Dictionary<int, int> dict2)
        {
            var result = new Dictionary<int, int>();

            if (dict1 != null)
            {
                foreach (var kvp in dict1)
                {
                    result[kvp.Key] = kvp.Value;
                }
            }

            if (dict2 != null)
            {
                foreach (var kvp in dict2)
                {
                    if (result.TryGetValue(kvp.Key, out int existingValue))
                    {
                        result[kvp.Key] = existingValue + kvp.Value;
                    }
                    else
                    {
                        result[kvp.Key] = kvp.Value;
                    }
                }
            }

            return result;
        }
    }
}
