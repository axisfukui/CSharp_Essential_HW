using System;

namespace Lesson04_pdfHW02
{
    class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("XMLHandler chenge method");
        }

        public override void Create()
        {
            Console.WriteLine("XMLHandler create method");
        }

        public override void Open()
        {
            Console.WriteLine("XMLHandler open method");
        }

        public override void Save()
        {
            Console.WriteLine("XMLHandler save method");
        }
    }
}
