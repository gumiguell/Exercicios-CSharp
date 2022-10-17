using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8_juros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 8 || Juros e Parcelas");
            Console.WriteLine("                         ");
            Console.WriteLine("Digite o valor do empréstimo");
            double valorEmprestimo = double.Parse(Console.ReadLine());
            Console.WriteLine("Em quantas parcelas você deseja pagar?");
            double parcelas = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");


            Parcelamento parcelamento = new Parcelamento(valorEmprestimo, parcelas);
            parcelamento.calculoJuros();
            parcelamento.calculoParcelas();
            parcelamento.calculoValorFinal();
            parcelamento.exibirDados();

        }
    }
}
