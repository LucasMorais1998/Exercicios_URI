using System;

namespace _1173.Preenchimento_de_Vetor_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[10];

            int V = int.Parse(Console.ReadLine());

            if (V <= 50)
            {
                for (int i = 0; i < N.Length; i++)
                {
                    N[i] = V;
                    V += V;
                    Console.WriteLine("N[" + i + "] = " + N[i]);
                }
            }
        }
    }
}
