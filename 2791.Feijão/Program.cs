using System;

namespace _2791.Feijão
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada = Console.ReadLine().Split(' ');
            int[] C = new int[4];

            for (int i = 0; i < 4; i++)
            {
                C[i] = int.Parse(Entrada[i]);

                if (C[i] == 1)
                {
                    Console.WriteLine(i + 1);
                }
            }
            
        }
    }
}
