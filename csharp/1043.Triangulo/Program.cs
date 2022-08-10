using System;
using System.Globalization;

namespace _1043.Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tri = Console.ReadLine().Split(' ');

            double A = double.Parse((tri[0]), CultureInfo.InvariantCulture);
            double B = double.Parse((tri[1]), CultureInfo.InvariantCulture);
            double C = double.Parse((tri[2]), CultureInfo.InvariantCulture);

            if ((C < A + B) && (B < A + C) && (A < B + C))
            {
                double perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double trapezio = (A + B) * C / 2.0;
                Console.WriteLine("Area = " + trapezio.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
