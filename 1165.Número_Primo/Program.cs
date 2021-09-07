using System;

namespace _1165.Número_Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int X;

            for (int i = 0; i < N; i++)
            {
                int cont = 0;
                X = int.Parse(Console.ReadLine());

                for (int j = 2; j < X; j++)
                {
                    if (X % j == 0)
                    {
                        cont++;
                    }             
                }

                if (cont == 0)
                {
                    Console.WriteLine(X + " eh primo");
                }
                else
                {
                    Console.WriteLine(X + " nao eh primo");
                }

            }

            
        }
    }
}
