using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;  // Declaração das variáveis inteiras A, B e R.

            Console.Write("Entre o valor <A>:");  // Exibe uma mensagem solicitando ao usuário para inserir o valor de A.
            A = int.Parse(Console.ReadLine());    // Lê a entrada do usuário, converte para inteiro e armazena em A.
            Console.Write("Entre o valor <B>:");  // Exibe uma mensagem solicitando ao usuário para inserir o valor de B.
            B = int.Parse(Console.ReadLine());    // Lê a entrada do usuário, converte para inteiro e armazena em B.

            R = A + B;  // Realiza a soma dos valores de A e B, armazenando o resultado em R.

            Console.WriteLine();  // Adiciona uma linha em branco no console para espaçamento.
            if (R > 10)  // Verifica se o valor de R é maior que 10.
                Console.WriteLine("Resultado ultrapassa dez.");  // Se for maior que 10, exibe uma mensagem indicando que o resultado ultrapassa dez.
            else  // Caso contrário, se R for menor ou igual a 10,
                Console.WriteLine("Resultado não ultrapassa dez.");  // Exibe uma mensagem indicando que o resultado não ultrapassa dez.

            Console.WriteLine();  // Adiciona outra linha em branco no console.
            Console.Write("tecle <enter> para continuar...");  // Exibe uma mensagem pedindo ao usuário para pressionar Enter para encerrar o programa.
            Console.ReadLine();  // Aguarda o usuário pressionar Enter antes de encerrar o programa.


        }
    }
}
