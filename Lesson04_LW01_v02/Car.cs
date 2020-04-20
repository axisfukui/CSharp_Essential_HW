using System;

namespace Lesson04_LW01_v02
{
    class Car : Transport, IMovable
    {
        public Car(string name, string color, string model, Human driver)
        {
            Human = driver;
            Name = name;
            Color = color;
            Model = model;
        }

        public string Model { get; }

        public void Move()
        {
            Console.WriteLine($"{Human?.Name} возрасте {Human?.Age} едет на Машине");
            System.Console.WriteLine("Рум рум по райончику");
        }
    }
}
