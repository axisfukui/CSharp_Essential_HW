using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_pdfHW02
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создайте класс AbstractHandler.
    //В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
    //Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
    //AbstractHandler.
    //Написать программу, которая будет выполнять определение документа и для каждого формата
    //должны быть методы открытия, создания, редактирования, сохранения определенного
    //формата документа.


    class Program
    {
        static void Main(string[] args)
        {
            UseHandler(new XMLHandler());

            Console.WriteLine();
            UseHandler(new DOCHandler());
            Console.WriteLine();
            UseHandler(new TXTHandler());

            Console.ReadLine();

        }
        static void UseHandler(AbstractHandler handler)
        {
            handler.Chenge();
            handler.Create();
            handler.Open();
            handler.Save();
        }
    }
}
