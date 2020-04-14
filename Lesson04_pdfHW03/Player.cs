using System;

namespace Lesson04_pdfHW03
{
    class Player : IPlayable, IRecordable
    {
        public void Record()
        {
            Console.WriteLine("Запись началась");
        }
        public void Play()
        {
            Console.WriteLine("Воспроизведение началось");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Запись приостановлена");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Воспроизведение приостановлено");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Запись прекращена");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Воспроизведение прекращено");
        }
    }
}
