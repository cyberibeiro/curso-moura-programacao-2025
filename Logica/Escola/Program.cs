using System;

/*
 * O usuario vai entrar com o nome do aluno e 5 notas para este aluno (estrutura de repetição).
 * Calcular a média e apresentar nome do aluno e sua média
 * "Aluno1 média 7."
 * Reprovado : < 5
 * Exame : >= 5 e < 7
 * Aprovado : >= 7
 * Colocar o programa em loop para o usuário entrar com quantos alunos ele desejar.
 * No final, o programa deve exibir a quantidade total de alunos e quantos foram reprovados, ficaram em exame e aprovados.
 * Total Alunos: 10
 * Reprovados: 2
 * Exame: 5
* Aprovados: 3
*/

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Escola--");
            
            const int QUNTDNOTA = 5;
            double somaNotas = 0;
            string respostaUsuario = "s";
            int QuantidadeAprovado = 0;
            int QuantidadeReprovado = 0;
            int QuantidadeExame = 0;
            int alunosTotal = 0;
            string nomeAluno;

            do
            {
                Console.WriteLine("\nInforme os dados do aluno: ");
                Console.Write("\nInsira o nome do Aluno: ");
                nomeAluno = Console.ReadLine();
                alunosTotal += 1;

                somaNotas = 0; // zera para cada aluno
                for (int i = 1; i <= QUNTDNOTA; i++)
                {
                    Console.Write($"Insira a nota {i}: ");
                    somaNotas += double.Parse(Console.ReadLine());
                }

                double notaMedia = somaNotas / QUNTDNOTA;

                if (notaMedia >= 7)
                {
                    Console.WriteLine($"Aluno {nomeAluno} está aprovado! Média: {notaMedia:F2}");
                    QuantidadeAprovado++;
                }
                else if (notaMedia >= 5)
                {
                    Console.WriteLine($"Aluno {nomeAluno} está em exame. Média: {notaMedia:F2}");
                    QuantidadeExame++;
                }
                else
                {
                    Console.WriteLine($"Aluno {nomeAluno} está reprovado. Média: {notaMedia:F2}");
                    QuantidadeReprovado++;
                }

                Console.Write("\nGostaria de inserir o nome de mais um aluno (s/n)? ");
                respostaUsuario = Console.ReadLine().ToLower();

            } while (respostaUsuario == "s");

            Console.WriteLine("\n--Quantidade Total--");
            Console.WriteLine($"\nTotal de Alunos: {alunosTotal}");
            Console.WriteLine($"Total de Aprovados: {QuantidadeAprovado}");
            Console.WriteLine($"Total de Reprovados: {QuantidadeReprovado}");
            Console.WriteLine($"Total de Exame: {QuantidadeExame}");

            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();

        }
    }
}
