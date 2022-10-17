using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9_cargos
{
    internal class Tabela
    {
        private double codCargo;
        private string cargo;
        private double salario;
        private double aumentoSalario;
        private double porcentagemAumento;
        private string gerente, engenheiro, técnico;

        public double CodCargo { get => codCargo; set => codCargo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public double AumentoSalario { get => aumentoSalario; set => aumentoSalario = value; }
        public double PorcentagemAumento { get => porcentagemAumento; set => porcentagemAumento = value; }
        public string Gerente { get => gerente; set => gerente = value; }
        public string Engenheiro { get => engenheiro; set => engenheiro = value; }
        public string Técnico { get => técnico; set => técnico = value; }

        public Tabela(double codCargo, double salario)
        {
            this.codCargo = codCargo;
            this.salario = salario;
        }

        public void verificarCargo()
        {
            if (codCargo == 101)
                cargo = "Gerente";
            else if (codCargo == 102)
                cargo = "Engenheiro";
            else if (codCargo == 103)
                cargo = "Técnico";
            else if (codCargo != 101)
                cargo = "Cargo externo";
            else if (codCargo != 102)
                cargo = "Cargo externo";
            else if (codCargo != 103)
                cargo = "Cargo externo";

        }

        public void calcularSalario()
        {
            if (cargo == "Gerente")
                porcentagemAumento = 10;
            else if (cargo == "Engenheiro")
                porcentagemAumento = 20;
            else if (cargo == "Técnico")
                porcentagemAumento = 30;
            else if (cargo != "Gerente")
                porcentagemAumento = 40;
            else if (cargo != "Engenheiro")
                porcentagemAumento = 40;
            else if (cargo != "Técnico")
                porcentagemAumento = 40;

            if (cargo == "Gerente")
                aumentoSalario = 1.1;
            else if (cargo == "Engenheiro")
                aumentoSalario = 1.2;
            else if (cargo == "Técnico")
                aumentoSalario = 1.3;
            else if (cargo != "Gerente")
               aumentoSalario = 1.4;
            else if (cargo != "Engenheiro")
                aumentoSalario = 1.4;
            else if (cargo != "Técnico")
                aumentoSalario = 1.4;

            Console.WriteLine($"- O seu cargo é {codCargo} - {cargo}");
            Console.WriteLine("                         ");
            Console.WriteLine($"- Você receberá um aumento de {porcentagemAumento}%");
            Console.WriteLine("                         ");
            Console.WriteLine($"- Salário antigo: R${salario}");
            Console.WriteLine("                         ");
            Console.WriteLine($"- Novo salário: R${salario * aumentoSalario}");
            Console.WriteLine("                         ");
            Console.WriteLine($"- Diferença entre o salário antigo e o novo: R${(salario * aumentoSalario) - salario}");
            Console.WriteLine("                         ");
        }
    }
}
