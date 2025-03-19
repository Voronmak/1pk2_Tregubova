namespace Task_14_04
{
    public class User
    {
        /* Определите класс User, 
         * который будет иметь статическое свойство CurrentUser,
         * представляющее текущего пользователя,
         * и метод для его установки.
         */

        // Статическое свойство для хранения текущего пользователя
        private static User currentUser;

        // Свойство для доступа к текущему пользователю
        public static User CurrentUser
        {
            get { return currentUser; }
        }

        // Свойство для имени пользователя
        public string Name { get; set; }

        // Метод для установки текущего пользователя
        public static void SetCurrentUser(User user)
        {
            currentUser = user;
        }

        // Конструктор класса User
        public User(string name)
        {
            Name = name;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Создаем нового пользователя
            User user1 = new User("Richard");

            // Устанавливаем текущего пользователя
            User.SetCurrentUser(user1);

            // Выводим имя текущего пользователя
            Console.WriteLine("Текущий пользователь: " + User.CurrentUser.Name);

            // Создаем еще одного пользователя
            User user2 = new User("Bob");

            // Устанавливаем нового текущего пользователя
            User.SetCurrentUser(user2);

            // Выводим имя текущего пользователя
            Console.WriteLine("Текущий пользователь: " + User.CurrentUser.Name);
        }
    }
}
