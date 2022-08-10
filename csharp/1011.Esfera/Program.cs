using System;
using System.Globalization;

namespace _1011.Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            r = Math.Pow(r, 3);

            double pi = 3.14159;
            double volume = ((4 / 3.0) * pi) * r;

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
