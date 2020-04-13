using System;


namespace Lesson03_pdfHW03
{
    class Vehicle
    {
        readonly int productionYear;
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int Speed { get; set; }
        public int Price { get; set; }

        public Vehicle()
        {
            productionYear = DateTime.Now.Year-(new Random().Next(100));
            
        }

        public virtual void GetInformation()
        {
            Console.WriteLine($"Год производства: {productionYear}\n" +
                $"Скорость: {Speed} \n" +
                $"Цена: {Price} \n" +
                $"Координаты: {CoordinateX}/{CoordinateY}");
        }
    }
}
