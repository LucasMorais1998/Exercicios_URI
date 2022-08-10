using System;

namespace _3302.Resposta_Certa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                vet[i] = x;
            }

            int loop = 0;
            int aux = N;
            N = loop;
            loop = aux;

            while (loop > N)
            {
                N++;
                Console.WriteLine("resposta " + N + ": " + vet[N - 1]);
            }


        }

    }
}
