using System;
using System.Globalization;

namespace _1010.Cálculo_Simples_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');

            int codPeca1 = int.Parse(peca1[0]);
            int numPeca1 = int.Parse(peca1[1]);
            double valPeca1 = Convert.ToDouble(peca1[2], CultureInfo.InvariantCulture);

            double totPeca1 = numPeca1 * valPeca1;

            string[] peca2 = Console.ReadLine().Split(' ');

            int codPeca2 = int.Parse(peca2[0]);
            int numPeca2 = int.Parse(peca2[1]);
            double valPeca2 = Convert.ToDouble(peca2[2], CultureInfo.InvariantCulture);

            double totPeca2 = numPeca2 * valPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + (totPeca1 + totPeca2).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
