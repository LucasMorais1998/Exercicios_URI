using System;

namespace _1930.Tomadas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada = Console.ReadLine().Split(' ');
            int[] T = new int[4];
            int Result = 0;

            for (int i = 0; i < 4; i++)
            {
                T[i] = int.Parse(Entrada[i]);
                int Bocas = T[i];
                Result += Bocas;
            }
            Console.WriteLine(Result - (T.Length - 1));
        }
    }
}
