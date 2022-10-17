using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_maiorMenor
{
    internal class MaiorMenor
    {
        private int numero1, numero2;

        public MaiorMenor(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;

            if (numero1 == numero2)
                Console.WriteLine("ERRO");

            else if (numero1 < numero2)
                Console.WriteLine($"Número {numero1} é o menor e número {numero2} é o maior");
            else
                Console.WriteLine($"Número {numero2} é o menor e número {numero1} é o maior");
        }

        public int Numero1 { get => numero1; set => numero1 = value; }
        public int Numero2 { get => numero2; set => numero2 = value; }
    }
}
