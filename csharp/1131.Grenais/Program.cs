using System;

namespace _1131.Grenais
{
    class Program
    {
        static void Main(string[] args)
        {
            int Resposta = 1;
            int ContInter = 0;
            int ContGrem = 0;
            int ContEmpate = 0;
            int ContTotal = 0;

            do
            {
                string[] Entrada = Console.ReadLine().Split(' ');

                int Inter = int.Parse(Entrada[0]);
                int Gremio = int.Parse(Entrada[1]);

                if (Inter > Gremio)
                {
                    ContInter += 1;
                }
                else
                {
                    if (Gremio > Inter)
                    {
                        ContGrem += 1;
                    }
                    else
                    {
                        ContEmpate += 1;
                    }
                }

                ContTotal += 1;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                Resposta = int.Parse(Console.ReadLine());

            } while (Resposta == 1);

            Console.WriteLine(ContTotal + " grenais");
            Console.WriteLine("Inter:" + ContInter);
            Console.WriteLine("Gremio:" + ContGrem);
            Console.WriteLine("Empates:" + ContEmpate);

            if (ContInter > ContGrem)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                if (ContGrem > ContInter)
                {
                    Console.WriteLine("Gremio venceu mais");
                }
                else
                {
                    Console.WriteLine("Nao houve vencedor");
                }
            }
        }
    }
}
