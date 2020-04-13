using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_pdfHW03
{
    //Требуется:
    //Создать класс Vehicle.
    //В теле класса создайте поля: координаты и параметры средств передвижения(цена, скорость, год
    //выпуска).
    //Создайте 3 производных класса Plane, Саг и Ship.
    //Для класса Plane должна быть определена высота и количество пассажиров.
    //Для класса Ship — количество пассажиров и порт приписки.
    //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles.Car car = new Vehicles.Car();
            car.CoordinateX = 152;
            car.CoordinateY = 84;
            car.Price = 3000;
            car.Speed = 200;

            Vehicles.Plane plane = new Vehicles.Plane();
            plane.CoordinateX = 74;
            plane.CoordinateY = 162;
            plane.Price = 100000;
            plane.Speed = 900;
            plane.Altitude = 10000;
            plane.PassangerCapacity = 270;

            Vehicles.Ship ship = new Vehicles.Ship();
            ship.CoordinateX = 94;
            ship.CoordinateY = 196;
            ship.Price = 400000;
            ship.Speed = 300;
            ship.Port = "Puerto de La Cruz";
            ship.PassangerCapacity = 1000;

            GetVehicleInformation(car);
            GetVehicleInformation(plane);
            GetVehicleInformation(ship);

            Console.ReadLine();

        }
        public static void GetVehicleInformation(Vehicle vehicle)
        {
            vehicle?.GetInformation();

            System.Console.WriteLine(new string('-',50));
        }
    }
}
