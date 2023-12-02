using System;
using System.Globalization;

namespace _1064.Positivos_e_Média
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = new double[6];
            int positivos = 0;
            double ContMedia = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nums[i] > 0)
                {
                    positivos++;
                    ContMedia = ContMedia + nums[i];
                }
            }
            double media = ContMedia / positivos;
            Console.WriteLine(positivos + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
