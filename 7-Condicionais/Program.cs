using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoa = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade.\nEntrada Liberada!");
            }
            else
            {
                if (quantidadePessoa >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhando.\nEntrada Liberada!");
                }
                else
                {
                    Console.WriteLine("João possui menos de 18 anos de idade.\nEntrada Bloqueada!");
                }

            }

            Console.WriteLine("\nExcecução Finalizada! Clique enter para finalizar...");
            Console.ReadLine();
        }
    }
}
