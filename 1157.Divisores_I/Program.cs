using System;

namespace _1157.Divisores_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i < N + 1; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }  
            }
        }
    }
}
