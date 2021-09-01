using System;

namespace _1159.Soma_de_Pares_Consecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 1;
            int contAux = 1;
            int pares = 0;

            while (X != 0)
            {
                X = int.Parse(Console.ReadLine());

                for (int i = X; contAux < 6; i++)
                {
                    if (i % 2 == 0)
                    {
                        pares += i;
                        contAux++;
                    }
                }

                if (X != 0)
                {
                    Console.WriteLine(pares);
                    pares = 0;
                    contAux = 1;
                }
            }

        }
    }
}
