using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33_01
{
    internal class Rectangle : IDrawable
    {
        private int firstcatheter;
        private int secondcatheter;
        public int Firstcatheter
        {
            get => firstcatheter;
            set
            {
                if (value > 1)
                    firstcatheter = value;
                else
                    throw new ArgumentException("Катет не должен быть меньше или равен 1");
            }
        }

        public int Secondcatheter
        {
            get => secondcatheter;
            set
            {
                if (value > 1)
                    secondcatheter = value;
                else
                    throw new ArgumentException("Катет не должен быть меньше или равен 1");
            }
        }

        public Rectangle(int height, int width)
        {
            firstcatheter = height;
            secondcatheter = width;
        }

        public void Draw()
        {
            Console.WriteLine();


            for (int i = 1; i <= firstcatheter; i++)
            {
                int stars = (int)Math.Round((double)i / firstcatheter * secondcatheter);

                for (int j = 0; j < stars; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
