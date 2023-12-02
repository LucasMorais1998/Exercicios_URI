using System;
using System.Globalization;

namespace _1036.Fórmula_de_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            double A = double.Parse(num[0]);
            double B = double.Parse(num[1]);
            double C = double.Parse(num[2]);

            double delta = Math.Pow(B, 2) - (4 * A * C);
            double raizDelta = Math.Sqrt(delta);
            double X1 = (-B + raizDelta) / (2 * A);
            double X2 = (-B - raizDelta) / (2 * A);

            if ((delta >= 0) && (A != 0))
            {
                Console.WriteLine("R1 = " + X1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + X2.ToString("F5", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

        }
    }
}
