using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson03_pdfHW04.Workers;

namespace Lesson03_pdfHW04
{
    //Создайте класс DocumentWorker.
    //В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
    //В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
    //"Редактирование документа доступно в версии Про", "Сохранение документа доступно в
    //версии Про".
    //Создайте производный класс ProDocumentWorker.
    //Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
    //"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных
    //форматах доступно в версии Эксперт".
    //Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
    //Переопределите соответствующий метод.При вызове данного метода необходимо выводить на экран
    //"Документ сохранен в новом формате".
    //В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
    //Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается
    //экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен
    //создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker worker;
            bool isExecuting = true;
            while(isExecuting)
            {
                Console.WriteLine("Введите ключи доступа:");
                string key = Console.ReadLine();

                switch (key)
                {
                    case "AAA-123-456-789":
                        worker = new ProDocumentWorker();
                        break;
                    case "ZZZ-147-258-369":
                        worker = new ExpertDocumentWorker();
                        break;
                    default:
                        worker = new DocumentWorker();
                        break;
                }

                switch (key)
                {
                    case "q":
                        isExecuting = false;
                        Console.WriteLine("Произведен выход из программы");
                        continue;

                }
                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();

                Console.WriteLine(new string('-',50)+"\n");
            }
            Console.ReadLine();
        }
    }
}
