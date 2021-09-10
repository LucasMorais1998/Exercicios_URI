using System;

namespace _2708.Turistas_no_Parque_Huacachina
{
    class Program
    {
        static void Main(string[] args)
        {
            int Saida = 0; int Volta = 0; int Condicao = 1; int Jipe = 0;

            do
            {
                string[] teste = Console.ReadLine().Split(' ');

                if (teste[0] == "ABEND")
                {
                    Condicao = 0;
                    
                }
                else
                {
                    Condicao = 1;

                    if (teste[0] == "SALIDA")
                    {
                        Saida += int.Parse(teste[1]);
                        Jipe++;
                    }

                    if (teste[0] == "VUELTA")
                    {
                        Volta += int.Parse(teste[1]);
                        Jipe--;
                    }                  
                }              

            } while (Condicao == 1);

            int Total = Saida - Volta;
            Console.WriteLine(Total);
            Console.WriteLine(Jipe);






        }
    }
}
