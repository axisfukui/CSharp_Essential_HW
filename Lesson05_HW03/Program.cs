using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_HW03
{
    //Создайте класс MyClass с двумерным private массивом massive.Создайте индексатор для доступа к массиву.Покажите реализацию
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myClass[i, j] = i * j;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(myClass[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
    class MyClass
    {
        private int[,] massive = new int[4, 4];

        public int this[int index, int index1]
        {
            get
            {
                if (index >= 0 && index1 >= 0)
                {
                    if (index < massive.GetLength(0) && index1 < massive.GetLength(1))
                    {
                        return massive[index, index1];

                    }

                }
                Console.WriteLine("Выход за пределы массива");
                return 0;
               
            }
            set { massive[index, index1] = value; }
        }
    }
}
