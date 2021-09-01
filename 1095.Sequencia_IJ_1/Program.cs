using System;

namespace _1095.Sequencia_IJ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int J = 65;
            var I = -2;

            for (int i = 0; i < 13; i++)
            {
                J = J - 5;
                I = I + 3;
                Console.WriteLine("I=" + I +" "+ "J=" + J);
            }
        }
    }
}
