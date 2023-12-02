using System;

namespace _1013.O_Maior
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] maior = Console.ReadLine().Split(' ');
            int A = int.Parse(maior[0]);
            int B = int.Parse(maior[1]);
            int C = int.Parse(maior[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;

            if (maiorAB > C)
            {
                Console.WriteLine(maiorAB + " eh o maior");
            }
            else
            {
                Console.WriteLine(C + " eh o maior");
            }
        }
    }
}
