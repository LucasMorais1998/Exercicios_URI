using System;

namespace _1101.Sequência_de_Números_e_Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 1;
            int N = 1;

            while (M > 0 && N > 0)
            {
                string[] Entrada = Console.ReadLine().Split(' ');

                 M = int.Parse(Entrada[0]); // 20
                 N = int.Parse(Entrada[1]); // 40

                int Soma = 0;

                if (N > M) // 40 > 20
                {
                    int Aux = M; // aux = 20
                    M = N; // M = 40
                    N = Aux; // N = 20
                }

                if (M > 0 && N > 0)
                {
                    for (int i = N; i <= M; i++)
                    {
                        Soma += i;
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("Sum=" + Soma);
                }
            }







        }
    }
}
