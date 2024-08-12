using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C;

            // Solicita ao usuário que insira o valor do lado A e o armazena como um número de ponto flutuante (float)
            Console.Write("Informe o lado A:");
            A = float.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o valor do lado B e o armazena como um número de ponto flutuante (float)
            Console.Write("Informe o lado B:");
            B = float.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o valor do lado C e o armazena como um número de ponto flutuante (float)
            Console.Write("Informe o lado C:");
            C = float.Parse(Console.ReadLine());

            Console.WriteLine(); // Adiciona uma linha em branco para formatação

            // Verifica se os valores fornecidos satisfazem a condição para formar um triângulo
            // A soma de dois lados de um triângulo deve ser sempre maior que o terceiro lado
            if (A < B + C && B < A + C && C < A + B)
            {
                // Verifica se o triângulo é isósceles (dois lados iguais)
                if (A == B || A == C || C == B)
                    Console.WriteLine("triangulo isosceles");
                else
                    // Se nenhum lado for igual a outro, é um triângulo escaleno
                    Console.WriteLine("triangulo escaleno");
            }
            else
                // Se as condições para formar um triângulo não forem atendidas, exibe uma mensagem de erro
                Console.WriteLine("valores não formam um triângulo");

            Console.WriteLine(); // Adiciona uma linha em branco para formatação

            // Exibe uma mensagem pedindo ao usuário para pressionar <enter> para encerrar o programa
            Console.Write("Tecle <enter> para encerrar...");

            // Aguarda o usuário pressionar <enter> antes de encerrar o programa
            Console.ReadLine();


        }
    }
}
