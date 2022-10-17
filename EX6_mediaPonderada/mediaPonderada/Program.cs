using System;

namespace EX6_mediaPonderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, ra;

            Console.WriteLine("Exercício 6 || Média Ponderada");
            Console.WriteLine("                           ");
            Console.WriteLine("Digite seu RA");
            ra = double.Parse(Console.ReadLine());
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
                Console.WriteLine($"{ra} sua média é: {n.calcularMedia()}");
                Console.WriteLine(n.aprovadoReprovado());
            }
        }
    }
}
