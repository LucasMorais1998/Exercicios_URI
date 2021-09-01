using System;

namespace _1019.Conversão_de_Tempo
{
    class Program
    {
        static void Main(string[] args)
        {

            int qntSeconds = int.Parse(Console.ReadLine());

            int hours = qntSeconds / 3600;
            int minutos = (qntSeconds % 3600) / 60;
            int seconds = (qntSeconds % 3600) % 60;

            Console.WriteLine(hours + ":" + minutos + ":" + seconds);
        }
    }
}
