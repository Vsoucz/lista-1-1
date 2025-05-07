using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1erx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor 1: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.Write("Valor 2: ");
            double v2 = double.Parse(Console.ReadLine());
            double mediaGeom = Math.Sqrt(v1 * v2);
            Console.WriteLine($"Média geométrica: {mediaGeom}");

        }
    }
}
