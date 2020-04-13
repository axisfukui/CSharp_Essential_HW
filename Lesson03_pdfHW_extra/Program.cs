using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_pdfHW_extra
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создайте класс Printer.
    //В теле класса создайте метод void Print(string value), который выводит на экран значение
    //аргумента.
    //Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
    //соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
    //выводились разными цветами.
    //Обязательно используйте приведение типов.

    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
    class RedPrinter : Printer
    {
        public override void Print(string value)
        {
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            base.Print(value);

            Console.ForegroundColor = c;

        }
        public void PrintRed()
        {
            Console.WriteLine("Red");
        }
    }
    class GreenPrinter : Printer
    {
        public void Print(string value)
        {
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            base.Print(value);

            Console.ForegroundColor = c;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Print text");

            Printer redPrinter = new RedPrinter(); //Приведение к типу?
            redPrinter.Print("redPrinter text"); 

            Printer redPrinterUP = redPrinter as Printer;     /* Эквивалентно строке 63 ?*/
            redPrinterUP.Print("redPrinter text after upCast");

            RedPrinter redprinterDOWN = redPrinter as RedPrinter;
            redprinterDOWN.Print("redPrinterUP after downCast");


            Printer gp = new GreenPrinter();
            gp.Print("Green Printer text");

            Printer gpUP = gp as Printer; //UP Cast
            gpUP.Print("Green Printer text after UP Cast");

            GreenPrinter gpDown = gpUP as GreenPrinter; //DownCast
            gpDown.Print("Green Printer text after DOWN Cast");
            Console.ReadLine();
        }
    }
}
