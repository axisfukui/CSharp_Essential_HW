using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_pdfHW03
{
    //Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Book.Создать классы Title, Author и Content, каждый из которых должен содержать
    //одно строковое поле и метод void Show().
    //Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
    //Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
    //содержание.

    class Title
    {
        private string title;
        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine("Название: " + title);
        }
    }
    class Author
    {
        private string author;
        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine("Автор: " + author);
        }
    }
    class Content
    {
        private string content;
        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine("Содержание: " + content);
        }
    }
    class Book
    {
        Title title;
        Author author;
        Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);

        }

        public void Show(ConsoleColor c1, ConsoleColor c2, ConsoleColor c3)
        {

            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = c1;
            title.Show();
            Console.ForegroundColor = c2;
            author.Show();
            Console.ForegroundColor = c3;
            content.Show();
            Console.ForegroundColor = c;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Та что изменила жизнь", "Василий Потапович Корявый", "Он молодой, неопытный. Она красива и сияет. Она наполняет его жизнь светом, Он хочет ее. Но скушать не суждено. НеГруша и Идиот, жизнь накажет обоих.");
            book.Show(ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Green);

            Console.ReadLine();

        }
    }
}
