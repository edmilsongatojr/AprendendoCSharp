using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11 - Calcudora de Poupança 2");

            double valorInvestido = 1000.00;
            double jurosPoupanca = 0.0036;
            //int contadorMes = 1;

            //while (contadorMes <= 12)
            //{
            //    valorInvestido += valorInvestido * jurosPoupanca;
            //    Console.WriteLine("Após " + contadorMes + "° mês, você terá R$ " + valorInvestido);
            //    contadorMes++;
            //}
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido += valorInvestido * jurosPoupanca;
                Console.WriteLine("Após " + contadorMes + "° mês, você terá R$ " + valorInvestido);
            }

            Console.WriteLine("\nExcecução Finalizada! Clique enter para finalizar...");
            Console.ReadLine();
        }
    }
}
