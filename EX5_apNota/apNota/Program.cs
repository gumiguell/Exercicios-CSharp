using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5_apNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3;

            Console.WriteLine("Exercício 5 || Média Aritmética");
            Console.WriteLine("                           ");
            Console.WriteLine("Digite a primeira nota");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            nota3 = double.Parse(Console.ReadLine());

            Nota n = new Nota(nota1, nota2, nota3);
            
            if (n.verificaNotas() == true)
            {
                Console.WriteLine("Opa! Algo está errado");
            }

            else
            {
                Console.WriteLine($"Média: {n.calcularMedia()}");
                Console.WriteLine(n.aprovadoReprovado());
            }
        }
    }
}
