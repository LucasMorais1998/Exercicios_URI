using System;

namespace _1164.Número_Perfeito
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int perfeito = 0;

            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                for (int cont = 1; cont < X; cont++)
                {
                    if (X % cont  == 0)
                    {
                        perfeito += cont;
                    }
                }

                if (perfeito == X)
                {
                    Console.WriteLine(X + " eh perfeito");
                }
                else
                {
                    Console.WriteLine(X + " nao eh perfeito");
                }
                perfeito = 0;
            }

            
        }
    }
}
