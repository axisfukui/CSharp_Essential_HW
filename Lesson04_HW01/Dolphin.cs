using Lesson04_HW01.Abstract;
using Lesson04_HW01.Interfaces;

namespace Lesson04_HW01
{
    class Dolphin : Fish, ISwimmable
    {
        public override void Eat()
        {
            System.Console.WriteLine("Дельфин ест");
        }

        public override void Move()
        {
            Swim();
        }

        public void Swim()
        {
            System.Console.WriteLine("Дельфин плавает");
        }
    }
}
