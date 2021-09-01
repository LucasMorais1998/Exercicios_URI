using System;
using System.Globalization;

namespace _1146.Sequências_Crescentes
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 1;

            do
            {
                X = int.Parse(Console.ReadLine());

                for (int i = 0 + 1; i < X + 1; i++)
                {
                    if (i == X)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }


            } while (X != 0);
        }
    }
}
