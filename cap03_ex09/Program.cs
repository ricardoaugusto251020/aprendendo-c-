using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap03_ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            int MES;
            Console.WriteLine("entre o mes (numerico):");
            MES =int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (MES == 1)
                Console.WriteLine("janeiro");
            else if (MES == 2)
                Console.WriteLine("fevereiro");
            else if (MES == 3)
                Console.WriteLine("março");
            else if (MES == 4)
                Console.WriteLine("abril");
            else if (MES == 5)
                Console.WriteLine("maio");
            else if (MES == 6)
                Console.WriteLine("junho");
            else if (MES == 7)
                Console.WriteLine("julho");
            else if (MES == 8)
                Console.WriteLine("agosto");
            else if (MES == 9)
                Console.WriteLine("setembro");
            else if (MES == 10)
                Console.WriteLine("outubro");
            else if (MES == 11)
                Console.WriteLine("novembro");
            else if (MES == 12)
                Console.WriteLine("dezembro");
            else
                Console.WriteLine("mes invalido");
            Console.WriteLine();
            Console.Write("tecle <enter> para encerrar...");
            Console.ReadLine();
        }
    }
}
