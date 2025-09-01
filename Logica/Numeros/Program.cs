using System;

//int n1 = Convert.ToInt32(Console.ReadLine());

namespace Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dobro: {n1 * 2}");
            Console.WriteLine($"Triplo: {n1 * 3}");

            Console.WriteLine("Digite ENTER para encerrar: ");
            Console.ReadLine();
        }
    }
}
