using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exr10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em dólares: ");
            double dolares = double.Parse(Console.ReadLine());
            double reais = cotacao * dolares;
            Console.WriteLine($"Valor em reais: R$ {reais}");

        }
    }
}
