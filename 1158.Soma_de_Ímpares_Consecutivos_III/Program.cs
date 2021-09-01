using System;

namespace _1158.Soma_de_Ímpares_Consecutivos_III
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());

            //int[] impares = new int[N];

            //for (int i = 0; i < N; i++)
            //{
            //    string[] Entrada = Console.ReadLine().Split(' ');

            //    int X = int.Parse(Entrada[0]);
            //    int Y = int.Parse(Entrada[1]);

            //    int contAux = 0;

            //    for (int k = X; contAux < Y; k++)
            //    {
            //        if (k % 2 == 1)
            //        {
            //            contAux++;
            //            impares[i] += k;
            //        }
            //    }
            //    Console.WriteLine(impares[i]);
            //}

            int N = int.Parse(Console.ReadLine());

            int impares = 0;

            for (int i = 0; i < N; i++)
            {
                string[] Entrada = Console.ReadLine().Split(' ');

                int X = int.Parse(Entrada[0]);
                int Y = int.Parse(Entrada[1]);

                int contAux = 0;

                for (int k = X; contAux < Y; k++)
                {
                    if (k % 2 != 0)
                    {
                        impares += k;
                        contAux++;
                    }
                }
                Console.WriteLine(impares);
                impares = 0;
            }



        }
    }
}
