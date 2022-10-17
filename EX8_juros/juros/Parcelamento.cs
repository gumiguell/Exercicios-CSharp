using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8_juros
{
    internal class Parcelamento
    {
        private double valorEmprestimo, parcelas, juros, valorParcelas, valorFinal;

        public Parcelamento(double valorEmprestimo, double parcelas)
        {
            this.valorEmprestimo = valorEmprestimo;
            this.parcelas = parcelas;
        }

        public double ValorEmprestimo { get => valorEmprestimo; set => valorEmprestimo = value; }
        public double Parcelas { get => parcelas; set => parcelas = value; }
        public double Juros { get => juros; set => juros = value; }
        public double ValorParcelas { get => valorParcelas; set => valorParcelas = value; }
        public double ValorFinal { get => valorFinal; set => valorFinal = value; }

        public void calculoJuros()
        {
            if ((parcelas == 3) || (parcelas == 4) || (parcelas == 5) || (parcelas == 6))
                juros = 6;
            else if ((parcelas == 7) || (parcelas == 8) || (parcelas == 9))
                juros = 8;
            else if ((parcelas == 10) || (parcelas == 11) || (parcelas == 12))
                juros = 10;
        }

        public void calculoParcelas()
        {
            if (juros == 6)
                valorParcelas = valorEmprestimo / parcelas * 1.06;
            else if (juros == 8)
                valorParcelas = valorEmprestimo / parcelas * 1.08;
            else if (juros == 10)
                valorParcelas = valorEmprestimo / parcelas * 1.10;
        }
        public void calculoValorFinal()
        {
            if (juros == 6)
                valorFinal = valorEmprestimo * 1.06;
            else if (juros == 8)
                valorFinal = valorEmprestimo * 1.08;
            else if (juros == 10)
                valorFinal = valorEmprestimo * 1.10;
        }

        public void exibirDados()
        {
            if (parcelas < 3)
                Console.WriteLine("- ERRO - O numero mínimo de parcelas é 3");
            else if (parcelas > 12)
                Console.WriteLine("- ERRO - O número máximo de parcelas é 12");
            else
            {
                Console.WriteLine($"- Valor do empréstimo: {valorEmprestimo}");
                Console.WriteLine("                         ");
                Console.WriteLine($"- Número de parcelas: {parcelas}");
                Console.WriteLine("                         ");
                Console.WriteLine($"- Valor de cada parcela: {valorParcelas}");
                Console.WriteLine("                         ");
                Console.WriteLine($"- Valor do empréstimo com juros: {valorFinal}. Juros de {juros}%");
                Console.WriteLine("                         ");
            }
        }
    }
}
