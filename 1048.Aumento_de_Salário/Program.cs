using System;
using System.Globalization;

namespace _1048.Aumento_de_Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            //double Sal = double.Parse(Console.ReadLine());
            //double Reajuste, Percent, NewSal = 0;
            //int Info;


            //if (Sal >= 0.0 && Sal <= 400.00)
            //{
            //    Percent = 0.15;
            //    Info = 15;
            //    Reajuste = Sal * Percent;
            //    NewSal = Sal + Reajuste;
            //}
            //else
            //{
            //    if (Sal > 400.00 && Sal <= 800.00)
            //    {
            //        Percent = 0.12;
            //        Info = 12;
            //        Reajuste = Sal * Percent;
            //        NewSal = Sal + Reajuste;
            //    }
            //    else
            //    {
            //        if (Sal > 800.00 && Sal <= 1200.00)
            //        {
            //            Percent = 0.10;
            //            Info = 10;
            //            Reajuste = Sal * Percent;
            //            NewSal = Sal + Reajuste;
            //        }
            //        else
            //        {
            //            if (Sal > 1200.00 && Sal <= 2000.00)
            //            {
            //                Percent = 0.07;
            //                Info = 7;
            //                Reajuste = Sal * Percent;
            //                NewSal = Sal + Reajuste;
            //            }
            //            else
            //            {
            //                Percent = 0.04;
            //                Info = 4;
            //                Reajuste = Sal * Percent;
            //                NewSal = Sal + Reajuste;
                            
            //            }
            //        }
                                      
            //    }
            //}
            //Console.WriteLine("Novo salario: " + NewSal.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Reajuste ganho: " + Reajuste.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Em percentual: " + Info + " %");

            double salario = double.Parse(Console.ReadLine());



            double indice = salario <= 400.00
            ? 0.15
            : salario <= 800.00
            ? 0.12
            : salario <= 1200.00
            ? 0.1
            : salario <= 2000.00
            ? 0.07
            : 0.04;



            double reajuste = salario * indice;



            Console.WriteLine($"Novo salario: {salario + reajuste:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: {indice * 100:F0} %");


        }

    }
}
