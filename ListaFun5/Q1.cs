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
            Console.Write("Entre com um número: ");
            a = int.Parse(Console.ReadLine());
            b = (a % 5);
            if (b == 0)
                Console.WriteLine("Número multiplo de 5!");
            else
                Console.WriteLine("Número não multiplo de 5!");
        }
    }
}
