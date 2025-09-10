using System;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NUMEROMAXIMODEFALTAS = 20;

            Console.WriteLine("--Média--");

            Console.Write("Digite o número de faltas:");
            int faltas = int.Parse(Console.ReadLine());

            if (faltas <= NUMEROMAXIMODEFALTAS)
            {
                Console.WriteLine("Digite 3 notas:");

                Console.Write("Nota 1:");
                double nota1 = double.Parse(Console.ReadLine());

                Console.Write("Nota 2:");
                double nota2 = double.Parse(Console.ReadLine());

                Console.Write("Nota 3:");
                double nota3 = double.Parse(Console.ReadLine());

                double media = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine($"Média: {media:0.00}");

                if (media >= 7)
                    Console.WriteLine("Aprovado");
                else if (media >= 5)
                    Console.WriteLine("Recuperação");
                else
                    Console.WriteLine("Reprovado");
            }
            else
                Console.WriteLine("Reprovado por faltas");

            /*
             *  >= 7 Aprovado - ok
                Entre 5 e menor que 7 Recuperação
                < 5 Reprovado
             */

            /*
            if (media < 5)
                Console.WriteLine("Reprovado");
            else if (media < 7)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Aprovado");

            if (media >= 7)
                Console.WriteLine("Aprovado");
            else if (media < 5)
                Console.WriteLine("Reprovado");
            else
                Console.WriteLine("Recuperação");
            */

            /*
            if (media > 7)
                Console.WriteLine("Aprovado");
            if (media <= 7)
                Console.WriteLine("Reprovado");
            */

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
