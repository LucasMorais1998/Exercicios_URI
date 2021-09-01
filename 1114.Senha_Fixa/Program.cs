using System;

namespace _1114.Senha_Fixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int Senha = 0000;
            do
            {
                Senha = int.Parse(Console.ReadLine());

                if (Senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                }

            } while (Senha != 2002);
        }
    }
}
