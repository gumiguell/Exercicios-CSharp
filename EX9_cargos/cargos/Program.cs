using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9_cargos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 9 || Cargos");
            Console.WriteLine("                         ");
            Console.WriteLine("Qual o código do seu cargo?     101 - Gerente | 102 - Engenheiro | 103 - Técnico");
            double codCargo = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu salário?");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            Tabela tabela = new Tabela(codCargo, salario);
            tabela.verificarCargo();
            tabela.calcularSalario();

        }
    }
}
