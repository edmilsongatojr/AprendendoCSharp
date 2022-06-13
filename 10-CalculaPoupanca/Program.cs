using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcudora de Poupança");

            double valorInvestido = 1000.00;
            double jurosPoupanca = 0.0036;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido += valorInvestido *  jurosPoupanca;
                Console.WriteLine("Após "+ contadorMes +"° mês, você terá R$ " + valorInvestido);
                contadorMes++;
            }

            
            Console.WriteLine("\nExcecução Finalizada! Clique enter para finalizar...");
            Console.ReadLine();
        }
    }
}
