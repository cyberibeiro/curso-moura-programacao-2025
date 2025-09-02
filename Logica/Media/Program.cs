using System;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Média--");

            Console.Write("Insira a 1º nota: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Insira a 2º nota: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Insira a 3º nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double MediaFinal = (n1 + n2 + n3) / 3;

            if (MediaFinal > 7)
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine("Reprovado");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
