using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 12 - Calcudora de Investimento a Longo Prazo");

            double valorInvestido = 1000.00;
            double valorInicialInvestido = valorInvestido;
            double jurosPoupanca = 1.0036;
            double contadorAno;

            for ( contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= jurosPoupanca;
                    Console.WriteLine("Após " + contadorMes + "° mês, você terá R$ " + valorInvestido);

                }
                jurosPoupanca += 0.0010;
                Console.WriteLine("----------------Fim do " + contadorAno + "° Ano----------------");
                Console.WriteLine("Total Investido no Final do " + contadorAno + "° Ano: R$ " + valorInvestido);
                Console.WriteLine("Total do Rendimento: R$ " + (valorInvestido - valorInicialInvestido +"\n"));
            }
            Console.WriteLine("\nTotal de Anos Investidos: " + (contadorAno-1) + " Anos.");
            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);
            Console.WriteLine("\nExcecução Finalizada! Clique enter para finalizar...");
            Console.ReadLine();
        }
    }
}
