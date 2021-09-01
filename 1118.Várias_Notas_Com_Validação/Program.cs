using System;
using System.Globalization;

namespace _1118.Várias_Notas_Com_Validação
{
    class Program
    {
        static void Main(string[] args)
        {
            int programa = 1;

            while (programa == 1)
            {

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

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    programa = int.Parse(Console.ReadLine());

                    if (programa == 2)
                    {
                        break;
                    }
                } while (programa != 1);
                
            }
        }
    }
}
