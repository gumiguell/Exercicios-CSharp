using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7_maças
{
    internal class Compra
    {
        private double macas, custo;
        
        public Compra(double macas)
        {
            this.macas = macas;
        }

        public double Macas { get => macas; set => macas = value; }
        public double Custo { get => custo; set => custo = value; }

        public void Calculo()
        {
            if (macas >= 12)
            {
                custo = macas * 1.00; }
            else
            {
                custo = macas * 1.30; }

            Console.WriteLine($"O custo das maçãs é de R${custo}");
        }
    }
}
