using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4_maisNova
{
    internal class Calcular
    {
        private string pessoa1;
        private string pessoa2;
        private int nascimento1;
        private int nascimento2;

        //Construtor da classe
        public Calcular(string p1, string p2, int n1, int n2)
        {
            Pessoa1 = p1;
            Pessoa2 = p2;
            Nascimento1 = n1;
            Nascimento2 = n2;

            mostrarDados();

            if (Nascimento1 == Nascimento2)
                Console.WriteLine($"{Pessoa1} tem a mesma idade que {Pessoa2}");

            else if (Nascimento1 < Nascimento2)
                Console.WriteLine($"{Pessoa2} é mais novo(a) que {Pessoa1}");
            else
                Console.WriteLine($"{Pessoa1} é mais novo(a) que {Pessoa2}");
        }

        public string Pessoa1 { get => pessoa1; set => pessoa1 = value; }
        public string Pessoa2 { get => pessoa2; set => pessoa2 = value; }
        public int Nascimento1 { get => nascimento1; set => nascimento1 = value; }
        public int Nascimento2 { get => nascimento2; set => nascimento2 = value; }

        public void mostrarDados()
        {
            Console.WriteLine("------------------");
            Console.WriteLine(Pessoa1);
            Console.WriteLine(Nascimento1);
            Console.WriteLine(Pessoa2);
            Console.WriteLine(Nascimento2);
        }

    }
}
