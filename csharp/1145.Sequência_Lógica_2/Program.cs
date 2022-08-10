using System;

namespace _1145.Sequência_Lógica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada = Console.ReadLine().Split(' ');

            int X = int.Parse(Entrada[0]);
            int Y = int.Parse(Entrada[1]);

            for (int i = 1; i <= Y; i++)
            {
                Console.Write(i);

                if (i % X == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write(" ");
                }
            }


        }
    }
}
