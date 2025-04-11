namespace Task_20_05
{
    internal class Program
    {
        /* Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
         * • Guest (только чтение)
         * • User (чтение + комментарии)
         * • Moderator (удаление контента)
         * • Admin (полный доступ)
         * Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалить пост).На основе уровня доступа выводите сообщение (например,
         * "Ошибка: Недостаточно прав!").
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш уровень доступа (Guest, User, Moderator, Admin):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out AccessLevel accessLevel))
            {
                TryToDeletePost(accessLevel);
            }
            else
            {
                Console.WriteLine("Ошибка: Неверный уровень доступа.");
            }
        }

        static void TryToDeletePost(AccessLevel accessLevel)
        {
            if (CanDeletePost(accessLevel))
            {
                Console.WriteLine("Пост успешно удалён.");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно прав!.");
            }
        }

        static bool CanDeletePost(AccessLevel accessLevel)
        {
            return accessLevel == AccessLevel.Moderator || accessLevel == AccessLevel.Admin;
        }
    }
}

