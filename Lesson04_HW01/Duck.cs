using Lesson04_HW01.Abstract;
using Lesson04_HW01.Interfaces;
using System;

namespace Lesson04_HW01
{
    class Duck : Bird, IFlyable
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
            Fly();
        }
    }
}
