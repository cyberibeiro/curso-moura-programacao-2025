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

            Console.WriteLine($"Média final: {(n1 + n2 + n3) / 3}");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
