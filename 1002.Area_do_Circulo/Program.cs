using System;
using System.Globalization;

namespace _1002.Area_do_Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double n = 3.14159;
            double area = n * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }

    }
}
    

