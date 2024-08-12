using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;  // Declaração das variáveis inteiras A, B e R.

            Console.Write("Entre o valor <A>:");  // Exibe uma mensagem pedindo ao usuário para inserir o valor de A.
            A = int.Parse(Console.ReadLine());    // Lê a entrada do usuário, converte para inteiro e armazena em A.
            Console.Write("Entre o valor <B>:");  // Exibe uma mensagem pedindo ao usuário para inserir o valor de B.
            B = int.Parse(Console.ReadLine());    // Lê a entrada do usuário, converte para inteiro e armazena em B.

            R = A + B;  // Realiza a soma dos valores de A e B e armazena o resultado em R.

            Console.WriteLine();  // Pula uma linha para melhorar a legibilidade do console.
            if (R > 10)           // Verifica se o resultado da soma (R) é maior que 10.
                Console.WriteLine("Resultado = {0}", R);  // Se for maior que 10, exibe o resultado.

            Console.WriteLine();  // Pula outra linha.
            Console.Write("tecle <enter> para continuar...");  // Exibe uma mensagem pedindo ao usuário para pressionar Enter para continuar.
            Console.ReadLine();  // Aguarda o usuário pressionar Enter antes de encerrar o programa.

        }
    }
}
