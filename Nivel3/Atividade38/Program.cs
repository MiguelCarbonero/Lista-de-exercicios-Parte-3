﻿using System;

namespace Atividade38
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            int N;
            int E = 0;
            int hora;
            int excede;
            bool continuar = true;
            string opcao;


            do
            {
                E = 0;
                hora = 10;
                excede = hora * 2;


                Console.Write("Digite o código do operario ");
                C = Convert.ToInt32(Console.ReadLine());


                Console.Write("Digite o numero de horas trabalhadas ");
                N = Convert.ToInt32(Console.ReadLine());


                if (N > 50)
                {
                    E = N - 50;
                }


                Console.WriteLine("\nID " + C + "\nSalario " + (N * hora) + "\nSalario excedente " + (E * excede) + "\nSalario total " + (E * excede + N * hora) + "\n\nDeseja encerrar o programa?(s/N) ");
                opcao = Convert.ToString(Console.ReadLine());
                if (opcao == "s" || opcao == "S")
                {
                    continuar = false;
                }


            } while (continuar);
            Console.ReadKey();
        }
    }
}
