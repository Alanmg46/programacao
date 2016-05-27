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
            int aux = 0;
            Console.Write("Entre com três números: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c && b > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (a > b && a > c && b < c)
            {
                aux = a;
                a = b;
                c = aux;
            }
            if (a < c && a < b && c > b)
            {
                aux = c;
                a = c;
                c = aux;
            }
            Console.WriteLine("Números em ordem decrescente: " + c + "; " + b + "; " + a);
        }
    }
}
