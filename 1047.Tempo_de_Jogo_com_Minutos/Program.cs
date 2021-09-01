using System;

namespace _1047.Tempo_de_Jogo_com_Minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int HrInicial = int.Parse(vet[0]);
            int MinInicial = int.Parse(vet[1]);
            int HrFinal = int.Parse(vet[2]);
            int MinFinal = int.Parse(vet[3]);

            int hora;
            int min = 0;

            if (HrInicial > HrFinal && MinInicial > MinFinal)
            {
                hora = 24 - (HrInicial - HrFinal);
                min = 60 - (MinInicial - MinFinal);
            }
            else
            {
                if (HrInicial > HrFinal && MinInicial < MinFinal)
                {
                    hora = 24 - (HrInicial - HrFinal);
                    min = (MinFinal - MinInicial);
                }
                else
                {
                    if (HrInicial < HrFinal && MinInicial > MinFinal)
                    {
                        hora = (HrFinal - HrInicial);
                        min = 60 - (MinInicial - MinFinal);
                        hora--;
                    }
                    else
                    {
                        if (HrInicial < HrFinal && MinInicial < MinFinal)
                        {
                            hora = (HrFinal - HrInicial);
                            min = (MinFinal - MinInicial);
                        }
                        else
                        {
                            if (HrInicial > HrFinal && MinInicial == MinFinal)
                            {
                                hora = 24 - (HrInicial - HrFinal);
                                min = 0;
                            }
                            else
                            {
                                if (HrInicial < HrFinal && MinInicial == MinFinal)
                                {
                                    hora = (HrFinal - HrInicial);
                                    min = 0;
                                }
                                else
                                {
                                    if (HrInicial == HrFinal && MinInicial > MinFinal)
                                    {
                                        hora = 24;
                                        min = 60 - (MinInicial - MinFinal);
                                    }
                                    else
                                    {
                                        if (HrInicial == HrFinal && MinInicial < MinFinal)
                                        {
                                            hora = 24;
                                            min = (MinFinal - MinInicial);
                                        }
                                        else
                                        {
                                            hora = 24;
                                            min = 0;
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + min + " MINUTO(S)");

            }
        }
    }
}

