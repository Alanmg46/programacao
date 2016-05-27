using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
        double a = 0;
        double b = 0;
        double c = 0;
        Console.WriteLine("Entre com os lados do triângulo: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine("Forma um triângulo!");
        else
            Console.WriteLine("Não forma!");
    }
}

