using System;

namespace _1045.Tipos_de_Triângulos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double[] num = new double[3];

            num[0] = double.Parse(vet[0]);
            num[1] = double.Parse(vet[1]);
            num[2] = double.Parse(vet[2]);

            Array.Sort(num);

            double A = num[2];
            double B = num[1];
            double C = num[0];

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (A * A == B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else
                {
                    if (A * A > B * B + C * C)
                    {
                        Console.WriteLine("TRIANGULO OBTUSANGULO");
                    }
                    else
                    {
                        Console.WriteLine("TRIANGULO ACUTANGULO");
                    }
                    if (A == B && B == C)
                    {
                        Console.WriteLine("TRIANGULO EQUILATERO");
                    }
                    else
                    {
                        if (A == B || A == C || B == C)
                        {
                            Console.WriteLine("TRIANGULO ISOSCELES");
                        }
                    }
                }
            }

            
        }
    }
}
