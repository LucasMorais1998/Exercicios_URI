using System;
using System.Globalization;

namespace _1079.Médias_Ponderadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N ; i++)
            {
                double[] media = new double[N];

                string[] Num = Console.ReadLine().Split(' ');
                double A = double.Parse(Num[0], CultureInfo.InvariantCulture);
                double B = double.Parse(Num[1], CultureInfo.InvariantCulture);
                double C = double.Parse(Num[2], CultureInfo.InvariantCulture);

                media[i] = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10.0;

                Console.WriteLine(media[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
