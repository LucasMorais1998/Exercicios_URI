using System;

namespace _1177.Preenchimento_de_Vetor_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[1000];

            int T = int.Parse(Console.ReadLine()); 

            int Max = T; 
            T = 0;

            for (int i = 0; i < N.Length; i++)
            {

                N[i] = T;


                if (T >= Max)
                {
                    T = 0;
                }

                Console.WriteLine("N[" + i + "] = " + T);
                T++;
            }
            



        }
    }
}
