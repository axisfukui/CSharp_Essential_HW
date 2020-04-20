using System;

namespace Lesson04_LW01_v02
{
    class Motocycle : Transport, IMovable
    {
        public Motocycle(string name, string color, string model, Human driver)
        {
            Human = driver;
            Name = name;
            Color = color;
            Model = model;
        }
        public string Model { get;}

        public void Move()
        {
            Console.WriteLine($"{Human?.Name} возрасте {Human?.Age} едет на Мотоцикле");
            System.Console.WriteLine("Кааааа-Ваааааа-Заааа-Кииииииииии");
        }
    }
}
