using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_pdfHW02
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется: Создать класс с именем Rectangle.
    //В теле класса создать два поля, описывающие длины сторон double side1, side2.
    //Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
    //  поля side1 и side2 инициализируются значениями аргументов.
    //Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
    //прямоугольника - double PerimeterCalculator().
    //Создать два свойства double Area и double Perimeter с одним методом доступа get.
    //Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
    //на экран периметр и площадь.
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Area { get { return AreaCalculator(); } }
        public double Perimeter { get { return PerimeterCalculator(); } }

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect;
            double a, b;
            while (true)
            {
                Console.Write("Введите сторону А: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Введите сторону B: ");
                b = double.Parse(Console.ReadLine());

                rect = new Rectangle(a, b);

                Console.WriteLine("Площадь Прямоугольника = " + rect.Area);
                Console.WriteLine("Периметр Прямоугольника = " + rect.Perimeter);

                Console.WriteLine(new string('_', 80));
                Console.WriteLine();
            }
        }
    }
}
