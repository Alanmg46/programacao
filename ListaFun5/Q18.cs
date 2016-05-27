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
            int aa = 0;
            int bb = 0;
            int cc = 0;
            Console.Write("Entre com o dia (DD): ");
            a = int.Parse(Console.ReadLine());
            aa = int.Parse(Console.ReadLine());
            Console.Write("Entre com o mês (MM): ");
            b = int.Parse(Console.ReadLine());
            bb = int.Parse(Console.ReadLine());
            Console.Write("Entre com o ano (AAAA): ");
            c = int.Parse(Console.ReadLine());
            cc = int.Parse(Console.ReadLine());
            if (a > aa && b > bb & c > cc)
            {
                Console.WriteLine("Data maior: " + a + "/" + b + "/" + c);
            }
            else if (aa > a && bb > b && cc > c)
            {
                Console.WriteLine("Data maior: " + aa + "/" + bb + "/" + cc);
            }
        }
    }
}
