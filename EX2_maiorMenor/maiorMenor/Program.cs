using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_maiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int numero1, numero2;

                Console.WriteLine("Exercício 2 || Maior e Menor");
                Console.WriteLine("                         ");
                Console.WriteLine("Digite o primeiro número");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                numero2 = int.Parse(Console.ReadLine());

                MaiorMenor maiorMenor = new MaiorMenor(numero1, numero2);
        }
    }
}
