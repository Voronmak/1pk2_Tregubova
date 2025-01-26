namespace Task_02_04
{
    internal class Program
    {
       /* Пользователь вводит свою дату рождения построчно
       * (сначала год, потом месяц и в конце дату) 
       * произведите
       * расчет является ли пользователь совершеннолетним 
       * на текущую дату и выведите соответствующее сообщение
       * об этом
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год рождения:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц рождения:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день рождения:");
            int day = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - birthDate.Year;

            //Если день рождения в этом году еще не наступил,то уменьшаем возраст на 1
            if (currentDate < birthDate.AddYears(age))
            {
                age--;
            }

            if (age >= 18)
            {
                Console.WriteLine("Вы совершеннолетний.");
            }
            else
            {
                Console.WriteLine("Вы еще несовершеннолетний.");
            }
        }
    }
}