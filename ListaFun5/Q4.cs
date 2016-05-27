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
            Console.Write("Entre com um número: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("Números maior: " + a);
            if (b > a && b > c)
                Console.WriteLine("Número maior: " + b);
            if (c > a && c > b)
                Console.WriteLine("Número maior: " + c);
        }
    }
}
