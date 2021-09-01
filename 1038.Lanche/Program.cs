using System;
using System.Globalization;

namespace _1038.Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produto = Console.ReadLine().Split();

            int codProduto = int.Parse(produto[0]);
            int qntProduto = int.Parse(produto[1]);

            double total = 0;

            switch (codProduto)
            {
                case 1:
                    total = qntProduto * 4.00;
                    break;

                case 2:
                    total = qntProduto * 4.50;
                    break;

                case 3:
                    total = qntProduto * 5.00;
                    break;

                case 4:
                    total = qntProduto * 2.00;
                    break;

                case 5:
                    total = qntProduto * 1.50;
                    break;

                default:
                    break;
            }
            Console.WriteLine("TOTAL: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
