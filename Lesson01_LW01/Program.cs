using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_LW01
{
    //Создайте класс Circle. В классе создайте не публичное поле вещественного типа – radius.
    //Создайте методы доступа(свойства) к этому полю – аксессор и мутатор.
    //Создайте два метода в теле класса – GetArea() и GetCircumference(), возвращающие соответственно площадь 
    //круга и длину окружности. 
    //В методе Main создайте экземпляр класса Circle.Пользователь должен ввести радиус круга.
    //Вызовите соответствующие методы и выведите на экран площадь этого круга и длину окружности.

    class Circle
    {
        private double radius;
        private double pi = 3.14D;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double GetArea()
        {
            return pi * (radius * radius);
        }
        public double GetCircumference()
        {
            return 2 * pi * radius;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine("Введите радиус: ");
            circle.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Площадь круга составляет: " + circle.GetArea());
            Console.WriteLine("Длинна окружности: " + circle.GetCircumference());

            Console.ReadLine();
        }
    }
}

