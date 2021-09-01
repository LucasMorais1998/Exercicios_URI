using System;

namespace _1042.Sort_Simples
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');

            int[] num = new int[3];

            num[0] = int.Parse(valores[0]);
            num[1] = int.Parse(valores[1]);
            num[2] = int.Parse(valores[2]);

            Array.Sort(num); 

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            foreach (string i in valores)
            {
                Console.WriteLine(i);
            }
        }
    }
}
