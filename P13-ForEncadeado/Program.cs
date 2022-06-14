using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 13 - For Encadeado");

            for (int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
            {
                for (int contadoColuna = 0; contadoColuna <= 10; contadoColuna++)
                {
                    Console.Write("*");
                   if(contadoColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                
                Console.WriteLine();
            }

            //SEGUNDA FORMA DE DESENHAR OS ASTERISCOS
            for (int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
            {
                for (int contadoColuna = 0; contadoColuna <= contadorLinha; contadoColuna++)
                {
                    Console.Write("*");
                   
                }

                Console.WriteLine();
            }
            Console.WriteLine("\nExcecução Finalizada! Clique enter para finalizar...");
            Console.ReadLine();
        }
    }
}
