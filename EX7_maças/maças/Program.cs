using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7_maças
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 7 || Maçãs");
            Console.WriteLine("                         ");
            Console.Write("Quantas maçãs você deseja comprar? ");
            double macas = double.Parse(Console.ReadLine());

            Compra compra = new Compra(macas);

            compra.Calculo();

        }
    }
}
