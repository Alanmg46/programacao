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
            int b = 0;
            int c = 0;
            Console.Write("Entre com dois números: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine("Números em ordem: " + a + "; " + b);
            if (b > a)
                c = b;
                b = a;
                a = c;
            Console.WriteLine("Números em ordem: " + a + "; " + b);
        }
    }
}
