using System;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Projeto Salario
             Faça um Programa que pergunte quanto você ganha por hora 
             e o número de horas trabalhadas no mês. 
             Calcule e mostre o total do seu salário no referido mês, 
             sabendo-se que são descontados 11% para o Imposto de Renda, 
             8% para o INSS e 5% para o sindicato,
            Assim, o programa de exibir:
                salário bruto = ganho por hora * horas trabalhadas no mês
                quanto pagou ao IR
                quanto pagou ao INSS
                quanto pagou ao Sindicato
                Salário líquido = Salário Bruto - Descontos

            dessa forma:
            + Salário Bruto : R$  
            - IR (11%) : R$
            - INSS (8%) : R$
            - Sindicato (5%) : R$
            = Salário Líquido : R$
             */

            Console.WriteLine("--Salario--\n");

            Console.Write("Digite o valor que você recebe por hora: ");
            double valorPorHora = double.Parse(Console.ReadLine());
            Console.Write("Digite quantas horas você trabalha no mês: ");
            double horasTrabalho = double.Parse(Console.ReadLine());

            double salarioBruto = valorPorHora * horasTrabalho;
            double impostoRenda = (salarioBruto * 11) / 100 ;
            double inss = (salarioBruto * 8) / 100;
            double sindicato = (salarioBruto * 5) / 100;
            double salarioLiquido = salarioBruto - impostoRenda - inss - sindicato; 

            Console.WriteLine($"\n+Salário Bruto: R$ {salarioBruto:0.00}");
            Console.WriteLine($"-IR (11%): R$ {impostoRenda:0.00}");
            Console.WriteLine($"-INSS (8%): R$ {inss:0.00}");   
            Console.WriteLine($"-Sindicato (5%): R$ {sindicato:0.00}"); 
            Console.WriteLine($"=Salário Líquido: R$ {salarioLiquido:0.00}");

            Console.WriteLine($"\n+Salário Bruto: R$ {salarioBruto:0.00}\n-IR (11%): R$ {impostoRenda:0.00}\n-INSS (8%): R$ {inss:0.00}" +
                $"\n-Sindicato (5%): R$ {sindicato:0.00}\n=Salário Líquido: R$ {salarioLiquido:0.00}\n");

            Console.WriteLine("Pressione ENTER para finalizar o programa");
            Console.ReadLine();
        }
    }
}
