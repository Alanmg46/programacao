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
            double a = 0;
            double b = 0;
            Console.Write("Entre com dois números: ");
            a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                b = Math.Sqrt(a);
                Console.WriteLine("A raiz quadrada de " + a + " é " + b);
            }
            else
            {
                b = (a * a);
                Console.WriteLine("O quadrado de " + a + " é " + b);
            }
        }
    }
}
