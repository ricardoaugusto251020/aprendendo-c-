using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cap02_ex01                // Define um namespace chamado 'cap02_ex01', que é um agrupamento lógico de classes.
{
    class Program                   // Declara uma classe chamada 'Program', que contém o ponto de entrada do aplicativo.
    {
        static void Main(string[] args) // O método 'Main' é o ponto de entrada do programa. É onde a execução começa.
        {
            string NOME;             // Declara uma variável do tipo string chamada 'NOME' para armazenar o nome do usuário.

            Console.Write("Entre o seu nome:"); // Exibe uma mensagem no console pedindo ao usuário para inserir seu nome.
            NOME = Console.ReadLine();          // Lê a entrada do usuário e armazena o valor na variável 'NOME'.
            Console.WriteLine("olá," + NOME);   // Exibe uma saudação personalizada no console usando o nome fornecido.

            Console.WriteLine();                // Escreve uma linha em branco no console (opcional, para melhorar a formatação).
            Console.Write("Tecle <enter> para fechar"); // Exibe uma mensagem solicitando ao usuário que pressione <enter> para fechar o programa.
            Console.ReadLine();                 // Espera o usuário pressionar <enter> antes de encerrar o programa.
        }
    }
}
