using System;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Loteria--");

            Console.Write("Insira o valor do prêmio: ");
            double premio = double.Parse(Console.ReadLine());

            Console.Write("Valores apostados de cada amigo: ");
            Console.WriteLine("Amigo 1: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Amigo 2: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Amigo 3: ");
            double a3 = double.Parse(Console.ReadLine());

            double soma_aposta = a1 + a2 + a3;

            Console.WriteLine("Valores recebidos");
            Console.WriteLine($"Amigo1: {a1 / soma_aposta * premio}");

            Console.WriteLine("Valores recebidos");
            Console.WriteLine($"Amigo1: {a2 / soma_aposta * premio}");

            Console.WriteLine("Valores recebidos");
            Console.WriteLine($"Amigo1: {a3 / soma_aposta * premio}");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
