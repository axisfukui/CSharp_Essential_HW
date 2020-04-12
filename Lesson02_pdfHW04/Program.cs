using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_pdfHW04
{
    //Требуется:
    //Создать класс Invoice.
    //В теле класса создать три поля int account, string customer, string provider, которые должны
    //быть проинициализированы один раз(при создании экземпляра данного класса) без возможности их
    //дальнейшего изменения.
    //В теле класса создать два закрытых поля string article, int quantity
    //Создать метод расчета стоимости заказа с НДС и без НДС.
    //Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        private double nds = 0.195; //19.5%

        private int quantity;

        public double Tax { get { return nds; } }
        public string Article { get; set; }
        public double Price { get; set; }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0) quantity = value;
                else quantity = 1;
            }

        }

        public int Account { get; }
        public string Customer { get; }
        public string Provider { get; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void GetCustomerInformation()
        {
            Console.WriteLine($"Клиент: {customer}\n" +
                $"Номер аккаунта:  {account}\n" +
                $"{new string('=', 50)}\n\n");
        }
        public void GetOrderPrice(bool withTax)
        {
            Console.WriteLine($"##### ЗАКАЗ #####\n" +
                $"Наименование продукта:    {Article}\n" +
                $"Колличество:  {Quantity}\n" +
                new string('-', 50) + "\n");

            double op = Price * Quantity; //order price calculation
            double tax = op * nds;
            double totalprice = op + tax;

            Console.WriteLine(withTax
                                    ? $"Общая стоимость:   {op} уе\n" +
                                        $"НДС (19,5%):  {tax} ye\n" +
                                        $"Сумма к оплате: {totalprice} ye\n"
                                    : $"Сумма к оплате (Без учета НДС): {op} ye\n");

            Console.WriteLine(new string('#', 50));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(new Random().Next(100000, 999999), "Boozer", "Красное Белое");

            invoice.GetCustomerInformation();
            invoice.Article = "Винишко \"Яблочный Рай\"";
            invoice.Price = 399.99;
            invoice.Quantity = 10;

            invoice.GetOrderPrice(true);

            Console.WriteLine();
            invoice.Article = "Коньяк 5* \"От Бабы Дуни\"";
            invoice.Price = 49.99;
            invoice.Quantity = 10;
            invoice.GetOrderPrice(false);

            Console.ReadLine();
        }
    }
}
