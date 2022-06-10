using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4 - Conversoes E Outros Tipos Numericos");

            double salario = 1200.50;

            // O int é um tipo de varaivel de 32bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é um tipo de varaivel de 64bits
            long idade = 1300000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de varaivel de 16bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("Excecução Finalizada! Clique enter para finalizar...");
            Console.ReadLine();
        }
    }
}
