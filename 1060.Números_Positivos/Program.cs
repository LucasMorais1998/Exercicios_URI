using System;

namespace _1060.Números_Positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = new double[6];
            int positivos = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = double.Parse(Console.ReadLine());

                if (nums[i] > 0)
                {
                    positivos++;
                }
            }
            Console.WriteLine(positivos + " valores positivos");
            
        }
    }
}
