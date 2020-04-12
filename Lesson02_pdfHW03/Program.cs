using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_pdfHW03
{
    //Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Employee.
    //В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
    //инициализирует поля, соответствующие фамилии и имени сотрудника.
    //Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый
    //сбор.
    //Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность),
    //оклад и налоговый сбор.

    class Employee
    {
        private readonly double tax = 0.2;
        private string name;
        private string surname;
        private string position;

        public string Surname
        {
            get { return surname; }
            private set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public double GroundSalary { get; set; }
        public int Seniority { get; set; }
        public string Position
        {
            get { return position; }
            set
            {
                switch (value)
                {
                    case "Капитан":
                    case "Барабанщик":
                    case "Гребец":
                        position = value;
                        break;
                    default:
                        position = "Неверная должность";
                        break;
                }
            }
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Employee(string name, string surname, double tax)
            : this(name, surname)
        {
            this.tax = tax;
        }

        public void GetEmployeeInformation()
        {
            double multiplier = 1;
            switch (Position)
            {
                case "Капитан":
                    multiplier = 3 + (Seniority * 0.015); break;
                case "Барабанщик":
                    multiplier = 2 + (Seniority * 0.01); break;
                case "Гребец":
                    multiplier = Seniority * 0.05; break;
                default:
                    break;
            }

            double totalSalary = GroundSalary * multiplier;
            double taxToPay = totalSalary * tax;

            Console.WriteLine($"Имя: {Name} Фамилия: {Surname}\n" +
                $"Стаж: {Seniority} Должность: {Position}\n\n" +
                $"Общая Зарплата: {totalSalary}\n" +
                $"Налог к уплате: {taxToPay}\n" +
                $"{new string('-', 50)}\n" +
                $"Зарплата итого: {totalSalary - taxToPay}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Василий", "Конюшкин");
            emp1.Position = "Капитан";
            emp1.GroundSalary = 2000;
            emp1.Seniority = 10;

            emp1.GetEmployeeInformation();
            Console.ReadLine();

        }
    }
}
