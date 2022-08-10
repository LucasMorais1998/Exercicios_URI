using System;

namespace _1115.Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 1;
            int Y = 1;

            do
            {
                string[] Entrada = Console.ReadLine().Split(' ');

                 X = int.Parse(Entrada[0]);
                 Y = int.Parse(Entrada[1]);

                if (X != 0 && Y != 0)
                {
                    if (X > 0 && Y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else
                    {
                        if (X < 0 && Y > 0)
                        {
                            Console.WriteLine("segundo");
                        }
                        else
                        {
                            if (X < 0 && Y < 0)
                            {
                                Console.WriteLine("terceiro");
                            }
                            else
                            {
                                Console.WriteLine("quarto");
                            }
                        }
                    }
                }

            } while (X != 0 && Y != 0);
            
        }
    }
}
