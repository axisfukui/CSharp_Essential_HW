using System;

namespace Lesson04_pdfHW02
{
    class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("TXTHandler chenge method");
        }

        public override void Create()
        {
            Console.WriteLine("TXTHandler create method");
        }

        public override void Open()
        {
            Console.WriteLine("TXTHandler open method");
        }

        public override void Save()
        {
            Console.WriteLine("TXTHandler save method");
        }
    }
}
