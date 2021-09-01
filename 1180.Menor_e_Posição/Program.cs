using System;

namespace _1180.Menor_e_Posição
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[10];

            int Menor = ;
            int Posicao = 0;

            for (int i = 0; i < N.Length; i++)
            {
                N[i] = int.Parse(Console.ReadLine());

                if (Menor > N[i])
                {
                    Menor = N[i];
                    Posicao = i;
                }
            }
            
            Console.WriteLine("Menor valor: " + Menor);
            Console.WriteLine("Posicao: " + Posicao);
            


           

        }
    }
}
