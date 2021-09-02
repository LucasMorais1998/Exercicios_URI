using System;

namespace _1179.Preenchimento_de_Vetor_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] X = new int[15];
            int[] Par = new int[5];
            int[] Impar = new int[5];

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    Par[i] = X[i];

                    if (Par.Length != 0)
                    {
                        Array.Clear(Par, 0, 0);
                        Console.WriteLine(Par[i]);
                    }
                }

                if (X[i] % 2 != 0)
                {
                    Impar[i] = X[i];

                    if (Impar.Length != 0)
                    {
                        Array.Clear(Impar, 0, 0);
                        Console.WriteLine(Impar[i]);
                    }
                }
            }






        }
    }
}
