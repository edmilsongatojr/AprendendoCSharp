using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Condicionais 2");

            int idadeJoao = 18;
            //int quantidadePessoa = 1;
            //bool acompanhado = quantidadePessoa >= 2;

            bool acompanhado = true;

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("\nEntrada Liberada!");
            }
            else
            {
                Console.WriteLine("\nEntrada Bloqueada!");
            }

            Console.WriteLine("\nExcecução Finalizada! Clique enter para finalizar...");
            Console.ReadLine();
        }
    }
}
