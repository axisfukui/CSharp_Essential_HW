using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_pdfHW02
{
    //Создать класс, представляющий учебный класс ClassRoom.
    //Создайте класс ученик Pupil.В теле класса создайте методы void Study(), void Read(), void
    //Write(), void Relax().
    //Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса
    //Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
    //Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
    //Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
    //Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
    //писать, отдыхать.
    class ClassRoom
    {
        Pupil[] pupils;
        public ClassRoom(Pupil pupil1, Pupil pupil2)
            : this(pupil1, pupil2, null, null)
        {

        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
           : this(pupil1, pupil2, pupil3, null)
        {

        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils = new Pupil[] { pupil1, pupil2, pupil3, pupil4 };
        }
        public void GetPupilInformation()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i]?.Study();
                pupils[i]?.Write();
                pupils[i]?.Read();
                pupils[i]?.Relax();
                Console.WriteLine(new string('-',50));
            }
        }
    }
    class Pupil
    {
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }
    class ExcelentPupil : Pupil
    {
        public override void Study() { Console.WriteLine("ExcelentPupil Study"); }
        public override void Read() { Console.WriteLine("ExcelentPupil Read"); }
        public override void Write() { Console.WriteLine("ExcelentPupil Write"); }
        public override void Relax() { Console.WriteLine("ExcelentPupil Relax"); }
    }
    class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine("GoodPupil Study"); }
        public override void Read() { Console.WriteLine("GoodPupil Read"); }
        public override void Write() { Console.WriteLine("GoodPupil Write"); }
        public override void Relax() { Console.WriteLine("GoodPupil Relax"); }
    }
    class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("BadPupil Study"); }
        public override void Read() { Console.WriteLine("BadPupil Read"); }
        public override void Write() { Console.WriteLine("BadPupil Write"); }
        public override void Relax() { Console.WriteLine("BadPupil Relax"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());

            classRoom.GetPupilInformation();

            Console.ReadLine();
        }
    }
}
