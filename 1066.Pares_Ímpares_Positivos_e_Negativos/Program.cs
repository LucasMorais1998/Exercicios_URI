using System;

namespace _1066.Pares_Ímpares_Positivos_e_Negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

                if (nums[i] % 2 == 0)
                {
                    pares++;
                }
                if (nums[i] % 2 != 0)
                {
                    impares++;
                }
                if (nums[i] >  0)
                {
                    positivos++;
                }
                if (nums[i] < 0)
                {
                    negativos++;
                }
            }
            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");
        }
    }
}
