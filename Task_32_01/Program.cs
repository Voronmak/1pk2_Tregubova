using Task_32_01;

namespace Task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; }
        public bool IsAlive { get; private set; }

        private int slowDownStepsRemaining = 0;

        public Kolobok()
        {
            Position = 0;
            Speed = 1;
            IsAlive = true;
        }

        public void Roll(List<Obstacle> obstacles)
        {
            int actualSpeed = Speed;

            if (slowDownStepsRemaining > 0)
            {
                actualSpeed = 1; // замедление до 1 шага
                slowDownStepsRemaining--;
                Console.WriteLine($"Колобок замедлен, скорость сейчас: {actualSpeed}");
            }

            Position += actualSpeed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");

            foreach (var obstacle in obstacles)
            {
                if (obstacle.Position == Position)
                {
                    slowDownStepsRemaining = obstacle.SlowDownDuration;
                    Console.WriteLine($"Колобок столкнулся с {obstacle.Name} и замедлился на {slowDownStepsRemaining} ходов!");
                }
            }
        }

        //встреча с животным
        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }
    }

    public abstract class Animal
    {
        public string Name { get; } //название животного
                                    //конструктор, который будет срабатывать в дочерних классах
                                    //т.к. используется protected
        protected Animal(string name)
        {
            Name = name;
        }
        //все животные захотят съесть колобка
        //но вот получится ли - вопрос...
        public abstract bool CanEat(Kolobok kolobok);
    }

    public class Hare : Animal
    {
        public Hare() : base("Заяц") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Заяц не смог съесть Колобка
        }
    }

    public class Wolf : Animal
    {
        public Wolf() : base("Волк") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Волк тоже не справился
        }
    }

    public class Bear : Animal
    {
        public Bear() : base("Медведь") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Медведь оказался слишком медленным
        }
    }

    public class Fox : Animal
    {
        public Fox() : base("Лиса") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return true; // Лиса хитрая и съела Колобка
        }
    }

    public abstract class Obstacle
    {
        public string Name { get; }
        public int Position { get; }
        public int SlowDownDuration { get; } // количество ходов замедления

        protected Obstacle(string name, int position, int slowDownDuration)
        {
            Name = name;
            Position = position;
            SlowDownDuration = slowDownDuration;
        }
    }

        public class Stone : Obstacle
        {
            public Stone(int position) : base("Камень", position, 2) { }
        }

        public class Puddle : Obstacle
        {
            public Puddle(int position) : base("Лужа", position, 1) { }
        


        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();
            List<Animal> animals = new List<Animal>
            {
            new Hare(),
            new Wolf(),
            new Bear(),
            new Fox()
            };

            List<Obstacle> obstacles = new List<Obstacle>
            {
            new Stone(2),
            new Puddle(4)
            };

            foreach (var animal in animals)
            {
                if (!kolobok.IsAlive)
                    break;
                kolobok.Roll(obstacles);
                kolobok.MeetAnimal(animal);
            }
            if (kolobok.IsAlive)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
        }

    }
}
