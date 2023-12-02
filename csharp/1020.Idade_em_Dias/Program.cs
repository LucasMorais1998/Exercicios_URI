using System;
using System.Globalization;

namespace _1020.Idade_em_Dias
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeDias = int.Parse(Console.ReadLine());

            int ano = idadeDias / 365; // quantos anos cabem em N sendo N dias de idade
            int mes = (idadeDias % 365) / 30; // resto da divisao de 365/N dividido por 30 (1 mes)
            int dias = (idadeDias % 365) % 30; // resto da divisao de 365/N, pelo resto da divisão por 30

            Console.WriteLine("{0} ano(s)\n{1} mes(es)\n{2} dia(s)\n", ano, mes, dias);

            //Console.WriteLine(ano + " ano(s)");
            //Console.WriteLine(mes + " mes(es)");
            //Console.WriteLine(dias + " dia(s)");


        }
    }
}
