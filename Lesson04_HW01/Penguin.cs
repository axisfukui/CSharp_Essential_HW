using Lesson04_HW01.Abstract;
using Lesson04_HW01.Interfaces;

namespace Lesson04_HW01
{
    class Penguin : Mammal, IWalkable
    {
        public override void Eat()
        {
            System.Console.WriteLine("Пингвин ест");
        }

        public override void Move()
        {
            Walk();
        }

        public void Walk()
        {
            System.Console.WriteLine("Пингвин ходит");
        }
    }
}
