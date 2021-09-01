using System;
using System.Globalization;

namespace _1178.Preenchimento_de_Vetor_III
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] N = new decimal[100];

            decimal Aux = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            N[0] = Aux;


            //for (int i = 0 + 1; i < N.Length; i++)
            //{

            //    N[i] = N[i - 1] / 2.0;

            //}

            for (int i = 1; i < 100; i++)
            {
                Aux = (Aux / 2);
                N[i] = Aux;
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("N[" + i + "] = " + N[i].ToString("F4", CultureInfo.InvariantCulture));
            }

        }
    }
}
