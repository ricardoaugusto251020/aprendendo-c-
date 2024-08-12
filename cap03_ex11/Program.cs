using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string MES;

            Console.Write("entre o mês (por extenso)");
            //O que for escrito vai ser armazenado na variável MES.
            MES = Console.ReadLine();

            Console.WriteLine();
            switch (MES)
            {   //determina os casos para escolher e quando escolhe um caso aparece o mês
                case "um": Console.WriteLine("janeiro");break;
                case "dois": Console.WriteLine("fevereiro");break;
                case "tres": Console.WriteLine("março");break;
                case "quatro": Console.WriteLine("abril"); break;
                case "cinco": Console.WriteLine("maio"); break;
                case "seis": Console.WriteLine("junho"); break;
                case "sete": Console.WriteLine("julho"); break;
                case "oito": Console.WriteLine("agosto"); break;
                case "nove": Console.WriteLine("setembro"); break;
                case "dez": Console.WriteLine("outubro"); break;
                case "onze": Console.WriteLine("novembro"); break;
                case "doze": Console.WriteLine("dezembro"); break;
                default: Console.WriteLine("mês inválido");break;

            }
            Console.WriteLine();
            Console.Write("tecle <enter> para encerrar...");
            Console.ReadLine();

        }
    }
}
