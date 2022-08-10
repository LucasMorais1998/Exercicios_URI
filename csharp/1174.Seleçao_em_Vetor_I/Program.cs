using System;
using System.Globalization;

namespace _1174.Seleçao_em_Vetor_I
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[10];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = double.Parse(Console.ReadLine());

                
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 10.0)
                {
                    Console.WriteLine("A[" + i + "] = " + A[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
