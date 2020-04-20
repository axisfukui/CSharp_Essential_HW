using Lesson04_HW01.Abstract;
using Lesson04_HW01.Interfaces;
using System;

namespace Lesson04_HW01
{
    class Duck : Bird, IFlyable, IWalkable, ISwimmable

    {
        public override void Eat()
        {
            Console.WriteLine("Утка ест");
        }

        public void Fly()
        {
            Console.WriteLine("Утка летит");
        }

        public override void Move()
        {
            Console.WriteLine("Выбрать действие: 1- идти / 2-плавать / 3-летать");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Walk();
                    break;
                case 2:
                    Swim();
                    break;
                case 3:
                    Fly();
                    break;
                default:
                    break;
            }
        }

        public void Swim()
        {
            Console.WriteLine("Утка плывет");
        }

        public void Walk()
        {
            Console.WriteLine("Утка гуляет");
        }
    }
}
