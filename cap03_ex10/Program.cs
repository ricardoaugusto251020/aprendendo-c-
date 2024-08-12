using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int MES;

            Console.Write("entre o mes (numerico):");
            MES = int.Parse(Console.ReadLine());

            Console.WriteLine();
            //testa o valor contido em uma variável, realizando uma comparação com cada uma das opções.
            switch (MES)

            {   //O case é uma forma de reduzir a complexidade de vários if.
                case 1: Console.WriteLine("janeiro");break; //O break encerra a instrução de iteração ou instrução switch mais próxima.
                case 2: Console.WriteLine("fevereiro"); break;
                case 3: Console.WriteLine("março"); break;
                case 4: Console.WriteLine("abril");break;
                case 5: Console.WriteLine("maio"); break;
                case 6: Console.WriteLine("junho");break;
                case 7: Console.WriteLine("julho");break;
                case 8: Console.WriteLine("agosto");break;
                case 9: Console.WriteLine("setembro"); break;
                case 10: Console.WriteLine("outubro"); break;
                case 11: Console.WriteLine("novembro"); break;
                case 12: Console.WriteLine("dezembro"); break;
                default: Console.WriteLine("mes invalido"); break;

                }
                Console.WriteLine();
                Console.Write("tecle <enter>  para encerrar...");
                Console.ReadLine();
        }
    }
}
