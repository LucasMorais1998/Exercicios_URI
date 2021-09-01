using System;
using System.Globalization;

namespace _1014.Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            Console.WriteLine((X / Y).ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
