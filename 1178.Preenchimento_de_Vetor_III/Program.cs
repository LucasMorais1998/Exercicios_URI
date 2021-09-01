using System;
using System.Globalization;

namespace _1178.Preenchimento_de_Vetor_III
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] N = new double[100];

            double X = double.Parse(Console.ReadLine());

            N[0] = X;

            for (int i = 1; i < N.Length; i++)
            {
                N[i] = N[i - 1] / 2.0;
                Console.WriteLine(N[i].ToString("F4", CultureInfo.InvariantCulture));
            }

        }
    }
}
