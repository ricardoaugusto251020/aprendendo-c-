using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            float  R,  A, B;

            int OPCAO;
            
            Console.Write("informe o 1o valor");
            A = float.Parse(Console.ReadLine());
            Console.Write("informe o 2o valor");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("[1] ...........................adicao");
            Console.WriteLine("[2] ...........................subtracao");
            Console.WriteLine("[3] ...........................multiplicacao");
            Console.WriteLine("[4]............................divisao");
            Console.WriteLine();
            Console.Write("escolha uma opcao -->");
            OPCAO = int.Parse(Console.ReadLine());
            //verifica se o valor é igual a 1
            if (OPCAO == 1)
            {
                R = A + B;
                Console.WriteLine("Resultado = " + R);
            }
            //verifica se o valor é igual a 2
            if (OPCAO == 2)
            {
                R = A - B;
                Console.WriteLine("Resultado = " + R);
            }
            //verifica se o valor é igual a 3
            if (OPCAO == 3) 
            {
                R = A * B;
                Console.WriteLine("Resultado = " + R);
            }

            if (OPCAO == 4)
                if (B == 0)
                    Console.WriteLine("ERRO - Divisao por zero !");
            else
                {
                    R = A / B;
                    Console.WriteLine("Resultado" + R);

                }
            Console.WriteLine();
            Console.Write("Tecle <enter> para encerrar...");
            Console.ReadLine();
        }
    }
}
