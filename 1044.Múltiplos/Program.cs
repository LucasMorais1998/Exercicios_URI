using System;

namespace _1044.Múltiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] val = Console.ReadLine().Split(' ');

            int A = int.Parse(val[0]);
            int B = int.Parse(val[1]);

            if ((A % B == 0) || (B % A == 0))
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
