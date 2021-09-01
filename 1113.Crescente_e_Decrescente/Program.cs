using System;

namespace _1113.Crescente_e_Decrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            int Y = 0 + 1;

            if (X != Y)
            {
                do
                {
                    string[] Entrada = Console.ReadLine().Split(' ');

                    X = int.Parse(Entrada[0]); // 10
                    Y = int.Parse(Entrada[1]); // 20

                    if (Y > X) // 20 > 10
                    {
                        Console.WriteLine("Crescente");
                    }
                    else
                    {
                        if (X > Y)
                        {
                            Console.WriteLine("Decrescente");
                        }
                    }

                } while (X != Y);
                
            }
        }
    }
}
