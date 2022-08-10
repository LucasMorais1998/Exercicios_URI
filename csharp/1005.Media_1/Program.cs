using System;
using System.Globalization;

namespace _1005.Media_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double media = ((A * 3.5) + (B * 7.5)) / 11.0;

            //Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

            double valor = double.Parse(Console.ReadLine());

            if (valor > 0.0 && valor <= 2000.00)
            {
                Console.WriteLine("Insento");
            }
            else
            {
                if (valor > 2000.00 && valor <= 3000.00)
                {
                    double A = valor - 2000.0;
                    double A2 = A * 0.08;
                    Console.WriteLine("R$ " + A2.ToString("F2", CultureInfo.InvariantCulture));
                }
                else
                {
                    if (valor > 3000.00 && valor <= 4500.00)
                    {
                        double A = valor - 3000.0;
                        double A2 = A * 0.18;
                        double B = (valor - 2000.0) - A;
                        double B2 = B * 0.08;
                        double C = A2 + B2;
                        Console.WriteLine("R$ " + C.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        double A = valor - 4500.01;
                        double A2 = A * 0.28;
                        double B = (valor - 2500.0) - A;
                        double B2 = B * 0.18;
                        double C = A2 + B2;
                        Console.WriteLine("R$ " + C.ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
        }
    }
}
