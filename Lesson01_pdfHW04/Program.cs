using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_pdfHW04
{
    //    Задание 4
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать классы Point и Figure.
    //Класс Point должен содержать два целочисленных поля и одно строковое поле.
    //Создать три свойства с одним методом доступа get.
    //Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
    //аргументов.Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
    //аргументов типа Point.
    //Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
    //стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
    //многоугольника.
    //Написать программу, которая выводит на экран название и периметр многоугольника.
    class Point
    {
        private int a, b;

        public Point(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int A { get { return a; } }
        public int B { get { return b; } }
    }
    class Figure
    {
        private string s;

        Point[] points;

        public Figure(string name, Point p1, Point p2, Point p3)
        {
            s = name;
            points = new Point[] { p1, p2, p3 };

        }
        public Figure(string name, Point p1, Point p2, Point p3, Point p4)
        {
            s = name;
            points = new Point[] { p1, p2, p3, p4 };
        }
        public Figure(string name, Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            s = name;
            points = new Point[] { p1, p2, p3, p4, p5 };

        }
        public string S { get { return s; } }

        private double LengthSide(Point A, Point B)
        {
            double sideLength = Math.Sqrt(Math.Pow(A.A - B.A, 2) + Math.Pow(A.B - B.B, 2));
            Console.WriteLine(sideLength);
            return sideLength;
        }

        public void PerimeterCalculator()
        {
            double r = 0;
            for (int i = 0; i < points.Length; i++)
            {
                r += LengthSide(points[i], points[i + 1 < points.Length ? i + 1 : 0]);
            }

            Console.WriteLine("Праметр {0} равен: " + r);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure1 = new Figure("Треугольник", new Point(1, 3), new Point(2, 6), new Point(4, 8));

            GetFigureNameAndPerimeter(figure1);
            Console.WriteLine(new string('-', 80));

            Figure figure2 = new Figure("Пятиугольник", new Point(1, 3), new Point(2, 6), new Point(4, 8), new Point(15, 40), new Point(6, 10));
            GetFigureNameAndPerimeter(figure2);

            Console.ReadLine();
        }

        private static void GetFigureNameAndPerimeter(Figure f)
        {
            Console.WriteLine("Название: " + f.S);
            f.PerimeterCalculator();
        }
    }
}
