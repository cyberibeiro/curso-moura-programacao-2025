using System;

namespace AntSuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Antecessor e Sucessor---\n");

            Console.Write("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Antecessor: {numero - 1 }\nSucessor: {numero + 1}");

            Console.WriteLine("\nPressione ENTER para finalizar o programa");
            Console.ReadLine();
        }
    }
}
