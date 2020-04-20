using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_HW04
{
    //В классе содержится одномерный private массив элементов целого типа.
    //Создать индексатор, который при обращении к элементам массива не дает выйти за границу массива.
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MyClass
    {
        private int[] array = new int[4];

        public int this[int index]
        {
            get
            {
                if (index > -1 && index < array.Length)
                    return array[index];

                Console.WriteLine("Выход за границы массива");
                return 0;
            }
            set
            {
                if (index > -1 && index < array.Length)
                    array[index] = value;
            }
        }
    }
}
