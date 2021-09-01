using System;

namespace _1164.Número_Perfeito
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int resto = 0;

            for (int i = 1; i <= N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X % i != 0)
                {
                    resto = X;
                }
                else
                {
                    Console.WriteLine($"", X + " nao eh perfeito");
                }
            }
        }
    }
}
