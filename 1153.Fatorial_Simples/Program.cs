using System;

namespace _1153.Fatorial_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int Fatorial = 1;

            for (int i = N; i > 1; i--)
            {
                Fatorial = (Fatorial * i);
            }
            Console.WriteLine(Fatorial);

        }
    }
}
