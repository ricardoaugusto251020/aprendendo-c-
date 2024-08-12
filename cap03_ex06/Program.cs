using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, X;

            // Solicita ao usuário que insira o valor de 'A' e o armazena como um número de ponto flutuante (float)
            Console.Write("Entre o valor <A>:");
            A = float.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o valor de 'B' e o armazena como um número de ponto flutuante (float)
            Console.Write("Entre o valor <B>:");
            B = float.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o valor de 'C' e o armazena como um número de ponto flutuante (float)
            Console.Write("Entre o valor <C>");
            C = float.Parse(Console.ReadLine());

            Console.WriteLine(); // Adiciona uma linha em branco para formatação

            // Verifica se 'C' NÃO é maior que 5. O operador ! nega a condição, então !(C > 5) será verdadeiro se 'C' for menor ou igual a 5.
            if (!(C > 5))
                // Se 'C' for menor ou igual a 5, 'X' é calculado como a soma de 'A' e 'B' multiplicada por 'C'
                X = (A + B) * C;
            else
                // Se 'C' for maior que 5, 'X' é calculado como a diferença entre 'A' e 'B' multiplicada por 'C'
                X = (A - B) * C;

            // Exibe o valor calculado de 'X'
            Console.WriteLine("O Resultado de X equivale a:" + X);

            Console.WriteLine(); // Adiciona uma linha em branco para formatação

            // Exibe uma mensagem pedindo ao usuário para pressionar <enter> para encerrar o programa
            Console.Write("Tecle <enter> para encerrar");

            // Aguarda o usuário pressionar <enter> antes de encerrar o programa
            Console.ReadLine();


        }
    }
}
