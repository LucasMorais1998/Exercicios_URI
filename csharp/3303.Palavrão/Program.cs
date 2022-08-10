using System;

namespace _3303.Palavrão
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = Console.ReadLine();

            if (palavra.Length >= 10)
            {
                Console.WriteLine("palavrao");
            }
            else
            {
                Console.WriteLine("palavrinha");
            }
        }
    }
}
