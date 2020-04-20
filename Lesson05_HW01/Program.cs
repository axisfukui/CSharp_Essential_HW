using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_HW01
{
    //Создайте класс с массивом целочисленных значений помеченным private. 
    //В классе реализуйте индексатор, проверяющий, чтобы значения, помещаемые в массив, были в диапазоне от 0 до 100 включительно.
    //Реализуйте обращение к элементам в методе Main.
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass[0] = 1;
            myClass[1] = -1;
            myClass[2] = 99;
            myClass[3] = 120;


            Console.ReadLine();
        }
    }

    class MyClass
    {
        private int[] array = new int[4];

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    Console.WriteLine("Ошибка: Выход за приделы массива");
                return 0;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    array[index] = value;
                else
                    Console.WriteLine("Значение не входит в диапазон от 0 до 100 включительно. Значение не сохранено");
            }
        }
    }
}
