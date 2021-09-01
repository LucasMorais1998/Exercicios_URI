using System;

namespace _1072.Intervalo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int contIn = 0;
            int contOut = 0;

            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    contIn++;
                }
                else
                {
                    contOut++;
                }
            }
           
            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");
        }
    }
}
