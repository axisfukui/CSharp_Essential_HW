using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_LW0102
{
    //Создайте абстрактный класс Computer.Создайте в нем поля int length, string processor, string memory.
    //Создайте интерфейсы IPhone, IVidioPayer, IEditor,
    //Создайте производные классы Smartphone,

    abstract class Computer
    {
        public int Length { get; private set; }
        public string Processor { get; private set; }
        public string Memory { get; private set; }
    }
    interface ISmarpphon
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
