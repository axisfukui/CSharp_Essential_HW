using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_pdfHW_extra
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Требуется:
        //Создать класс с именем Address.
        //В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого
        //поля, создать свойство с двумя методами доступа.
        //Создать экземпляр класса Address.
        //В поля экземпляра записать информацию о почтовом адресе.
        //Выведите на экран значения полей, описывающих адрес.
        static void Main(string[] args)
        {
            Address adr = new Address();

            adr.Index = "33659";
            adr.Country = "VNIGDELAND";
            adr.City = "Vnikudatown";
            adr.Street = "Tamgdesobakazarita Street";
            adr.House = "13";
            adr.Appartment = "31";

            Console.WriteLine("Address: {0} {1} {2}, {3} {4}/{5} ", adr.Country, adr.Index, adr.City, adr.Street, adr.House, adr.Appartment);
            Console.ReadLine();
        }
    }

    class Address
    {
        private string index, country, city, street, house, appartment;

        public string Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string House
        {
            get { return house; }
            set { house = value; }
        }
        public string Appartment
        {
            get { return appartment; }
            set { appartment = value; }
        }

    }
}
