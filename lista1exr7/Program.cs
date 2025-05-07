using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exr7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double milhaNautica = 1852;
            Console.Write("Milhas marítimas: ");
            double milhas = double.Parse(Console.ReadLine());
            double km = milhas * milhaNautica / 1000;
            Console.WriteLine($"{milhas} milhas marítimas = {km} km");

        }
    }
}
