using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_LW01_v02
{
    //Задание: создать класс человека, описать ему состояние(к примеру: имя, пол, национальность, возраст, вес, рост, цвет глаз, цвет волос...). 
    //Выберите несколько на свое усмотрение.
    //Сделать метод MoveOn, который принимает в качестве параметра контракт на возможность ездить на чем то.

    //Создать класс для транспортных средств, где нужно описать имя, модель транспортного средства, цвет.
    //А так же поле с самым водителем, чтобы транспортное средство не могло ехать без водителя(Разве что вы создадите теслу :)). 

    //Создать класс автомобиль, мотоцикл, конь.В данном контексте, мы каждый из этих классов воспринимаем как средство передвижения, 
    //значит они должны реализовать некий контракт, чтобы человек мог с ними взаимодействовать как с транспортным средством.

    //Здесь задание описано абстрактно, на ваше усмотрение нужно выбрать где создать абстрактный класс, где интерфейс или возможно нужно обойтись только одним чем-то.

    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Василий", 30, "Male");
            Human human2 = new Human("Боря", 25, "Male");
            Human human3 = new Human("Михай", 40, "Male");

            Car car = new Car("MB V6", "Green", "AMG", human);
            Horse horse = new Horse("Боливар", "Пегий", human2);
            Motocycle motocycle = new Motocycle("Suzuki", "Red", "s600", human3);

            human.MoveOn(car);
            Console.WriteLine(new string('-', 80));
            human.MoveOn(horse);
            Console.WriteLine(new string('-', 80));
            human.MoveOn(motocycle);

            Console.ReadLine();
        }
    }
}
