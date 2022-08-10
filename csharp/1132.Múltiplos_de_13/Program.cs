using System;

namespace _1132.Múltiplos_de_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine()); // 200
            int Y = int.Parse(Console.ReadLine()); // 100
            int Div = 0;

            if (X > Y) 
            {
                int Aux = Y; // Aux = 100
                Y = X; // Y = 200
                X = Aux; // X = 100
            }

            for (int i = X; i <= Y; i++)
            {
                if (i % 13 != 0)
                {
                    Div += i;
                }
            }
            Console.WriteLine(Div);
        }
    }
}
