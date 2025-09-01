using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Calculadora--");

            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());

            // Operadores aritméticos

            Console.WriteLine($"Soma: {n1 + n2}");
            Console.WriteLine($"Subtração: {n1 - n2}");
            Console.WriteLine($"Multiplicação: {n1 * n2}");
            Console.WriteLine($"Divisão: {n1 / n2}");
            Console.WriteLine($"Resto da divisão: {(double) n1 % n2}");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
