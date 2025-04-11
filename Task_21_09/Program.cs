using System.Net.Sockets;

namespace Task_21_09
{
    internal class Program
    {
        /* создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
         * • поиск билета с максимальной суммой, 
         * • билета с минимальной суммой,
         * • выведите список билетов с багажом
         * • выведите список люготных билетов
        */

        static void Main(string[] args)
        {
            var rnd = new Random();
            var tickets = new List<Ticket>();

            // Генерация 30 билетов с случайными значениями
            for (int i = 0; i < 30; i++)
            {
                tickets.Add(new Ticket
                {
                    Price = rnd.Next(1000, 10001),
                    HasLuggage = rnd.Next(2) == 0,
                    IsDiscount = rnd.Next(4) == 0
                }
                );
            }

            var maxPrice = tickets.Max(x => x.Price); // максимальная цена
            var minPrice = tickets.Min(x => x.Price); // минимальная цена

            Console.WriteLine($"Максимальная цена: {maxPrice}, Минимальная цена: {minPrice}");

            // Список билетов с багажом
            Console.WriteLine("\nСписок билетов с багажом:");
            var luggageTickets = tickets.FindAll(x => x.HasLuggage);
            luggageTickets.ForEach(x => Console.WriteLine(x));

            // Список льготных билетов
            Console.WriteLine("\nЛьготные билеты:");
            var discountTickets = tickets.FindAll(x => x.IsDiscount);
            discountTickets.ForEach(x => Console.WriteLine(x));
        }
    }
}
