using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo;
            double altura;
            double area;

            Console.Write("digigite o valor da base do triangulo");
            baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("digite o valor da altura do triangulo");
            altura = double.Parse(Console.ReadLine());

          area = altura * baseTriangulo/2;

            Console.WriteLine(" a area da baseTriangulo {0}, altura {1} e area {2}");
        }
    }
}
