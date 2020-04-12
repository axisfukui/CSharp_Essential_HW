using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_LW01
{
    //Создайте класс Employee.В теле класса создайте поля age, name, workExperience, salary (поля должны быть доступны только для наследников класса). 
    //В теле класса Employee создайте метод ShowEmployeeInFo(), выводящий информацию о сотруднике на экран, создайте пользовательский конструктор, 
    //принимающий значения для инициализации полей.
    //Создайте метод SetSalary(), устанавливающий новую зарплату.
    //Создайте производные от Employee классы Director и Salesman. 
    //
    //В теле класса Director создайте закрытое поле subordinate, типа массива из элементов Salesman.
    //Создайте метод, с помощью которого можно добавлять подчиненного в массив.
    //Создайте метод, с помощью которого можно удалять (занулять) подчиненного в массиве. 
    //Создайте метод, с помощью которого можно получать доступ к сотруднику в массиве.
    //В теле класса Salesman создайте поле типа Director.
    //В методе Main создайте один экземпляр класса Director и три экземпляра класса Salesman.Добавьте подчиненных директору в массив.
    //Выведите на экран данные по всем сотрудникам.Поменяйте зарплату всем сотрудникам. Выведите на экран новые данные по сотрудникам.
    class Employee
    {
        protected int age;
        protected string name;
        protected int workExperience;
        protected double salary;
        public Employee()
        {

        }
        public Employee(string name, int age, int workExperience, double salary)
        {
            this.name = name;
            this.age = age;
            this.workExperience = workExperience;
            this.salary = salary;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"{name} | {age}  | {workExperience}  |  {salary}");
        }
    }
    class Salesman : Employee
    {
        private Director director;
        public Director Director
        {
            get { return director; }
            set { director = value; }
        }

        public Salesman(string name, int age, int workExperience, int salary)
            : base(name, age, workExperience, salary)
        {

        }
    }
    class Director : Employee
    {
        public Director()
        {

        }

        Salesman[] subordinate = new Salesman[3];

        public void AddEmployee(Salesman salesman)
        {
            int count = 0;
            while (count < subordinate.Length && subordinate[count] != null) { count++; }

            if (count < subordinate.Length)
                subordinate[count] = salesman;
            else
            {
                Salesman[] tempsl = new Salesman[subordinate.Length];
                tempsl = subordinate;
                subordinate = new Salesman[count + 1];

                for (int i = 0; i < subordinate.Length; i++)
                {
                    if (i < tempsl.Length)
                        subordinate[i] = tempsl[i];
                    else
                    {
                        subordinate[i] = salesman;
                        break;
                    }
                }
            }
        }

        public void RemoveEmployee()
        {

        }
        public new void ShowEmployeeInfo()
        {
            for (int i = 0; i < subordinate.Length; i++)
            {
                subordinate[i].ShowEmployeeInfo();
            }
        }
        public void ShowEmployeeInfo(int idx)
        {
            if (idx < subordinate.Length)
                subordinate[idx]?.ShowEmployeeInfo();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Salesman salesman1 = new Salesman("Vanja", 15, 5, 2000);
            Salesman salesman2 = new Salesman("Vika", 13, 7, 4000);
            Salesman salesman3 = new Salesman("Vadik", 17, 3, 9000);

            director.AddEmployee(salesman1);
            director.AddEmployee(salesman2);
            director.AddEmployee(salesman3);
            director.ShowEmployeeInfo();

            Console.WriteLine("\n\n");


            salesman1.SetSalary(2222);
            salesman2.SetSalary(4444);
            salesman3.SetSalary(9999);

            director.ShowEmployeeInfo();

            Console.ReadLine();

        }
    }
}
