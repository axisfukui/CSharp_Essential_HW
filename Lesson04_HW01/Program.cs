using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_HW01
{
    //Создайте абстрактный класс Animal.В классе Animal создайте абстрактные методы Eat и Move. 
    //Создайте абстрактные классы Bird, Mammal и Fish, унаследованные от Animal.
    //Создайте интерфейсы ISwimable, IFlyable, IWalkable.В соответствующих интерфейсах создайте соответствующие методы Swim, Fly, Walk.
    //Создайте конкретные классы Duck, Penguin, Dolphin, унаследованные от соответствующих абстрактных классов и от соответствующих интерфейсов.
    //Реализуйте методы Eat и Move.Реализуйте все интерфейсы.Реализуйте возможность методом Move выбирать метод вида движения для соответствующего конкретного класса.
    //Создайте экземпляры классов Duck, Penguin, Dolphin.На них продемонстрируйте методы Eat и Move.


    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Penguin(), new Duck(), new Dolphin(), new Duck() };

            foreach (var a in animals)
            {
                a.Eat();
                a.Move();                
            }

            Console.ReadLine();
        }
    }
}
