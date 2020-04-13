using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_pdfHW03.Vehicles
{
    class Ship : Vehicle
    {
        public string Port { get; set; }
        public int PassangerCapacity { get; set; }
        public Ship()
            : base()
        {

        }
        public override void GetInformation()
        {
            Console.WriteLine($"Порт прописки:  {Port}\n" +
                $"Кол-во Пассажиров:    {PassangerCapacity}");
            base.GetInformation();
        }
    }
}
