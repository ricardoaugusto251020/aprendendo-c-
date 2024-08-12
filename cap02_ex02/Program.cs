using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap02_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;  // Declara três variáveis inteiras: 'A', 'B' e 'R'.

            Console.Write("entre o 1o valor:");  // Exibe uma mensagem pedindo ao usuário para inserir o primeiro valor.
            A = int.Parse(Console.ReadLine());   // Lê a entrada do usuário como uma string, converte para inteiro e armazena na variável 'A'.

            Console.Write("entre o 2o valor:");  // Exibe uma mensagem pedindo ao usuário para inserir o segundo valor.
            B = int.Parse(Console.ReadLine());   // Lê a entrada do usuário como uma string, converte para inteiro e armazena na variável 'B'.

            R = A + B;  // Realiza a soma dos valores armazenados nas variáveis 'A' e 'B', e armazena o resultado na variável 'R'.

            Console.WriteLine();  // Escreve uma linha em branco no console (opcional, para melhorar a formatação).
            Console.WriteLine("Resultado = " + R);  // Exibe o resultado da soma no console, precedido pela palavra "Resultado =".

            Console.WriteLine();  // Escreve uma linha em branco no console (opcional, para melhorar a formatação).
            Console.WriteLine("tecla <enter> para continuar...");  // Exibe uma mensagem solicitando ao usuário que pressione <enter> para continuar.
            Console.ReadLine();  // Espera que o usuário pressione <enter> antes de encerrar o programa.



        }
    }
}