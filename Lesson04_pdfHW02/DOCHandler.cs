using System;

namespace Lesson04_pdfHW02
{
    class DOCHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("DOCHandler chenge method");
        }

        public override void Create()
        {
            Console.WriteLine("DOCHandler create method");
        }

        public override void Open()
        {
            Console.WriteLine("DOCHandler open method");
        }

        public override void Save()
        {
            Console.WriteLine("DOCHandler save method");
        }
    }
}
