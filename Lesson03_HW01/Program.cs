using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_HW01
{
    //Создайте класс Animal с полем public типа Type с именем objectType, с методом Move(), выводящим на экран консоли текст «Я {0} - двигаюсь». 
    //Проинициализируйте в методе локальную переменную с именем objectType значением this.GetTupe() . 
    //В форматированный вывод подставьте objectType.
    //Создайте производный от Animal класс Chordate и создайте в нем метод Move(), выводящий на экран – «Я {0}, двигаюсь в воде».
    //Создайте производный от Chordate класс Vertebrata и создайте в нем метод Move(), выводящий на экран – «Я {0} двигаюсь в воде быстро». 
    //objectType аналогично Animal
    //Создайте производный от Vertebrata класс Primata и создайте в нем метод Move(), выводящий на экран – «Я {0} двигаюсь по земле ногами». 
    //objectType аналогично Animal
    //Создайте производный от Primata класс Human и создайте в нем метод Move(), выводящий на экран – «Я {0} двигаюсь по земле на двух ногах». 
    //objectType аналогично Animal
    //В методе Main создайте экземпляр Human.Вызовите на нем Move(), проапкастите его, вызовите Move и так до Animal.
    //Потом продаункастите последовательно объект до Human, снова вызывая на нем метод Move().

    class Animal
    {
        public Type objectType;
        public Animal()
        {
            objectType = this.GetType();
        }
        public void Move()
        {
            Console.WriteLine("Я {0} двигаюсь", objectType);
        }

    }
    class Chordate : Animal
    {
        public new void Move()
        {
            Console.WriteLine("Я {0} двигаюсь в воде", objectType);
        }
    }
    class Vertebrata : Chordate
    {
        public new void Move()
        {
            Console.WriteLine("Я {0} двигаюсь в воде быстро", objectType);
        }

    }
    class Primata : Vertebrata
    {
        public new void Move()
        {
            Console.WriteLine("Я {0} двигаюсь по земле ногами", objectType);
        }

    }
    class Human : Primata
    {
        public new void Move()
        {
            Console.WriteLine("Я {0} двигаюсь по земле на двух ногах", objectType);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Move();

            Primata primata = human as Primata;
            primata?.Move();

            Vertebrata vertebrata = primata as Vertebrata;
            vertebrata?.Move();

            Chordate chordate = vertebrata as Chordate;
            chordate?.Move();

            Animal animal = chordate as Animal;
            animal?.Move();

            chordate = animal as Chordate;
            chordate?.Move();

            vertebrata = chordate as Vertebrata;
            vertebrata?.Move();

            primata = vertebrata as Primata;
            primata?.Move();

            human = primata as Human;
            human?.Move();

            Console.ReadLine();
        }
    }
}
