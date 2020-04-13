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
}
