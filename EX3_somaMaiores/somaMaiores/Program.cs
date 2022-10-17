using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_somaMaiores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;

            Console.WriteLine("Exercício 3 || Soma dos maiores");
            Console.WriteLine("                         ");
            Console.WriteLine("Digite o primeiro número");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            numero3 = int.Parse(Console.ReadLine());

            DoisMaiores doisMaiores = new DoisMaiores(numero1, numero2, numero3);
        }
    }
}
