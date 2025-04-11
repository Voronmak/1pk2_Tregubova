namespace Task_20_04
{
    internal class Program
    {
        /* Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
         * • Car
         * • Bike
         * • Bus
         * • Truck
         * • Motorcycle
         * Храните список транспортных средств (можно просто List<VehicleType>). 
         * Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков).
         * Реализуйте поиск по типу и вывод информации.
        */

        static void Main(string[] args)
        {
            List<VehicleType> vehicles = new List<VehicleType>
            {
                VehicleType.Car,
                VehicleType.Car,
                VehicleType.Car,
                VehicleType.Car,
                VehicleType.Car,
                VehicleType.Car,
                VehicleType.Bike,
                VehicleType.Bike,
                VehicleType.Bike,
                VehicleType.Bus,
                VehicleType.Bus,
                VehicleType.Motorcycle,
                VehicleType.Motorcycle,
                VehicleType.Truck,
                VehicleType.Truck

            };

            Console.WriteLine("Все транспортные средства:");
            PrintVehicles(vehicles);


            Console.WriteLine("\nКоличество транспортных средств по типам:");
            foreach (VehicleType type in Enum.GetValues(typeof(VehicleType)))
            {
                int count = CountVehiclesByType(vehicles, type);
                Console.WriteLine($"{type}: {count}");
            }
            static void PrintVehicles(List<VehicleType> vehicles)
            {
                if (vehicles.Count == 0)
                {
                    Console.WriteLine("Транспортные средства не найдены.");
                    return;
                }

                for (int i = 0; i < vehicles.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {vehicles[i]}");
                }
            }
            static int CountVehiclesByType(List<VehicleType> vehicles, VehicleType type)
            {
                int count = 0;
                foreach (var vehicle in vehicles)
                {
                    if (vehicle == type) count++;
                }
                return count;
            }
        }
    }
}
