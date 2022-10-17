using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1_OrdemCrescente
{
    internal class OrdemCrescente
    {
        private int numero1, numero2;

        public OrdemCrescente(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;

            if (numero1 == numero2)
                Console.WriteLine("ERRO");

            else if (numero1 < numero2)
                Console.WriteLine($"Ordem crescente: {numero1}, {numero2}");
            else
                Console.WriteLine($"Ordem crescente: {numero2}, {numero1}");
        }

        public int Numero1 { get => numero1; set => numero1 = value; }
        public int Numero2 { get => numero2; set => numero2 = value; }
    }
}
