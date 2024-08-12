using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMERO;  // Declaração da variável inteira NUMERO.

            Console.Write("Entre um valor:");  // Exibe uma mensagem solicitando ao usuário para inserir um valor.
            NUMERO = int.Parse(Console.ReadLine());  // Lê a entrada do usuário, converte para inteiro e armazena em NUMERO.

            Console.WriteLine();  // Adiciona uma linha em branco no console para espaçamento.
            if (NUMERO >= 20 && NUMERO <= 90)  // Verifica se o valor de NUMERO está entre 20 e 90, inclusive.
                Console.WriteLine("O valor está entre 20 e 90");  // Se estiver no intervalo, exibe uma mensagem confirmando.
            else  // Caso contrário, se NUMERO estiver fora do intervalo de 20 a 90,
                Console.WriteLine("O valor não está entre 20 e 90");  // Exibe uma mensagem indicando que o valor está fora do intervalo.

            Console.WriteLine();  // Adiciona outra linha em branco no console.
            Console.Write("Tecle <enter> para encerrar...");  // Exibe uma mensagem pedindo ao usuário para pressionar Enter antes de encerrar o programa.
            Console.ReadLine();  // Aguarda o usuário pressionar Enter antes de encerrar o programa.


        }
    }
}
