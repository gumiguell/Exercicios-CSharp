using System;

namespace EX11_mesesDoAno
{
    internal class Meses
    {
        private int mes;
        public void Calendario()
        {
            Console.WriteLine("Escolha um número (1-2-3-4-5-6-7-8-9-10-11-12)");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            switch (mes)
            {

                case 1:
                    Console.WriteLine("Janeiro - Ano Novo"); break;
                case 2:
                    Console.WriteLine("Fevereiro - Carnaval"); break;
                case 3:
                    Console.WriteLine("Março - Páscoa"); break;
                case 4:
                    Console.WriteLine("Abril - Tiradentes"); break;
                case 5:
                    Console.WriteLine("Maio - Dia das Mães"); break;
                case 6:
                    Console.WriteLine("Junho - Festa Junina"); break;
                case 7:
                    Console.WriteLine("Julho - Férias"); break;
                case 8:
                    Console.WriteLine("Agosto - Dia dos Pais"); break;
                case 9:
                    Console.WriteLine("Setembro - Mês da Independência"); break;
                case 10:
                    Console.WriteLine("Outubro - Dia das Crianças"); break;
                case 11:
                    Console.WriteLine("Novembro - Finados"); break;
                case 12:
                    Console.WriteLine("Dezembro - Natal"); break;
                default:
                    Console.WriteLine("-ERRO- Digite um número de 1 a 12"); break;
            }
        }
    }
}
