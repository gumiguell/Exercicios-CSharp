using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1_OrdemCrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Exercício 1 || Ordem Crescente");
            Console.WriteLine("                         ");
            Console.WriteLine("Digite o primeiro número");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            numero2 = int.Parse(Console.ReadLine());

            OrdemCrescente ordem = new OrdemCrescente(numero1, numero2);
            

        }
    }
}
