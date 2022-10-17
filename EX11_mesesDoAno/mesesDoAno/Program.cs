using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11_mesesDoAno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 11 || Meses do ano");
            Console.WriteLine("                         ");

            Meses calendario = new Meses();
            calendario.Calendario();
        }
    }
}
