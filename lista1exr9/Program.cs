using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exr9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Diâmetro do círculo: ");
            double d = double.Parse(Console.ReadLine());
            double r = d / 2;
            double area = Math.PI * r * r;
            Console.WriteLine($"Área do círculo: {area}");

        }
    }
}
