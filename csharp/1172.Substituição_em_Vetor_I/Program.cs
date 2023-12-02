using System;

namespace _1172.Substituição_em_Vetor_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] X = new int[10];

            for (int i = 0; i < 10; i++)
            {
                X[i] = int.Parse(Console.ReadLine());

                if (X[i] <= 0)
                {
                    X[i] = 1;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("X[" + i + "] = " + X[i]);
            }
        }
    }
}
