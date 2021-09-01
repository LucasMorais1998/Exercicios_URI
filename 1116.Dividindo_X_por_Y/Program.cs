using System;
using System.Globalization;

namespace _1116.Dividindo_X_por_Y
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] Entrada = Console.ReadLine().Split(' ');

                double X = double.Parse(Entrada[0]);
                double Y = double.Parse(Entrada[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine((X / Y).ToString("F1"));
                }
            }

        }
    }
}
