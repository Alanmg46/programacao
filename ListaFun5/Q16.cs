using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        double a = 0;
        Console.Write("Entre com um ângulo: ");
        a = double.Parse(Console.ReadLine());
        if (a > 0 && a <= 360)
        {
            if (a >= 0 && a <= 90)
            {
                Console.WriteLine("Primeiro quadrante");
            }
            else if (a > 90 && a <= 180)
            {
                Console.WriteLine("Segundo quadrante");
            }
            else if (a > 180 && a <= 270)
            {
                Console.WriteLine("Terceiro quadrante");
            }
            else
            {
                Console.WriteLine("Quarto quadrante");
            }
        }

        else if (a > 360)
        {
            Console.WriteLine("O angulo deu uma volta");
        }
        }
    }