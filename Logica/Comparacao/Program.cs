using System;

namespace Comparaçao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("--Comparação--");

            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine($"O maior é {n1}");
            }
            else
            {
                if (n2 > n1)
                    Console.WriteLine($"O maior é {n2}");
                else
                    Console.WriteLine("Os números são iguais");
            }

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
