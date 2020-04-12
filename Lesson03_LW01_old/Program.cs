using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_LW01_old
{
    //Создайте класс Employee.В теле класса создайте поля age, name, workExperience, salary (поля должны быть доступны только для наследников класса). 
    //В теле класса Employee создайте метод ShowEmployeeInFo(), выводящий информацию о сотруднике на экран, создайте пользовательский конструктор, 
    //принимающий значения для инициализации полей.Создайте метод SetSalary(), устанавливающий новую зарплату.
    //Создайте производные от Employee классы Director и Salesman. 
    //В теле класса Director создайте закрытое поле subordinate, типа массива из элементов Salesman.Создайте метод, с помощью которого можно добавлять подчиненного в массив.
    //Создайте метод, с помощью которого можно удалять (занулять) подчиненного в массиве. Создайте метод, 
    //с помощью которого можно получать доступ к сотруднику в массиве.
    //В теле класса Salesman создайте поле типа Director.
    //В методе Main создайте один экземпляр класса Director и три экземпляра класса Salesman.Добавьте подчиненных директору в массив.
    //Выведите на экран данные по всем сотрудникам.Поменяйте зарплату всем сотрудникам. Выведите на экран новые данные по сотрудникам.
    class Employee
    {
        protected int age;
        protected string name;
        protected int workExperience;
        protected double salary;

        public Employee(int age, string name, int workExperience, double salary)
        {
            this.age = age;
            this.name = name;
            this.workExperience = workExperience;
            this.salary = salary;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"Имя: {name} Возраст: {age} \n" +
                $"Опыт работы: {workExperience} лет\n" +
                $"Зарплата: {salary} уе");
        }


    }

    class Director : Employee
    {
        public string Name { get { return name; } }
        public Director(int age, string name, int workExperience, double salary)
            : base(age, name, workExperience, salary)
        {

        }

        private Salesman[] subordinate = new Salesman[0];
        public void AddSalesman(Salesman salesman)
        {
            Salesman[] oldS = subordinate;

            subordinate = new Salesman[subordinate.Length + 1];
            for (int i = 0; i < oldS.Length; i++)
            {
                subordinate[i] = oldS[i];
            }
            subordinate[subordinate.Length - 1] = salesman;
        }
        public Salesman[] SackSalesman(Salesman s)
        {
            for (int i = 0; i < subordinate.Length; i++)
            {
                if (subordinate[i].Name == s.Name)
                    subordinate[i] = null;
            }
            int j = 0;
            Salesman[] newEmployee = new Salesman[subordinate.Length - 1];
            for (int i = 0; i < subordinate.Length; i++)
            {
                if (subordinate[i] != null)
                { newEmployee[j] = subordinate[i]; j++; }
            }

            return newEmployee;
        }
    }
    class Salesman : Employee
    {
        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public int WorkExperience { get { return workExperience; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public Director Director { get; set; }
        public Salesman(int age, string name, int workExperience, double salary)
             : base(age, name, workExperience, salary)
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(43, "Михалыч", 25, 30000);

            Salesman salesman1 = new Salesman(20, "Василий", 2, 1000);
            Salesman salesman2 = new Salesman(33, "Потап", 3, 1500);
            Salesman salesman3 = new Salesman(25, "Настя", 4, 2000);

            director.AddSalesman(salesman1);
            director.AddSalesman(salesman2);
            director.AddSalesman(salesman3);

            salesman1.ShowEmployeeInfo();
            salesman2.ShowEmployeeInfo();
            salesman3.ShowEmployeeInfo();

            Console.WriteLine(new string('-', 50));
            salesman1.Salary = 2500;
            salesman2.Salary = 3000;
            salesman3.Salary = 5000;

            Console.WriteLine(new string('-', 50));
            salesman1.ShowEmployeeInfo();
            salesman2.ShowEmployeeInfo();
            salesman3.ShowEmployeeInfo();

            Console.ReadLine();
        }
    }
}
