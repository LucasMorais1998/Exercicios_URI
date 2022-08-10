using System;

namespace _1074.Par_ou_Ímpar
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[] Num = new int[N];

            for (int i = 0; i < N; i++)
            {
                Num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                if (Num[i] == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    if (Num[i] % 2 == 1 && Num[i] > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        if (Num[i] % 2 == 0 && Num[i] < 0)
                        {
                            Console.WriteLine("EVEN NEGATIVE");
                        }
                        else
                        {
                            if (Num[i] % 2 == 0 && Num[i] > 0)
                            {
                                Console.WriteLine("EVEN POSITIVE");
                            }
                            else
                            {
                                Console.WriteLine("ODD NEGATIVE");
                                
                            }
                        }
                    }
                }
                
                
            }
        }
    }
}
