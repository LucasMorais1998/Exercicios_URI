using System;
using System.Globalization;

namespace _1021.Notas_e_Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] notas = new double[12] { 100.0, 50.0, 20.0, 10.0, 5.0, 2.0, 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };
            //double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double qntNotas;

            //Console.WriteLine("NOTAS:");


            //string status = " nota(s) de R$ ";
            //string status2 = ",00";

            //for (int i = 0; i < 12; i++)
            //{
            //    qntNotas = Math.Truncate(N / notas[i]);
            //    Console.WriteLine(qntNotas.ToString(CultureInfo.InvariantCulture) + status + notas[i] + status2);
            //    N = N % notas[i];

            //    if (i == 5)
            //    {
            //        Console.WriteLine("MOEDAS:");
            //    }

            //    if (i >= 5)
            //    {
            //        status = " moedas(s) de R$ ";
            //        status2 = "";
            //        if (i == 5)
            //        {
            //            status2 = ".00";
            //        }
            //        if (i == 6 || i == 8)
            //        {
            //            status2 = "0";
            //        }
            //        qntNotas = (N / notas[i]);

            //        N = N % notas[i];
            //    }

            //}

            //double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double Cem = Math.Truncate(N / 100.0);
            //N = N % 100.0;
            //double Cinq = Math.Truncate(N / 50.0);
            //N = N % 50.0;
            //double Vinte = Math.Truncate(N / 20.0);
            //N = N % 20.0;
            //double Dez = Math.Truncate(N / 10.0);
            //N = N % 10.0;
            //double Cinco = Math.Truncate(N / 5.0);
            //N = N % 5.0;
            //double Dois = Math.Truncate(N / 2.0);
            //N = N % 2.0;

            //double UmReal = Math.Truncate(N / 1.00);
            //N = N % 1.00;
            //double CinqCents = Math.Truncate(N / 0.50);
            //N = N % 0.50;
            //double VtCCents = Math.Truncate(N / 0.25);
            //N = N % 0.25;
            //double DezCents = Math.Truncate(N / 0.10);
            //N = N % 0.10;
            //double CincoCents = Math.Truncate(N / 0.05);
            //N = N % 0.05;
            //double UmCent = Math.Truncate(N / 0.01);
            //N = N % 0.01;

            //Console.WriteLine("NOTAS:");
            //Console.WriteLine(Cem.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 100.00");
            //Console.WriteLine(Cinq.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 50.00");
            //Console.WriteLine(Vinte.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 20.00");
            //Console.WriteLine(Dez.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 10.00");
            //Console.WriteLine(Cinco.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 5.00");
            //Console.WriteLine(Dois.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ 2.00");

            //Console.WriteLine("MOEDAS:");
            //Console.WriteLine(UmReal.ToString(CultureInfo.InvariantCulture) + " moeda(s) de R$ 1.00");
            //Console.WriteLine(CinqCents.ToString(CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.50");
            //Console.WriteLine(VtCCents.ToString(CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.25");
            //Console.WriteLine(DezCents.ToString(CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.10");
            //Console.WriteLine(CinqCents.ToString(CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.05");
            //Console.WriteLine(UmCent.ToString(CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.01");


            double dinheiroTotal = double.Parse(Console.ReadLine());
            int notas = (int)dinheiroTotal;
            int moedas = (int)((dinheiroTotal - notas) * 100);
            int notas100 = notas / 100;
            notas -= notas100 * 100;
            int notas50 = notas / 50;
            notas -= notas50 * 50;
            int notas20 = notas / 20;
            notas -= notas20 * 20;
            int notas10 = notas / 10;
            notas -= notas10 * 10;
            int notas5 = notas / 5;
            notas -= notas5 * 5;
            int notas2 = notas / 2;
            notas -= notas2 * 2;
            int moedas1 = notas;
            notas -= moedas1 * 1;
            int moedas50 = moedas / 50;
            moedas -= moedas50 * 50;
            int moedas25 = moedas / 25;
            moedas -= moedas25 * 25;
            int moedas10 = moedas / 10;
            moedas -= moedas10 * 10;
            int moedas05 = moedas / 5;
            moedas -= moedas05 * 5;
            int moedas01 = moedas;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(notas100 + " nota(s) de R$ 100.00");
            Console.WriteLine(notas50 + " nota(s) de R$ 50.00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20.00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10.00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5.00");
            Console.WriteLine(notas2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moedas1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moedas50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moedas25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moedas10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moedas05 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moedas01 + " moeda(s) de R$ 0.01");




        }
    }
}
