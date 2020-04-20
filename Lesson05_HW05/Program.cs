using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_HW05
{
    //Создайте класс Dictionary с функциональностью предопределенного словаря на 5 слов.Используйте 2 массива в теле Dictionary.
    //Реализуйте обращение к словарю в методе Main.
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            Console.WriteLine(dictionary["самолет"]);

            Console.ReadLine();
        }
    }

    class Dictionary
    {
        private string[] key = { "самолет", "пиво", "хлеб", "сок", "яблоко" };
        private string[] value = { "plane", "beer", "bread", "juice", "apple" };

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return $"{key[i]} - {this.value[i]}";
                }
                return $"Пара к слову {index} не найдена";
            }
            set
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        this.value[i] = value;
                }
            }
        }
    }
}
