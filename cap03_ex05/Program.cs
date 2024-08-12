using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME1, NOME2, SEXO1, SEXO2;

            // Solicita ao usuário que insira o 1º nome e o armazena em 'NOME1'
            Console.Write("Entre o 1o.nome ..............:");
            NOME1 = Console.ReadLine();

            // Solicita ao usuário que insira o sexo do 1º nome e o armazena em 'SEXO1'
            Console.Write("Entre o sexo do 1o.nome ..............:");
            SEXO1 = Console.ReadLine();

            // Solicita ao usuário que insira o 2º nome e o armazena em 'NOME2'
            Console.Write("Entre o 2o.nome ..............:");
            NOME2 = Console.ReadLine();

            // Solicita ao usuário que insira o sexo do 2º nome e o armazena em 'SEXO2'
            Console.Write("Entre o sexo do 2o.nome ..............:");
            SEXO2 = Console.ReadLine();

            Console.WriteLine(); // Adiciona uma linha em branco para formatação

            // Verifica se um dos dois sexos é "M" (masculino), mas não ambos. 
            // O operador ^ (XOR) retorna verdadeiro se apenas um dos operandos for verdadeiro.
            if (SEXO1 == "M" ^ SEXO2 == "M")
                // Se a condição for verdadeira, exibe que 'NOME1' dança com 'NOME2'
                Console.WriteLine(NOME1 + " dança com " + NOME2);
            else
                // Se a condição for falsa (ambos têm o mesmo sexo ou ambos têm sexo diferente de "M"), exibe que 'NOME1' não dança com 'NOME2'
                Console.WriteLine(NOME1 + " nao dança com " + NOME2);

            Console.WriteLine(); // Adiciona uma linha em branco para formatação

            // Exibe uma mensagem pedindo ao usuário para pressionar <enter> para encerrar o programa
            Console.Write("Tecle <enter> para encerrar...");

            // Aguarda o usuário pressionar <enter> antes de encerrar o programa
            Console.ReadLine();

        }
    }
}
