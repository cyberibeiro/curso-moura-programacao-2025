using System;

/*
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
= Salário Líquido : R$
 */


namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Salário--\n");

            Console.Write("Quanto você ganha por hora:");
            double valorGanhoPorHora = double.Parse(Console.ReadLine());

            Console.Write("Quantas horas você trabalhou no mês:");
            double horasTrabalhadasNoMes = double.Parse(Console.ReadLine());

            double salarioBruto = valorGanhoPorHora * horasTrabalhadasNoMes;
            double ir = salarioBruto * 0.11;
            double inss = salarioBruto * 0.08;
            double sindicato = salarioBruto * 0.05;

            Console.WriteLine($"\n+ Salário Bruto : R$ {salarioBruto:0.00}");
            Console.WriteLine($"- IR(11 %) : R$ {ir:0.00}");
            Console.WriteLine($"- INSS(8 %) : R$ {inss:0.00}");
            Console.WriteLine($"- Sindicato(5 %) : R$ {sindicato:0.00}");
            Console.WriteLine($"= Salário Líquido : R$ {salarioBruto - ir - inss - sindicato:0.00}");

            /*
             * Outra formato de impressão.
            Console.Write($"\n+ Salário Bruto : R$ {salarioBruto:0.00}\n- IR(11 %) : R$ {ir:0.00}\n- INSS(8 %) : R$ {inss:0.00}\n- Sindicato(5 %) : R$ {sindicato:0.00}\n= Salário Líquido : R$ {salarioBruto - ir - inss - sindicato:0.00}");
            */

            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
