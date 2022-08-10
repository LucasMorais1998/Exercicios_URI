using System;

namespace _1143.Quadrado_e_ao_Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i + " " + (i * i) + " " + Math.Pow(i, 3));
            }
        }
    }
}
