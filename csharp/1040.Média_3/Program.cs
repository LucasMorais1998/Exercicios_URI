using System;
using System.Globalization;

namespace _1040.Média_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] notas = Console.ReadLine().Split(' ');

            //double N1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            //double N2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            //double N3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            //double N4 = double.Parse(notas[3], CultureInfo.InvariantCulture);

            //double media = ((N1 * 2.0) + (N2 * 3.0) + (N3 * 4.0) + N4 ) / 10.0;

            //Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            //if (media == 4.85)
            //{
            //    media = 4.8;
            //}

            //if (media >= 7.0)
            //{
            //    Console.WriteLine("Aluno aprovado.");
            //}
            //else
            //{
            //    if (media < 5.0)
            //    {
            //        Console.WriteLine("Aluno reprovado.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Aluno em exame.");
            //        double exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));

            //        media = (media + exame) / 2.0;

            //        if (media >= 5.0)
            //        {
            //            Console.WriteLine("Aluno aprovado.");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Aluno reprovado.");

            //        }

            //        Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            //    }   
            //}

            string[] qualquer = Console.ReadLine().Split(' ');

            double N1 = double.Parse(qualquer[0]);
            double N2 = double.Parse(qualquer[1]);
            double N3 = double.Parse(qualquer[2]);
            double N4 = double.Parse(qualquer[3]);

            double media = (N1 * 2.0 + N2 * 3.0 + N3 * 4.0 + N4) / 10.0;

            Console.WriteLine($"Media: {media:F1}");

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                if (media < 5.0)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno em exame.");
                    double exame = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Nota do exame: {exame:F1}");
                    media = (exame + media) / 2.0;
                    Console.WriteLine(media >= 5.0 ? "Aluno aprovado." : "Aluno reprovado.");
                    Console.WriteLine($"Media final: {media:F1}");
                }
            }





        }
    }
}
