using System;

namespace _2862.Inseto_
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());

            for (int i = 0; i < C; i++)
            {
                int N = int.Parse(Console.ReadLine());

                if (N > 8000)
                {
                    Console.WriteLine("Mais de 8000!");
                }
                else
                {
                    Console.WriteLine("Inseto!");
                }

            }
        }
    }
}
