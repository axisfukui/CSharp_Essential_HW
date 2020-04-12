using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_pdfHW_extra
{
    //Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс User, содержащий информацию о пользователе(логин, имя, фамилия, возраст, дата
    //заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
    //(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
    //Реализуйте вывод на экран информации о пользователе.

    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private readonly DateTime registrationDate;

        public string Login { get { return login; } set { login = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } }
        public DateTime RegistrationDate { get { return registrationDate; } }

        public User()
        {
            registrationDate = DateTime.Now;
        }
        public User(string login, string name, string surname, int age)
            : this()
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("pupsik", "Anton", "Pertrov", 43);

            Console.WriteLine($"Логин: {user1.Login}    | Имя: {user1.Name} | Фамилия: {user1.Surname}  | Возраст: {user1.Age}\nДата заполнения Анкеты: {user1.RegistrationDate}");

            Console.ReadLine();

        }
    }
}
