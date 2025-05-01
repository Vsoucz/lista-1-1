using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal;
             double area;

            Console.Write("digite valor da diagonal");
            diagonal =

                double.Parse(Console.ReadLine());

          area = diagonal * diagonal / 2;
            Console.WriteLine("o valor da area do quadrado de diagonal {0} e area {1}", diagonal, area);
          
        }
    }
}
