using System;

namespace _1037.Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if ((num >= 0.00) && (num <= 25.0000))
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else
            {
                if ((num > 25.00000) && (num <= 50.0000000))
                {
                    Console.WriteLine("Intervalo (25,50]");
                }
                else
                {
                    if ((num > 50.0000000) && (num <= 75.0000000))
                    {
                        Console.WriteLine("Intervalo (50,75]");
                    }
                    else
                    {
                        if ((num > 75.0000000) && (num <= 100.0000000))
                        {
                            Console.WriteLine("Intervalo (75,100]");
                        }
                        else
                        {
                            Console.WriteLine("Fora de intervalo");
                        }
                    }
                }
            }
        }
    }
}
