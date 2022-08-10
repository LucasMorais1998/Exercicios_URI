using System;
using System.Globalization;

namespace _1017.Gasto_de_Combustível
{
    class Program
    {
        static void Main(string[] args)
        {
            // automovel faz 12 km/l

            int temp = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int vel = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = temp * vel / 12.00; // use .00 ou não irá funcionar!

            Console.WriteLine(result.ToString("F3", CultureInfo.InvariantCulture));

            


        }
    }
}
