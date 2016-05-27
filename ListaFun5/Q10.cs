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
            int d = 0;
            int e = 0;
            Console.Write("Entre cinco números: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
                Console.WriteLine("Número maior: " + a);
            if (b > a && b > c && b > d && b > e)
                Console.WriteLine("Número maior: " + b);
            if (c > a && c > b && c > d && c > e)
                Console.WriteLine("Número maior: " + c);
            if (d > a && d > b && d > c && d > e)
                Console.WriteLine("Número maior: " + d);
            if (e > a && e > b && e > c && e > d)
                Console.WriteLine("Número maior: " + e);
        }
    }
}
