using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5_apNota
{
    internal class Nota
    {
        // Atributos da classe
        private double notaUm, notaDois, notaTres;
        private bool houveErro;
        private double resultado;
        private string reprovado;
        private string aprovado;

        public double NotaUm { get => notaUm; set => notaUm = value; }
        public double NotaDois { get => notaDois; set => notaDois = value; }
        public double NotaTres { get => notaTres; set => notaTres = value; }
        public bool HouveErro { get => houveErro; set => houveErro = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        public string Reprovado { get => reprovado; set => reprovado = value; }
        public string Aprovado { get => aprovado; set => aprovado = value; }


        //Construtor da classe
        //C# o construtor tem o mesmo nome da classe

        public Nota(double n1, double n2, double n3)
        {
            NotaUm = n1;
            NotaDois = n2;
            NotaTres = n3;
            HouveErro = false;
        }


        public bool verificaNotas()
        {
            if( (NotaUm < 0) || (NotaDois > 10))
            {
                HouveErro = true;
                return HouveErro;
            }

            return HouveErro;
        }
        public double calcularMedia()
        {
            Resultado = (NotaUm + NotaDois + NotaTres) / 3;
            return Resultado;

        }

        public string aprovadoReprovado()
        {
            if (Resultado >= 5)
            {
                return "APROVADO";
            }

            else
            { 
                return "REPROVADO";

            }
        }

    }
}
