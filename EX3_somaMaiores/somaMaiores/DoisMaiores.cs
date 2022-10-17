using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_somaMaiores
{
    internal class DoisMaiores
    {
        private int numero1, numero2, numero3;

        public DoisMaiores(int numero1, int numero2, int numero3)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            this.numero3 = numero3;

            soma();
        }

        public int Numero1 { get => numero1; set => numero1 = value; }
        public int Numero2 { get => numero2; set => numero2 = value; }
        public int Numero3 { get => numero3; set => numero3 = value; }

        public void soma()
        {
            if ((numero1 == numero2) || (numero2 == numero3) || (numero3 == numero1))
                Console.WriteLine("-ERRO- Os números não podem ser iguais");
            else if ((numero1 >= numero2 || numero2 > numero3) && (numero2 >= numero1 || numero1 > numero3))
                Console.WriteLine($"A soma dos dois maiores números é:{numero1 + numero2}");
            else if ((numero2 >= numero3 || numero3 > numero1) && (numero3 >= numero2 || numero2 > numero1))
                Console.WriteLine($"A soma dos dois maiores números é:{numero2 + numero3}");
            else if ((numero1 >= numero3 || numero3 > numero2) && (numero3 >= numero1 || numero1 > numero2))
                Console.WriteLine($"A soma dos dois maiores números é:{numero1 + numero3}");
        }
    }
}
