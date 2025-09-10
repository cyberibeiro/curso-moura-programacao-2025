using System;

namespace Comparacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Comparação--");

            Console.Write("Digite um número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número:");
            int n2 = int.Parse(Console.ReadLine());


            /* 
             * Estrutura de decisão composta dentro de outra estrutra de decisão composta (aninhadas)
             * 
            if (n1 > n2)
                Console.WriteLine($"O maior é {n1}");
            else
            {
                if (n2 > n1)
                    Console.WriteLine($"O maior é {n2}");
                else
                {
                    if (n1 == n2)
                        Console.WriteLine("Os números são iguais");
                }                    
            }
            */

            /*
                * Estrutura de decisão composta dentro de outra estrutra de decisão composta (aninhadas)
                * 
            if (n1 > n2)
                Console.WriteLine($"O maior é {n1}");
            else
            {
                if (n2 > n1)
                    Console.WriteLine($"O maior é {n2}");
                else
                    Console.WriteLine("Os números são iguais");                
            }
            */

            /*
                * Estrutura de decisão composta dentro de outra estrutra de decisão composta (aninhadas)
                * 
            if (n1 > n2)
                Console.WriteLine($"O maior é {n1}");
            else
                if (n2 > n1)
                    Console.WriteLine($"O maior é {n2}");
                else
                    Console.WriteLine("Os números são iguais");
            */

            /*
             * Estrutura de decisão encadeada (iguais as anteriores, mas escrita de uma forma diferente)
             */

            if (n1 > n2)
                Console.WriteLine($"O maior é {n1}");
            else if (n2 > n1)
                Console.WriteLine($"O maior é {n2}");
            else
                Console.WriteLine("Os números são iguais");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}

