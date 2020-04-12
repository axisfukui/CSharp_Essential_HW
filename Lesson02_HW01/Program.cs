using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_HW01
{
    //Создайте класс Web.В теле класса Web создайте строковое свойство WebColor со значением по умолчанию – «серый», 
    //создайте метод ChangeWebColor(), принимающий строки, обозначающие цвета и меняющие значение WebColor 
    //в соответствии с введенным пользователем значением.Создайте класс Spider.В теле класса Spider создайте поле типа Web, 
    //создайте метод ShowWeb() , принимающий значение типа char ‘r’, ‘b’, ‘w’, ‘y’. 
    //В зависимости от введенной буквы в этом методе должен вызываться метод ChangeWebColor() на поле Web, 
    //менять цвет на красный, голубой, белый или желтый.После этого в этом же методе ShowWeb() должен вызываться вывод на экран 
    //фразы «Паутина { 0}
    //цвета». Причем текст должен быть именно таким цветом, какой будет храниться в Web.
    //После вывода на экран значения программа должна ожидать следующего нажатия ‘r’, ‘b’, ‘w’, ‘y’ или ‘q’ – выход.
    //В методе Main создайте экземпляр Spider и вызовите метод ShowWeb().

    class Web
    {
        public string WebColor { get; set; }
        public Web()
        {
            WebColor = "серый";
        }

        public void ChaneWebColor(string color)
        {
            WebColor = color;
        }
    }
    class Spider
    {
        Web web = new Web();

        public void ShowWeb(char c)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;

            switch (c)
            {
                case 'r':
                    web.ChaneWebColor("красного");
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 'b':
                    web.ChaneWebColor("синего");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 'w':
                    web.ChaneWebColor("белого");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 'y':
                    web.ChaneWebColor("желтого");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.WriteLine("Неверный цвет паутины");
                    return;
            }

            Console.WriteLine("Паутина {0} цвета", web.WebColor);
            Console.ForegroundColor = defaultColor;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Spider spider = new Spider();
            Console.WriteLine("Выберите цвет (r,b,w,y) паутины, для выхода нажмите q: ");
            while (true)
            {
                char c;
                bool isValid = Char.TryParse(Console.ReadLine(), out c);
                if (isValid)
                    spider.ShowWeb(c);

                switch (c)
                {
                    case 'q':
                        return;
                }
            }
        }
    }
}
