using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_pdfHW02
{
    //Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
    //Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения.
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Введите размер массива в виде целого числа: ");
                if(!int.TryParse(Console.ReadLine(), out int size))
                {
                    Console.WriteLine("Неверный ввод.");
                    continue;
                }
            
                MyMassive myMassive = new MyMassive(size);
                for (int i = 0; i < myMassive.Length; i++)
                {
                    Console.Write(myMassive[i].ToString("0.00")+" ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-',80));
                Console.WriteLine("Max Value: " + myMassive.GetMaxValue().ToString("0.00"));
                Console.WriteLine("Min Value: " + myMassive.GetMinValue().ToString("0.00"));
                Console.WriteLine("Total Sum: " + myMassive.GetTotalSum().ToString("0.00"));
                Console.WriteLine("Arithmetic Mean: " + myMassive.GetArithmeticMean().ToString("0.00"));
            }
        }
    }
    interface IMyMassive
    {
        double GetMaxValue();
        double GetMinValue();
        double GetTotalSum();
        double GetArithmeticMean();


    }
    class MyMassive : IMyMassive
    {
        private double[] array;
        public int Length { get { return array.Length; } }
        public MyMassive(int size)
        {
            array = new double[size];
            SetRandomValues();
        }

        private void SetRandomValues()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(random.Next(-100, 100)) + random.NextDouble();
            }
        }
        public double GetMaxValue()
        {
            double maxV = 0;
            for (int i = 0; i < array.Length; i++)
            {
                maxV = maxV >= array[i] ? maxV : array[i];
            }
            return maxV;
        }

        public double GetMinValue()
        {
            double minV = 0;
            for (int i = 0; i < array.Length; i++)
            {
                minV = minV <= array[i] ? minV : array[i];
            }
            return minV;
        }

        public double GetTotalSum()
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public double GetArithmeticMean()
        {
            return GetTotalSum() / array.Length;
        }

        public double this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
