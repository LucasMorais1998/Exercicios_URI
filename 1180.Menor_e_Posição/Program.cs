using System;

namespace _1180.Menor_e_Posição
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] X = new int[N];

            int Menor = 0; // Startar com > num possivel ??
            int Posicao = 0;

            string[] Entrada = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                X[i] = int.Parse(Entrada[i]);

                //if (Posicao == 0) // Posição starta valendo 0 
                //{
                //    Menor = X[i];
                //    Posicao = i;
                //}
                //else
                //{
                    if (X[i] < Menor)
                    {
                        Menor = X[i];
                        Posicao = i;
                    }
                //}
            }

            Console.WriteLine("Menor valor: " + Menor);
            Console.WriteLine("Posicao: " + Posicao);
                     
        }
    }
}
