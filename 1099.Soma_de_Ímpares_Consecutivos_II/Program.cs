using System;

namespace _1099.Soma_de_Ímpares_Consecutivos_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int Impares = 0;

            for (int i = 0; i < N; i++)
            {
                string[] Entrada = Console.ReadLine().Split(' ');

                int X = int.Parse(Entrada[0]); // 12
                int Y = int.Parse(Entrada[1]); // 29

                if (Y > X)
                {
                    int Aux = X; // Aux = 12
                    X = Y; // X = 29
                    Y = Aux; // Y = 12                                        
                }

                for (int Contador = Y + 1; Contador < X; Contador++)
                {
                    if (Contador % 2 != 0)
                    {
                        Impares = Impares + Contador;
                    }

                }
                Console.WriteLine(Impares);
                Impares = 0;

            }    
        }
    }
}
