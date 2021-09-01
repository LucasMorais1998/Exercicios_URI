using System;

namespace Projeto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salFix = Convert.ToDouble(Console.ReadLine());
            double totV = Convert.ToDouble(Console.ReadLine());

            double comissao = (totV * 15) / 100.0;
            double salFim = (salFix + comissao);

            Console.WriteLine("TOTAL = R$ {0}", salFim.ToString("0.00"));

        }
        
    }
}
