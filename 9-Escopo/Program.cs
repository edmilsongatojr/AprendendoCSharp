using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 9 - Escopo");

            int idadeJoao = 16;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado)
            {
                mensagemAdicional = "João está acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                mensagemAdicional = "João não está acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }
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
