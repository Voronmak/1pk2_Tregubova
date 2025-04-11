namespace Task_21_06
{
    internal class Program
    {
        /* Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок. */
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 8, 2, 8, 9, 4, 6, 7, 7, 10, 15, 17, 5 };
            var distinctNumbers = GetUniqueNumbers(numbers);

            foreach (var number in distinctNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        public static List<int> GetUniqueNumbers(List<int> inputList)
        {
            var encountered = new HashSet<int>();
            var uniqueList = new List<int>();

            foreach (var currentItem in inputList)
            {
                if (encountered.Add(currentItem))
                {
                    uniqueList.Add(currentItem);
                }
            }

            return uniqueList;
        }
    }
}
