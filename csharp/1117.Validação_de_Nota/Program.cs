using System;
using System.Globalization;

namespace _1117.Validação_de_Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            //double n1, n2;
            //double N1 = 0.0;
            //double N2 = 0.0;

            //do
            //{
            //    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    if (n1 < 0 || n1 > 10.0)
            //    {

            //        Console.WriteLine("nota invalida");

            //    }
            //    else
            //    {
            //        N1 = n1;
            //    }

            //    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    if (n2 < 0 || n2 > 10.0)
            //    {

            //        Console.WriteLine("nota invalida");

            //    }
            //    else
            //    {
            //        N2 = n2;
            //    }

            //} while (n1 < 0 || n2 < 0 && n1 > 10.0 || n2 > 10.0);

            //double media = (N1 + N2) / 2.0;
            //Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            double n1, n2;
            double N1 = 0.0;
            double N2 = 0.0;

            do
            {
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (n1 < 0 || n1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    N1 = n1;
                }

            } while (n1 < 0 || n1 > 10.0);

            do
            {
                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (n2 < 0 || n2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    N2 = n2;
                }

            } while (n2 < 0 || n2 > 10.0);

            double media = (N1 + N2) / 2.0;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
