using System;

namespace _1065.Pares_entre_Cinco_Números
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            int pares = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

                if (nums[i] % 2 == 0)
                {
                    pares++;
                }
            }
            Console.WriteLine(pares + " valores positivos");

            //int N1 = int.Parse(Console.ReadLine());
            //int N2 = int.Parse(Console.ReadLine());
            //int N3 = int.Parse(Console.ReadLine());
            //int N4 = int.Parse(Console.ReadLine());
            //int N5 = int.Parse(Console.ReadLine());

            //int pares = 0;

            //if (N1 % 2 == 00 || N2 % 2 == 00 || N3 % 2 == 00 || N4 % 2 == 00 || N5 % 2 == 0)
            //{
            //    pares = pares + 1;
            //}
            //Console.WriteLine(pares + " valores pares");
        }
    }
}
