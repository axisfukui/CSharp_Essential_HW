using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_pdfHW03.Vehicles
{
    class Plane : Vehicle
    {
        public int Altitude { get; set; }
        public int PassangerCapacity { get; set; }
        public Plane()
            :base()
        {
        }

        public override void GetInformation()
        {
            Console.WriteLine($"Высота полета:  {Altitude} \n" +
                $"Кол-во Пассажиров:    {PassangerCapacity}");
            base.GetInformation();
        }
    }
}
