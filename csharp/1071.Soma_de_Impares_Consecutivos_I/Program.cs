using System;

namespace _1071.Soma_de_Impares_Consecutivos_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine()); //2
            int Y = int.Parse(Console.ReadLine()); //12
            int Soma = 0;

            if (Y > X)
            {
                for (int i = X + 1; i < Y; i++)
                {
                    if (i % 2 != 0)
                    {
                        Soma += i;
                    }
                }
            }
            else
            {
                for (int i = Y + 1; i < X; i++)
                {
                    if (i % 2 != 0)
                    {
                        Soma += i;
                    }
                }
            }

            Console.WriteLine(Soma);


        }
    }
}
