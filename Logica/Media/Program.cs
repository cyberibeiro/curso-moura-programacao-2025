using System;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* REQUISITOS

            - Verificar se o aluno está APROVADO, em RECUPERAÇÃO ou REPROVADO de acordo com faltas e notas:

            Total de faltas para ser reprovado => 20

            calcular a média das notas(3):
            média >= 7 Aprovado.
            média entre 5 e menor que 7 Recuperação.
            média < 5 Reprovado.*/

            const int NUMEROMAXIMODEFALTAS = 20;
                
            Console.WriteLine("--Média--");

            Console.Write("Insira o número de faltas: ");
            double faltas  = double.Parse(Console.ReadLine());

            if (faltas <= NUMEROMAXIMODEFALTAS)
            {
                Console.Write("Insira a 1º nota: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.Write("Insira a 2º nota: ");
                double n2 = double.Parse(Console.ReadLine());
                Console.Write("Insira a 3º nota: ");
                double n3 = double.Parse(Console.ReadLine());

                double Media = (n1 + n2 + n3) / 3;
    
                Console.WriteLine($"Média: {Media:0.00}"); 

                if (Media >= 7)
                    Console.WriteLine("Aprovado");
                else if (Media >= 5)
                    Console.WriteLine("Recuperação");
                else
                    Console.WriteLine("Reprovado");
            }
            else
                Console.WriteLine($"Reprovado por faltas");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}