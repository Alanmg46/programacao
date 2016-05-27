using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            Console.WriteLine("Equação 2º Grau");
            Console.Write(" Valor de a : ");
            a = double.Parse(Console.ReadLine());

            Console.Write(" Valor de b : ");
            b = double.Parse(Console.ReadLine());

            Console.Write(" Valor de c : ");
            c = double.Parse(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                Console.WriteLine("Existem duas raizes reais");
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x'= " + x1);
                Console.WriteLine("x''= " + x2);
            }
            else if (d == 0)
            {
                Console.WriteLine("Existem duas raizes reais e iguais.");
                x1 = -b / (a * 2);
                Console.WriteLine("x'=x''= " + x1);
            }
            else
            {
                Console.WriteLine("Nao existem raizes reais");
            }
            Console.ReadKey();

        }
    }
}

