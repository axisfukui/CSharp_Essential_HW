using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_pdfHW03
{
    //Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3
    //метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop()
    //соответственно.
    //Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
    //Написать программу, которая выполняет проигрывание и запись.
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Play();
            IPlayable player1 = player as IPlayable;
            player1?.Pause();
            player1?.Stop();
            Console.WriteLine(new string('-',80));
            player.Record();
            IRecordable recorder1 = player as IRecordable;
            recorder1.Pause();
            recorder1.Stop();

            Console.ReadLine();
            
        }
    }
}
