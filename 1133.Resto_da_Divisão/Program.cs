using System;

namespace _1133.Resto_da_Divisão
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine()); // 20
            int Y = int.Parse(Console.ReadLine()); // 10

            if (X > Y)
            {
                int Aux = Y; // Aux = 10
                Y = X; // Y = 20
                X = Aux; // X = 10
            }

            for (int i = X + 1; i < Y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
