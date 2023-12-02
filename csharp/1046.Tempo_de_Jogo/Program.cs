using System;

namespace _1046.Tempo_de_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int inicial = int.Parse((vet[0]));
            int final = int.Parse((vet[1]));

            int tempo;

            if (inicial > final)
            {
                tempo = 24 - (inicial - final);
            }
            else
            {
                if (final > inicial)
                {
                    tempo = final - inicial;
                }
                else
                {
                    tempo = 24;
                }
            }
            Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
        }
    }
}
