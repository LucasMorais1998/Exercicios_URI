using System;

namespace _1049.Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine(); 
            string B = Console.ReadLine();
            string C = Console.ReadLine();
            string X = "Null";

            switch (A)
            {
                case "vertebrado":
                    if (B == "ave")
                    {
                        if (C == "carnivoro")
                        {
                            X = "aguia";
                        }
                        else
                        {
                            if (C == "onivoro")
                            {
                                X = "pomba";
                            }
                        }
                    }
                    else
                    {
                        if (B == "mamifero")
                        {
                            if (C == "onivoro")
                            {
                                X = "homem";
                            }
                            else
                            {
                                if (C == "herbivoro")
                                {
                                    X = "vaca";
                                }
                            }
                        }
                    }
                    break;

                case "invertebrado":
                    if (B == "inseto")
                    {
                        if (C == "hematofago")
                        {
                            X = "pulga";
                        }
                        else
                        {
                            if (C == "herbivoro")
                            {
                                X = "lagarta";
                            }
                        }
                    }
                    else
                    {
                        if (B == "anelideo")
                        {
                            if (C == "hematofago")
                            {
                                X = "sanguessuga";
                            }
                            else
                            {
                                if (C == "onivoro")
                                {
                                    X = "minhoca";
                                }
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
            Console.WriteLine(X);
        }
    }
}
