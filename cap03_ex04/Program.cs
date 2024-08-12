using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int CODIGO;

            // Exibe uma mensagem pedindo ao usuário para entrar com um código de acesso
            Console.Write("Entre o codigo de acesso:");

            // Lê a entrada do usuário, converte a string digitada para um número inteiro e armazena em 'CODIGO'
            CODIGO = int.Parse(Console.ReadLine());

            Console.WriteLine(); // Adiciona uma linha em branco para formatação

            // Verifica se o valor de 'CODIGO' é igual a 1, 2 ou 3
            if (CODIGO == 1 || CODIGO == 2 || CODIGO == 3)
            {
                // Verifica se 'CODIGO' é igual a 1 e, se for, exibe "um"
                if (CODIGO == 1)
                    Console.WriteLine("um");

                // Verifica se 'CODIGO' é igual a 2 e, se for, exibe "dois"
                if (CODIGO == 2)
                    Console.WriteLine("dois");

                // Verifica se 'CODIGO' é igual a 3 e, se for, exibe "três"
                if (CODIGO == 3)
                    Console.WriteLine("três");
            }
            else
                // Se o código não for 1, 2 ou 3, exibe "Código inválido"
                Console.WriteLine("Código inválido");

            Console.WriteLine(); // Adiciona uma linha em branco para formatação

            // Exibe uma mensagem pedindo ao usuário para pressionar <enter> para encerrar o programa
            Console.Write("Tecle <enter> para encerrar...");

            // Aguarda o usuário pressionar <enter> antes de encerrar o programa
            Console.ReadLine();

        }
    }
}
