using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_LW02
{
    //Создайте класс Pie. В теле класса создайте private readonly поле manufacturingDate типа DateTime.
    //Создайте конструктор по умолчанию в теле Pie, 
    //который будет инициализировать поле manufacturingDate значением текущей даты и времени 
    //(Принцип такой: DateTime dateTime = DateTime.Now;). 
    //В теле Pie создайте метод GetManufacturingDate, который должен выводить на экран дату
    //В методе Main()  создайте два экземпляра класса Pie.Выведите на них дату производства на экран.

    class Pie
    {
        private readonly DateTime manufacturingDate;
        public Pie()
        {
            manufacturingDate = DateTime.Now;
        }

        public void GetManufacturingDate()
        {
            Console.WriteLine("Дата создания: " + manufacturingDate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pie pie = new Pie();
            Pie pie2 = new Pie();

            pie.GetManufacturingDate();
            pie2.GetManufacturingDate();
        }
    }
