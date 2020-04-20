using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_HW02
{
    //Создайте класс Dictionary с функциональностью словаря на 5 слов.Используйте 2 массива в теле Dictionary.
    //Реализуйте обращение к словарю в методе Main. Реализуйте возможность заполнения словаря. Используйте индексаторы.
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            dictionary["ключ"] = "key";
            dictionary["машина"] = "car";
            dictionary["яблоко"] = "apple";
            dictionary["корабль"] = "Ship";
            dictionary["самолет"] = "Plane";


            for (int i = 0; i < dictionary.Length; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadLine();
        }
    }
}
