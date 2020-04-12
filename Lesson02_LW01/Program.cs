using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_LW01
{
{
    //Создайте частичный класс рабочего -  Worker в трех файлах.В одной части этого класса – создайте автосвойства – Age, Name, WorkExperience. 
    //(Подумайте какого типа должны быть эти свойства.)
    //Во второй части этого класса создайте конструктор по умолчанию, и два пользовательских конструктора – первый принимающий Name и Age 
    //и второй – принимающий Name, Age, WorkExperience.
    //В третей части класса Worker создайте метод ShowWorkerInFo(), который ничего не принимает, но выводит на экран данные по данному рабочему.
    //В теле метода Main создайте три экземпляра класса Worker – через конструктор по умолчанию, через оба пользовательских конструктора.
    //Вызовите на каждом экземпляре Worker метод ShowWorkerInFo().
    partial class Worker //файл WorkerProp.cls
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Workexperience { get; set; }
    }
    partial class Worker    //файл WorkerCtor.cls
    {
        public Worker()
        {
            Name = " ";
            Age = 0;
            Workexperience = 0;
        }
        public Worker(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Worker(string name, int age, int workexperience)
            : this(name, age)
        {
            Workexperience = workexperience;
        }

    }
    partial class Worker    //файл WorkerMethod.cls
    {
        public void ShowWorkerInFo()
        {
            Console.WriteLine("Имя: {0}, Возраст: {1}, Опты работы(Лет): {2}", Name, Age, Workexperience);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Console.WriteLine("Рабочий по умолчанию");
            worker.ShowWorkerInFo();

            Console.WriteLine(new string('-', 50));

            worker = new Worker("Petrus Pupkin", 25);
            Console.WriteLine("Рабочий с именем и возрастом");
            worker.ShowWorkerInFo();
            Console.WriteLine(new string('-', 50));

            worker = new Worker("Johan Barskih", 36, 10);
            Console.WriteLine("Рабочий с именем и возрастом");
            worker.ShowWorkerInFo();
            Console.WriteLine(new string('-', 50));

            Console.ReadLine();
        }
    }
}
