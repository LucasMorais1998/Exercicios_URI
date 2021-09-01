using System;

namespace _1134.Tipo_de_Combustível
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tipo = 0;
            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;

            do
            {
                do
                {
                    Tipo = int.Parse(Console.ReadLine());

                } while (Tipo != 1 && Tipo != 2 && Tipo != 3 && Tipo != 4);

                if (Tipo == 1)
                {
                    Alcool += 1;
                }
                else
                {
                    if (Tipo == 2)
                    {
                        Gasolina += 1;
                    }
                    else
                    {
                        if (Tipo == 3)
                        {
                            Diesel += 1;
                        }
                    }
                }

            } while (Tipo != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + Alcool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Diesel: " + Diesel);
        }
    }
}
