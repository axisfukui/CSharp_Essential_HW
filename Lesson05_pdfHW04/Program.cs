using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_pdfHW04
{
    //Создать класс Article, содержащий следующие закрытые поля:
    //• название товара;
    //• название магазина, в котором продается товар;
    //• стоимость товара в гривнах.
    //Создать класс Store, содержащий закрытый массив элементов типа Article.
    //Обеспечить следующие возможности:
    //• вывод информации о товаре по номеру с помощью индекса;
    //• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров
    //нет, выдать соответствующее сообщение;
    //Написать программу, вывода на экран информацию о товаре.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####### FIRST STORE #######");
            Store babushkasStore = new Store("У Бабы Нюры");
            babushkasStore.AddItem("Самогон из Початка", 250);
            babushkasStore.AddItem("Шоколадка \"Сладкий закусон\"", 400);
            babushkasStore.AddItem("Успокоительное \"Семечки\"", 50);

            babushkasStore.GetArticleInformation();

            Console.WriteLine("\n####### SECOND STORE #######");

            Store eliteVillage = new Store("Деревенский уголок", new Article("Клубная дубинка", 100),
                                                                new Article("Макасины Скороходы", 300),
                                                                new Article("Ядерная Сивуха", 400),
                                                                new Article("Лопата", 150),
                                                                new Article("Седло Семейное", 1500),
                                                                new Article("Телега Мазерати", 2500),
                                                                new Article("Спиннер", 5000));
            bool quitStore = false;
            while (!quitStore)
            {
                Console.WriteLine($"Введите Номер товара 1-{eliteVillage.Length} или название товара. Оставьте поле пустым чтобы вывести весь список товаров" );
                string str = Console.ReadLine();

                bool isNum = int.TryParse(str, out int n);

                --n;
                if (isNum)
                {

                    Console.WriteLine($"{eliteVillage[n]?.StoreName}: {eliteVillage[n]?.Title} - {eliteVillage[n]?.Price}");
                    continue;
                }
                else if (eliteVillage[str]!= null)
                {
                    Console.WriteLine($"{eliteVillage[str]?.StoreName}: {eliteVillage[str]?.Title} - {eliteVillage[str]?.Price}");

                    continue;
                }
                Console.WriteLine();
                switch (str)
                {
                    case "quit":
                        quitStore = true; continue;
                    default:
                        eliteVillage.GetArticleInformation();
                        break;
                }



            }
            eliteVillage.RemoveItem(0);
            eliteVillage.GetArticleInformation();
            //Console.WriteLine(eliteVillage["Самогон из Початка"]);
            Console.ReadLine();
        }
    }
}
