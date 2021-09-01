using System;
using System.Globalization;

namespace _1154.Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            double contIdade = 0;
            double contMedia = 0;

            while (N > 0)
            {
                N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (N > 0)
                {
                    contIdade++;
                    contMedia += N;
                }
            }

            double mediaIdades = (contMedia / contIdade);

            //Console.WriteLine(contIdade);
            Console.WriteLine(mediaIdades.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
