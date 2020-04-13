using System;
//Создать класс, представляющий учебный класс ClassRoom.
//Создайте класс ученик Pupil.В теле класса создайте методы void Study(), void Read(), void
//Write(), void Relax().
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса
//Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
//писать, отдыхать.
namespace Lesson03_pdfHW02
{
    class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("BadPupil Study"); }
        public override void Read() { Console.WriteLine("BadPupil Read"); }
        public override void Write() { Console.WriteLine("BadPupil Write"); }
        public override void Relax() { Console.WriteLine("BadPupil Relax"); }
    }
}
