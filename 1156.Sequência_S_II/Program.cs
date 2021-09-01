using System;
using System.Globalization;

namespace _1156.Sequência_S_II
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1;
            double R = 2;

            for (int i = 3; i < 40; i++)
            {
                if (i % 2 != 0)
                {
                    S += i / R;
                    R *= 2.00;
                }
            }
            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
