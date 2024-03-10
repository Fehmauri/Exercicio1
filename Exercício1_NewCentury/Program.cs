using System;

class Program
{
    static void Main(string[] args)
    {
        double salarioAtual, percentualAumento, valorAumento, novoSalario;
        string resposta = "SIM";

        while (resposta == "SIM")
        {
            Console.Write("Digite o salário atual: R$ ");
            salarioAtual = double.Parse(Console.ReadLine());

            if (salarioAtual <= 280.00)
            {
                percentualAumento = 20.00;
            }
            else if (salarioAtual <= 700.00)
            {
                percentualAumento = 15.00;
            }
            else if (salarioAtual <= 1500.00)
            {
                percentualAumento = 10.00;
            }
            else
            {
                percentualAumento = 5.00;
            }

            valorAumento = (salarioAtual * percentualAumento) / 100.00;

            novoSalario = salarioAtual + valorAumento;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Salário antes do reajuste: R$ {0:F2}", salarioAtual);
            Console.WriteLine("Percentual de aumento: {0:F2}%", percentualAumento);
            Console.WriteLine("Valor do aumento: R$ {0:F2}", valorAumento);
            Console.WriteLine("Novo salário: R$ {0:F2}", novoSalario);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Deseja continuar? (Sim/Nao)");
            resposta = Console.ReadLine().ToUpper();
            Console.WriteLine("------------------------------------");
        }
    }
}