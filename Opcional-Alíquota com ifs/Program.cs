using System;

namespace Opcional_Alíquota_com_ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Tarefa Opcional - Aliquotas com ifs");

            //De 1900.0 até 2800.0, o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142;
            //De 2800.01 até 3751.0, o IR é de 15 % e pode deduzir R$ 350;
            //De 3751.01 até 4664.00, o IR é de 22.5 % e pode deduzir R$ 636.

            //double salario = 3300.0;
            double salario = 8000;
            bool regraIR1 = salario < 1900.0;
            bool regraIR2 = salario >= 1900.0 && salario <= 2800.0;
            bool regraIR3 = salario > 2800.0 && salario <= 3751.0;
            bool regraIR4 = salario > 3751.0 && salario <= 4664.0;
            bool regraIR5 = salario > 4664.0;

            //TESTE COMENTARIO
            if (regraIR1)
            {
                Console.WriteLine("Salário é de R$ " + salario + "\nMenor que o Valor minimo, nesse caso não existe dedução de IR!");
            }
            else if (regraIR2)
            {
                Console.WriteLine("Salário é de R$ " + salario + "\n O IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
            }
            else if (regraIR3)
            {
                Console.WriteLine("Salário é de R$ " + salario + "\n O IR é de 15% e pode deduzir R$ 350");
            }
            else if (regraIR4)
            {
                Console.WriteLine("Salário é de R$ " + salario + "\n O IR é de 22.5% e pode deduzir R$ 636");
            }
            else if (regraIR5)
            {
                Console.WriteLine("Salário é de R$ " + salario + "\n O IR é de 25% e pode deduzir R$ 800");
            }
            else
            {
                Console.WriteLine("Ocorreu algum erro na condição de verificação do IR sobre o Salário");
            }



            Console.WriteLine("\nExcecução Finalizada! Clique enter para finalizar...");
            Console.ReadLine();
        }
    }
}
