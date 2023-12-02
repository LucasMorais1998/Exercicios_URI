using System;

namespace _1828.Bazinga_
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int programa = 0;
            int aux = T;
            T = programa;
            programa = aux;

            while (programa > T)
            {
                T++;
                string[] Escolhas = Console.ReadLine().Split(' ');

                string Sheldon = (Escolhas[0]);
                string Raj = (Escolhas[1]);

                switch (Sheldon)
                {
                    case "tesoura":
                        if (Raj == "papel")
                        {
                            Console.WriteLine("Caso #" + T + ": Bazinga!");
                        }
                        else
                        {
                            if (Raj == "pedra")
                            {
                                Console.WriteLine("Caso #" + T + ": Raj trapaceou!");
                            }
                            else
                            {
                                if (Raj == "tesoura")
                                {
                                    Console.WriteLine("Caso #" + T + ": De novo!");
                                }
                                else
                                {
                                    if (Raj == "lagarto")
                                    {
                                        Console.WriteLine("Caso #" + T + ": Bazinga!");
                                    }
                                    else
                                    {
                                        if (Raj == "Spock")
                                        {
                                            Console.WriteLine("Caso #" + T + ": Raj trapaceou!");
                                        }
                                    }
                                }
                            }
                        }
                        break;

                    case "papel":
                        if (Raj == "papel")
                        {
                            Console.WriteLine("Caso #" + T + ": De novo!");
                        }
                        else
                        {
                            if (Raj == "pedra")
                            {
                                Console.WriteLine("Caso #" + T + ": Bazinga!");
                            }
                            else
                            {
                                if (Raj == "tesoura")
                                {
                                    Console.WriteLine("Caso #" + T + ": Raj trapaceou!");
                                }
                                else
                                {
                                    if (Raj == "lagarto")
                                    {
                                        Console.WriteLine("Caso #" + T + ": Raj trapaceou!");
                                    }
                                    else
                                    {
                                        if (Raj == "Spock")
                                        {
                                            Console.WriteLine("Caso #" + T + ": Bazinga!");
                                        }
                                    }
                                }
                            }
                        }
                        break;

                    case "pedra":
                        if (Raj == "papel")
                        {
                            Console.WriteLine("Caso #" + T + ": Raj trapaceou!");
                        }
                        else
                        {
                            if (Raj == "pedra")
                            {
                                Console.WriteLine("Caso #" + T + ": De novo!");
                            }
                            else
                            {
                                if (Raj == "tesoura")
                                {
                                    Console.WriteLine("Caso #" + T + ": Bazinga!");
                                }
                                else
                                {
                                    if (Raj == "lagarto")
                                    {
                                        Console.WriteLine("Caso #" + T + ": Bazinga!");
                                    }
                                    else
                                    {
                                        if (Raj == "Spock")
                                        {
                                            Console.WriteLine("Caso #" + T + ": Raj trapaceou!");
                                        }
                                    }
                                }
                            }
                        }
                        break;

                    case "lagarto":
                        if (Raj == "papel")
                        {
                            Console.WriteLine("Caso #" + T + ": Bazinga!");
                        }
                        else
                        {
                            if (Raj == "pedra")
                            {
                                Console.WriteLine("Caso #" + T + ": Raj trapaceou!");
                            }
                            else
                            {
                                if (Raj == "tesoura")
                                {
                                    Console.WriteLine("Caso #" + T + ": Raj trapaceou!");
                                }
                                else
                                {
                                    if (Raj == "lagarto")
                                    {
                                        Console.WriteLine("Caso #" + T + ": De novo!");
                                    }
                                    else
                                    {
                                        if (Raj == "Spock")
                                        {
                                            Console.WriteLine("Caso #" + T + ": Bazinga!");
                                        }
                                    }
                                }
                            }
                        }
                        break;

                    case "Spock":
                        if (Raj == "papel")
                        {
                            Console.WriteLine("Caso #" + T + ": Raj trapaceou!");
                        }
                        else
                        {
                            if (Raj == "pedra")
                            {
                                Console.WriteLine("Caso #" + T + ": Bazinga!");
                            }
                            else
                            {
                                if (Raj == "tesoura")
                                {
                                    Console.WriteLine("Caso #" + T + ": Bazinga!");
                                }
                                else
                                {
                                    if (Raj == "lagarto")
                                    {
                                        Console.WriteLine("Caso #" + T + ": Raj trapaceou!");
                                    }
                                    else
                                    {
                                        if (Raj == "Spock")
                                        {
                                            Console.WriteLine("Caso #" + T + ": De novo!");
                                        }
                                    }
                                }
                            }
                        }
                        break;

                    default:
                        break;

                }
            }
                                  
                       
        }
    }
}
