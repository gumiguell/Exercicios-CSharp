using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10_empresa
{
    internal class Calculo
    {
        private string nomeFuncionario;
        private double numVendas;
        private double comissao;

        public Calculo(string nome, double numVendas)
        {
            this.nomeFuncionario = nome;
            this.numVendas = numVendas;
        }

        public string NomeFuncionario { get => nomeFuncionario; set => nomeFuncionario = value; }
        public double NumVendas { get => numVendas; set => numVendas = value; }
        public double Comissao { get => comissao; set => comissao = value; }

        public void calculoComissao()
        {
            if (numVendas > 250)
                comissao = 1.50;
            else if (numVendas > 500)
                comissao = 2.00;
            else
                comissao = 1.00;
            
            Console.WriteLine($"{nomeFuncionario} a sua comissão é de: R${numVendas * comissao}");
        }
    }
}
