﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex12
{
    class Program
    {
        static void Main(string[] args)
        {    //joga numeros aleatórios de 1 até 5
            int NR, PEDIDO;
            Random RANDOMICO = new Random();
            NR = RANDOMICO.Next(1, 6);

            Console.Write("Entre um numero entre 1 e 5: ");
            PEDIDO = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (PEDIDO == NR)
                Console.WriteLine("Acertou - foi sorteado: {0}. ", NR);
            else
                Console.WriteLine("Errou - foi sorteado: {0}. ", NR);

            Console.WriteLine();
            Console.Write("tecle <enter> para encerrar");
            Console.ReadLine();
        }
    }
}
