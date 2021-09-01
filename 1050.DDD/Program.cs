using System;

namespace _1050.DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            //int DDD = int.Parse(Console.ReadLine());
            //string Destination = "Null";

            //if (DDD == 61)
            //{
            //    Destination = "Brasilia";
            //}
            //else
            //{
            //    if (DDD == 71)
            //    {
            //        Destination = "Salvador";
            //    }
            //    else
            //    {
            //        if (DDD == 11)
            //        {
            //            Destination = "São Paulo";
            //        }
            //        else
            //        {
            //            if (DDD == 21)
            //            {
            //                Destination = "Rio de Janeiro";
            //            }
            //            else
            //            {
            //                if (DDD == 32)
            //                {
            //                    Destination = "Juiz de Fora";
            //                }
            //                else
            //                {
            //                    if (DDD == 19)
            //                    {
            //                        Destination = "Campinas";
            //                    }
            //                    else
            //                    {
            //                        if (DDD == 27)
            //                        {
            //                            Destination = "Vitoria";
            //                        }
            //                        else
            //                        {
            //                            if (DDD == 31)
            //                            {
            //                                Destination = "Belo Horizonte";
            //                            }
            //                            else
            //                            {
            //                                Destination = "DDD nao cadastrado";
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(Destination);

            //string[] DDD = new string[8] { "Brasilia", "Salvador", "São Paulo", "Rio de Janeiro", "Juiz de Fora", "Campinas", "Vitoria", "Belo Horizonte" };
            //int N = int.Parse(Console.ReadLine());
            //string Destination; 

            //if (N == 61)
            //{
            //    Destination = DDD[0];
            //}
            //else
            //{
            //    if (N == 71)
            //    {
            //        Destination = DDD[1];
            //    }
            //    else
            //    {
            //        if (N == 11)
            //        {
            //            Destination = DDD[2];
            //        }
            //        else
            //        {
            //            if (N == 21)
            //            {
            //                Destination = DDD[3];
            //            }
            //            else
            //            {
            //                if (N == 32)
            //                {
            //                    Destination = DDD[4];
            //                }
            //                else
            //                {
            //                    if (N == 19)
            //                    {
            //                        Destination = DDD[5];
            //                    }
            //                    else
            //                    {
            //                        if (N == 27)
            //                        {
            //                            Destination = DDD[6];
            //                        }
            //                        else
            //                        {
            //                            if (N == 31)
            //                            {
            //                                Destination = DDD[7];
            //                            }
            //                            else
            //                            {
            //                                Destination = "DDD nao cadastrado";
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }

            //}
            //Console.WriteLine(Destination);

            int DDD = int.Parse(Console.ReadLine());

            switch (DDD)
            {
                case 61:
                    Console.WriteLine("Brasilia");
                    break;

                case 71:
                    Console.WriteLine("Salvador");
                    break;

                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;

                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;

                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;

                case 19:
                    Console.WriteLine("Campinas");
                    break;

                case 27:
                    Console.WriteLine("Vitoria");
                    break;

                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;

                default:
                    Console.WriteLine("DDD nao cadastrado");
                    break;
            }
        }
    }
}
