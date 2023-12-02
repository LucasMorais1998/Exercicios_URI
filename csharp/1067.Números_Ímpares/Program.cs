using System;

namespace _1067.Números_Ímpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            for (int i = X; i < X + 12 ; i++)
            {
                                
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
