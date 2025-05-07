using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Valor {i}: ");
                soma += double.Parse(Console.ReadLine());
            }
            double media = soma / 4;
            Console.WriteLine($"Média aritmética: {media}");

        }
    }
}
