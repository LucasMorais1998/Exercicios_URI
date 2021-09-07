using System;

namespace _1150.Ultrapassando_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());

            int teste = 0;
            int cont = 0;

            while (X >= Z)
            {
                Z = int.Parse(Console.ReadLine());
            }

            if (X + X > Z)
            {
                cont = 1;
            }
            else
            {
                do
                {
                    teste += X;
                    cont++;
                    X++;

                } while (Z > teste);
            }

            Console.WriteLine(cont);
          
        }
    }
}
