using System;

namespace _1933.Tri_du
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada = Console.ReadLine().Split(' ');
          
            int A = int.Parse(Entrada[0]);
            int B = int.Parse(Entrada[1]);

            int primeira = 0, segunda = 0, terceira = 0;

            if (A >= 1 && A <= 13)
            {
                primeira = A;             
            }

            if (B >= 1 && A <= 13)
            {
                segunda = B;
            }

            if (primeira > segunda)
            {
                terceira = primeira;
            }
            else
            {
                if (segunda > primeira)
                {
                    terceira = segunda;
                }
                else
                {
                    terceira = primeira;
                }
            }
            Console.WriteLine(terceira);
        }
    }
}
