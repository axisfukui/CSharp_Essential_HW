using System;

namespace Lesson04_LW01_v02
{
    class Horse : Transport, IMovable
    {
        public Horse(string name, string color, Human human)
        {
            Human = human;
            Name = name;
            Color = color;
        }
        public void Move()
        {
            Console.WriteLine($"{Human?.Name} возрасте {Human?.Age} едет на Коне");
            Console.WriteLine("Ты-гы-дык Ты-гы-дык");
        }
    }
}
