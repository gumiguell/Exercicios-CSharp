using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4_maisNova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            recebeDados();
        }
        public static void recebeDados()
        {
            Console.WriteLine("Exercício 4 || Pessoa mais nova");
            Console.WriteLine("                         ");
            Console.WriteLine("Digite o nome da primeira pessoa");
            string pessoa1 = Console.ReadLine();
            Console.WriteLine("Digite o ano de nascimento da primeira pessoa");
            int nascimento1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa");
            string pessoa2 = Console.ReadLine();
            Console.WriteLine("Digite o ano de nascimento da segunda pessoa");
            int nascimento2 = int.Parse(Console.ReadLine());

            Calcular calculo = new Calcular(pessoa1, pessoa2, nascimento1, nascimento2);

        }
    }
}

