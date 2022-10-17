using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10_empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 10 || Comissão");
            Console.WriteLine("                         ");
            Console.WriteLine("Qual o seu nome?");
            string nomeFuncionario = (Console.ReadLine());
            Console.WriteLine("Quantos produtos você vendeu?");
            double numVendas = double.Parse(Console.ReadLine());

            Calculo calculo = new Calculo(nomeFuncionario, numVendas);
            calculo.calculoComissao();
        }
    }
}
