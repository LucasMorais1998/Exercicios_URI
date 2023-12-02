using System;

namespace _1052.Mês
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mes = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(mes[N - 1]);
        }
    }
}
