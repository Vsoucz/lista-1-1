using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1erx11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor de X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Valor de Y: ");
            double y = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(x, y);
            Console.WriteLine($"X elevado a Y = {resultado}");

        }
    }
}
