using System;

namespace _1175.Troca_em_Vetor_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[20];

            for (int i = 0; i < 20; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(N);

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("N[" + i + "] = " + N[i]);
            }
        }
    }
}
