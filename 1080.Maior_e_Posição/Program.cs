using System;

namespace _1080.Maior_e_Posição
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int posicao = 0;
            int[] nums = new int[101];

            for (int i = 1; i < 100; i++)
            {
                
                nums[i] = int.Parse(Console.ReadLine());

                if (nums[i] > maior)
                {
                    maior = nums[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
            
        }
    }
}
