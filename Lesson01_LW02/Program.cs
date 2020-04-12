using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_LW02
{
    //Создайте класс Book отдельным файлом.В классе Book создайте поля author, bookName. 
    //Создайте свойства для доступа к этим полям.
    //Создайте класс Library отдельным файлом.В теле Library создайте приватное поле типа Book.
    //В Library создайте пользовательский конструктор, создающий некую книгу по умолчанию.
    //В теле метода Main создайте два экземпляра класса Library   - с использованием конструктора по умолчанию и 
    //с использованием пользовательского конструктора. Выведите на экран данные по содержащимся в библиотеках книгам.

    class Program
    {
        static void Main(string[] args)
        {
            Library library1 = new Library();
            Library library2 = new Library("Garson DeJavue Pegeon", "Wie melkt man eine Schnecke");

            Console.WriteLine("Автор {0}    |   Название: {1}", library1.Book.Author, library1.Book.BookName);
            Console.WriteLine("Автор {0}    |   Название: {1}", library2.Book.Author, library2.Book.BookName);

            Console.ReadLine();
        }
    }
}
