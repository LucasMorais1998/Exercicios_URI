using System;
using System.Globalization;

namespace _1155.Sequência_S
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1;

            for (int i = 2; i < 101; i++)
            {
                S += 1.0 / i;
            }

            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
