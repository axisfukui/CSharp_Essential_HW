using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_FirstCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStringCollection collection = new MyStringCollection();
            collection.Add("Test");
            collection.Add("Octoberfest");
            collection.Add("Wurst");
            collection.Add("Wind");

            collection.Enumerate();

            collection.Add("Wetter");
            collection.Add("Leben");

            for (int i = 0; i < collection.Length; i++)
            {
                Console.Write($"{collection[i]} ");
            }

            Console.ReadLine();
        }
    }

    class MyStringCollection
    {
        private int count;
        private string[] strArray = new string[4];

        public void Add (string value)
        {
            if (count == strArray.Length)
                Resize();
            strArray[count++] = value;
        }

        public int Length { get { return count; } }
        public string this[int index]
        {
            get { return strArray[index]; }
            set { strArray[index] = value; }
        }
        private void Resize()
        {
            string[] temp = new string[strArray.Length * 2];
            for (int i = 0; i < count; i++)
            {
                temp[i] = strArray[i];
            }

            strArray = temp;
        }
        public void Enumerate ()
        {
            Console.WriteLine("Элементы коллекции: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(strArray[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
