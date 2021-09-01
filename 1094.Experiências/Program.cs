using System;
using System.Globalization;

namespace _1094.Experiências
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            int Quant = 0;
            string Tipo;


            int ContR = 0, ContS = 0, ContC = 0, Total = 0;

            for (int i = 0; i < N; i++)
            {

                string[] Cobaia = Console.ReadLine().Split(' ');
;               Quant = Convert.ToInt32(Cobaia[0]);
                Tipo = Cobaia[1];

                if (Quant >= 1 && Quant <= 15)
                {
                    if (Tipo == "R")
                    {
                        ContR += Quant;
                        Total += Quant;
                    }
                    else
                    {
                        if (Tipo == "S")
                        {
                            ContS += Quant;
                            Total += Quant;
                        }
                        else
                        {
                            if (Tipo == "C")
                            {
                                ContC += Quant;
                                Total += Quant;
                            }
                        }
                    }                             
                }

            }

            int TotalFinal = ContC + ContS + ContR;
            double PorcentC = (ContC * 100.0) / TotalFinal;
            double PorcentR = (ContR * 100.0) / TotalFinal;
            double PorcentS = (ContS * 100.0) / TotalFinal;


            Console.WriteLine("Total: " + Total + " cobais");
            Console.WriteLine("Total de coelhos: " + ContC);
            Console.WriteLine("Total de ratos: " + ContR);
            Console.WriteLine("Total de sapos: " + ContS);

            Console.WriteLine("Percentual de coelhos: " + PorcentC.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + PorcentR.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + PorcentS.ToString("F2", CultureInfo.InvariantCulture) + " %");



        }
    }
}
