using System;
using System.Globalization;

namespace _1018.Cédulas
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //int NotaCem = N / 100; // 576 / 100 = 5.76 ou seja 5 notas de 100
            //int resto = N % 100; // resto da divisao de 576/100 ou seja .76
            //int NotaCinquenta = resto / 50; // .76 / 50 = 1.52 ou seja  1 nota de 50
            //resto = resto % 50; // resto da divisao de .76 / 50 ou seja .2
            //int NotaVinte = resto / 20; // .2 / 20 = 1 ou seja 1 nota de 20
            //resto = resto % 20;
            //int NotaDez = resto / 10;
            //resto = resto % 10;
            //int NotaCinco = resto / 5;
            //resto = resto % 5;
            //int NotaDois = resto / 2;
            //resto = resto % 2;
            //int NotaUm = resto / 1;

            //Console.WriteLine(NotaCem + " nota(s) de R$ 100,00");
            //Console.WriteLine(NotaCinquenta + " nota(s) de R$ 50,00");
            //Console.WriteLine(NotaVinte + " nota(s) de R$ 20,00");
            //Console.WriteLine(NotaDez + " nota(s) de R$ 10,00");
            //Console.WriteLine(NotaCinco + " nota(s) de R$ 5,00");
            //Console.WriteLine(NotaDois + " nota(s) de R$ 2,00");
            //Console.WriteLine(NotaUm + " nota(s) de R$ 1,00");

            int[] notas = new int[7] { 100, 50, 20, 10, 5, 2, 1 };
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int qntNotas;
            Console.WriteLine(N);
            for (int i = 0; i < notas.Length; i++)
            {
                qntNotas = (N / notas[i]);
                Console.WriteLine(qntNotas.ToString(CultureInfo.InvariantCulture) + " nota(s) de R$ " + notas[i].ToString(CultureInfo.InvariantCulture) + ",00");
                N = N % notas[i];
            }

            //int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //int Cem = (N / 100);
            //N = N % 100;
            //int Cinq = (N / 50);
            //N = N % 50;
            //int Vinte = (N / 20);
            //N = N % 20;
            //int Dez = (N / 10);
            //N = N % 10;
            //int Cinco = (N / 5);
            //N = N % 5;
            //int Dois = (N / 2);
            //N = N % 2;
            //int Um = (N / 1);
            //N = N % 1;

            //Console.WriteLine($"{Cem}" + " nota(s) de R$ 100,00");
            //Console.WriteLine($"{Cinq}" + " nota(s) de R$ 50,00");
            //Console.WriteLine($"{Vinte}" + " nota(s) de R$ 20,00");
            //Console.WriteLine($"{Dez}" + " nota(s) de R$ 10,00");
            //Console.WriteLine($"{Cinco}" + " nota(s) de R$ 5,00");
            //Console.WriteLine($"{Dois}" + " nota(s) de R$ 2,00");
            //Console.WriteLine($"{Um}" + " nota(s) de R$ 1,00");



        }
    }
}
