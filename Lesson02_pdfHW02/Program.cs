using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_pdfHW02
{
    //Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Converter.
    //В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
    //и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
    //Converter(double usd, double eur, double rub).
    //Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
    //также программа должна производить конвертацию из указанных валют в гривну.

    class Converter
    {
        public enum Currency
        {
            eur = 1,
            usd,
            rub
        }
        private double usd, eur, rub;

        public double USD
        {
            get
            {
                return usd;
            }
            private set
            {
                if (value > 0) usd = value;
            }

        }
        public double EUR
        {
            get
            {
                return eur;
            }
            private set
            {
                if (value > 0) eur = value;
            }

        }
        public double RUB
        {
            get
            {
                return rub;
            }
            private set
            {
                if (value > 0) rub = value;
            }

        }

        public Converter(double usd, double eur, double rub)
        {
            this.USD = usd;
            this.EUR = eur;
            this.RUB = rub;
        }

        public double ConvertTo(double value, Currency currency)
        {
            double cur = 1;

            switch (currency)
            {
                case Currency.eur:
                    cur = eur;
                    break;
                case Currency.usd:
                    cur = usd;
                    break;
                case Currency.rub:
                    cur = rub;
                    break;
            }

            return value / cur;
        }
        public double ConvertFrom(double value, Currency currency)
        {
            double cur = 1;

            switch (currency)
            {
                case Currency.eur:
                    cur = eur;
                    break;
                case Currency.usd:
                    cur = usd;
                    break;
                case Currency.rub:
                    cur = rub;
                    break;
            }

            return value * cur;
        }
        //public double ToUsd(double value)
        //{
        //    return value / usd;
        //}
        //public double ToEur(double value)
        //{
        //    return value / eur;
        //}
        //public double ToRub(double value)
        //{
        //    return value / rub;
        //}

        //public double FromUsd(double value)
        //{
        //    return value * usd;
        //}
        //public double FromEur(double value)
        //{
        //    return value * eur;
        //}
        //public double FromRub(double value)
        //{
        //    return value * rub;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(27.30, 29.84, 0.37);

            double amount = 0.0;
            while (true)
            {
                Console.WriteLine("Выбор валюты [1: EUR | 2: USD | 3: RUB]:");
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine("[1] Для конвертации из валюты в гривну\n[2] Для конвертации из гривны в валюту");
                int n = int.Parse(Console.ReadLine());

                double cash = double.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1://ConvertFrom
                        Console.WriteLine("Сумма составит {0} гривен", converter.ConvertFrom(cash, (Converter.Currency)c));
                        break;
                    case 2://ConvertTo
                        amount = converter.ConvertTo(cash, (Converter.Currency)c);
                        Console.WriteLine("Сумма составила {0} {1}", amount, (Converter.Currency)c);
                        break;
                    default:
                        return;
                }

            }

        }
    }
}
