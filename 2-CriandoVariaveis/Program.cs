using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;

            Console.WriteLine("Idade sem operadores: "+idade);

            idade = 10;
            Console.WriteLine("Idade com o dados inserido alterado: "+idade);

            idade = 10 + 5;
            Console.WriteLine("Idade com operador +: " + idade);

            idade = 10 + 5 * 2;
            Console.WriteLine("Idade com operador *: " + idade);

            idade = 10 + 5 / 2;
            Console.WriteLine("Idade com operador /: " + idade);

            idade = 10 - 2;
            Console.WriteLine("Idade com operador -: " + idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Idade com () para definir prioridade no cálculo" + idade+"!");

            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
