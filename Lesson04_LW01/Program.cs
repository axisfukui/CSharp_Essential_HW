using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_LW01
{
    //Задание: создать класс человека, описать ему состояние(к примеру: имя, пол, национальность, возраст, вес, рост, цвет глаз, цвет волос...). 
    //Выберите несколько на свое усмотрение.
    //Сделать метод MoveOn, который принимает в качестве параметра контракт на возможность ездить на чем то.

    //Создать класс для транспортных средств, где нужно описать имя, модель транспортного средства, цвет.
    //А так же поле с самым водителем, чтобы транспортное средство не могло ехать без водителя(Разве что вы создадите теслу :)). 

    //Создать класс автомобиль, мотоцикл, конь.В данном контексте, мы каждый из этих классов воспринимаем как средство передвижения, 
    //значит они должны реализовать некий контракт, чтобы человек мог с ними взаимодействовать как с транспортным средством.

    //Здесь задание описано абстрактно, на ваше усмотрение нужно выбрать где создать абстрактный класс, где интерфейс или возможно нужно обойтись только одним чем-то.
    class Human
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int Weight { get; private set; }

        public Human(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public void MoveOn(ITransport transport)
        {
            Console.WriteLine($"{Name} drive on");
            transport?.Move();
        }
    }
    abstract class Vehicle
    {
        public Human Driver { get; private set; }
        public Vehicle(Human driver, string name, string model, string color)
        {
            Driver = driver;
            Name = name;
            Model = model;
            Color = color;
        }
        public string Name { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }

        public virtual void GetInformation()
        { Console.WriteLine($"Водитель: {Driver.Name}\n" +
            $"Модель: {Model}\n" +
            $"Цвет: {Color}"); }

    }
    public interface ITransport
    {
       void Move();
    }

    class Horse : Vehicle, ITransport
    {
        public Horse(Human driver, string name, string model, string color)
            :base (driver, name, model, color)
        {

        }

        public void Move()
        {
            Console.WriteLine("Иго-го-го");
        }
    }
    class Motorcycle : Vehicle, ITransport
    {
        public Motorcycle(Human driver, string name, string model, string color)
          : base(driver, name, model, color)
        {

        }
        public void Move()
        {
            Console.WriteLine("Рум-рум-рум");
        }
    }
    class Car : Vehicle, ITransport
    {
        public Car(Human driver, string name, string model, string color)
          : base(driver, name, model, color)
        {

        }
        public void Move()
        {
            Console.WriteLine("Ррррррррррррррр");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human driver = new Human("Вася", 18, 110);

            Horse horse = new Horse(driver, "Мустанг", "Тягловый", "Белый");
            horse.GetInformation();
            driver.MoveOn((horse as ITransport));

            Console.ReadLine();
        }
    }
}
