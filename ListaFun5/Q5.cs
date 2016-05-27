using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Entre com um número: ");
            a = int.Parse(Console.ReadLine());
            if (a > 0 && a < 10.0)
                Console.WriteLine("Nota válida!");
            else
                Console.WriteLine("Nota inválida");
        }
    }
}
