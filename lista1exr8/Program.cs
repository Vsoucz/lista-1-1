using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exr8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatura em °C: ");
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine($"Temperatura em Fahrenheit: {f}");

        }
    }
}
