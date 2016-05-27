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
            Console.Write("Entre a nota N1 e N2: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = (a * 2 + b * 3 / 5);
            if (c > 60)
                Console.WriteLine("Aprovado!");
            else
                Console.WriteLine("REPROVADO! FRACASSADO");
        }
    }
}
