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
            b = (a % 2);
            if (b == 0)
                Console.WriteLine("Número par!");
            if (b != 0)
                Console.WriteLine("Número impar!");

        }
    }
}
