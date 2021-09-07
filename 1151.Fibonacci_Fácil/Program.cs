using System;

namespace _1151.Fibonacci_Fácil
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N > 0 && N < 46)
            {
                int n1 = 0;
                Console.Write(n1 + " ");
                int n2 = 1;
                Console.Write(n2 + " ");

                for (int i = 2; i < N; i++)
                {
                    int n3 = n1 + n2;

                    if (i == N - 1)
                    {
                        Console.WriteLine(n3);
                    }
                    else
                    {
                        Console.Write(n3 + " ");
                        n1 = n2;
                        n2 = n3;
                    }
                    

                }
            }
        }


    }
}
