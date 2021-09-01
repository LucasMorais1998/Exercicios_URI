using System;

namespace _1142.PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cont = 1;

            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(cont + " ");
                    cont++;
                }
                Console.WriteLine("PUM");
                cont++;
            }
     
        }
    }
}
