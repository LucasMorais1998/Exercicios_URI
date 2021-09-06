using System;

namespace _1149.Somando_Inteiros_Consecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada = Console.ReadLine().Split(' ');

            int A = int.Parse(Entrada[0]);
            int N = int.Parse(Entrada[1]);

            int Aux = 1;

            while (N <= 0)
            {
                Aux = Aux + 1;
                N = int.Parse(Entrada[Aux]);
            }

            //if (N <= 0)
            //{
            //    do
            //    {
            //        N = Int32.Parse(Console.ReadLine());
            //        Entrada[1] = N.ToString();

            //    } while (N <= 0);

            //}

            int cont = 0;

            for (int i = 0; i < N; i++)
            {

                cont = cont + (A + i);
            }
            Console.WriteLine(cont);



        }
    }
}
