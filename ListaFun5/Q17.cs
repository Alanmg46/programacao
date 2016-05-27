using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            Console.Write("Entre com o dia (DD): ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Entre com o mês (MM): ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Entre com o ano (AAAA): ");
            c = int.Parse(Console.ReadLine());
            a = a + 1;
                Console.Write("Data: ");
                Console.WriteLine(a + "/" + b + "/" + c);
        }
    }
}
